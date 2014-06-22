using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
using System.Globalization;

namespace Aplikasi_Transaksi_Penjualan
{
    public partial class FrHistory : Form
    {
        public class menu_selected
        {
            public string userID { private set; get; }
            public string keg { private set; get; }

            public menu_selected(string userID, string keg)
            {
                this.userID = userID;
                this.keg = keg;
            }
        }

        OleDbConnection database;
        ArrayList select;

        public FrHistory()
        {
            InitializeComponent();
            //initiate DB connection
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=../../Dbase/TP.mdb";
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            select = new ArrayList();
        }

        private void FrHistory_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            loadComboBox();
        }

        public void loadComboBox()
        {
            string[] option = new string[0];
            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = new DataTable();
            SQLQuery.CommandText = "SELECT kd_kegiatan,nama_kegiatan FROM tb_kegiatan";
            SQLQuery.Connection = database;
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            foreach (DataRow row in data.Rows)
            {
                Array.Resize(ref option, option.Length + 1);
                option[option.GetUpperBound(0)] = row[0].ToString() + "-" + row[1].ToString();
            }

            selectkegiatan.DataSource = option;
        }

        public void loadDataGrid(ArrayList select)
        {
            datagridhistory.DataSource = null;
            datagridhistory.Columns.Clear();

            datagridhistory.DataSource = select;
            datagridhistory.AllowUserToAddRows = false;
            datagridhistory.ReadOnly = true;

            datagridhistory.Columns[0].Width = 100;
            datagridhistory.Columns[1].Width = 200;
            datagridhistory.Columns[2].Width = 100;
            datagridhistory.Columns[3].Width = 100;
            datagridhistory.Columns[4].Width = 100;
        }

        private void buttonkembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datagridhistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            loadDataGrid(select);
        }
    }
}
