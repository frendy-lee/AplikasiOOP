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
        }

        private void buttonkembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void buttonhistory_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=../../Dbase/TP.mdb";
            string sql = "SELECT id_user, kd_kegiatan, waktu FROM tb_history";
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, connection);
            DataSet dataset = new DataSet();
            connection.Open();
            dataAdapter.Fill(dataset, "Kegiatan");
            connection.Close();
            datagridhistory.DataSource = dataset;
            datagridhistory.DataMember = "Kegiatan";
        }

        private void datagridhistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            loadDataGrid(select);
        }
    }
}
