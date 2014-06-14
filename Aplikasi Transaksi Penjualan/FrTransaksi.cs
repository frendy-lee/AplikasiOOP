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

namespace Aplikasi_Transaksi_Penjualan
{
    public partial class FrTransaksi : Form
    {
        OleDbConnection database;

        public class Mnu
        {
            public string kode { get; set; }
            public string nama { set; get; }
            public int harga { set; get; }
        }

        public FrTransaksi()
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
        }

        public void loadComboBox()
        {
            string[] option = new string[0];
            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = new DataTable();
            SQLQuery.CommandText = "SELECT kode_menu,nama_menu FROM tb_menu";
            SQLQuery.Connection = database;
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            foreach (DataRow row in data.Rows)
            {
                Array.Resize(ref option, option.Length + 1);
                option[option.GetUpperBound(0)] = row[0].ToString() + " - " + row[1].ToString();
            }

            selectmenu.DataSource = option;
        }

        public void loadDataGrid()
        {
            //Mnu[] arrStudents = new Mnu[1];
            //arrStudents[0] = new Mnu();
            //arrStudents[0].Age = 8;
            //arrStudents[0].GPA = 3.5;
            //arrStudents[0].Name = "Bob";

            //dataGridView1.DataSource = arrStudents;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrTransaksi_Load(object sender, EventArgs e)
        {
            DateTime sekarang;
            sekarang = DateTime.Now;

            tanggal.Text = sekarang.ToShortDateString();
            waktu.Text = sekarang.ToLongTimeString();
            loadComboBox();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buka_Click(object sender, EventArgs e)
        {
            loadDataGrid();
        }
    }
}
