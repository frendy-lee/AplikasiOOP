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
    public partial class Menu_Makanan : Form
    {
        OleDbConnection database;
        public Menu_Makanan()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Tambah_Makanan tm = new Tambah_Makanan();
            tm.Show();
            Close();
        }
        public void Loadlist()
        {
            string[] option = new string[0];
            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = new DataTable();
            SQLQuery.CommandText = "SELECT kode_menu FROM tb_menu";
            SQLQuery.Connection = database;
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            foreach (DataRow row in data.Rows)
            {
                Array.Resize(ref option, option.Length + 1);
                option[option.GetUpperBound(0)] = row[0].ToString();
            }
            for (int i = 0; i < option.Length; i++)
            {
                listBox1.Items.Add(option[i]);
            }
        }

        private void listBox1_SelectedValueChanged_1(object sender, EventArgs e)
        {
            string pilih = listBox1.GetItemText(listBox1.SelectedItem);
            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = new DataTable();
            SQLQuery.CommandText = "SELECT * FROM tb_menu WHERE [kode_menu] = '" + pilih + "'";
            SQLQuery.Connection = database;
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            foreach (DataRow row in data.Rows)
            {
                nama.Text = row["nama_menu"].ToString();
                harga.Text = row["harga"].ToString();
                tanggal.Text = row["tanggal"].ToString();
                textBox2.Text = row["keterangan"].ToString();
            }
            kode.Text = pilih;
        }

        private void Menu_Makanan_Load(object sender, EventArgs e)
        {
            Loadlist();
        }

        private void keterangan_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            index i = new index();
            i.Show();
        }

       public void deletemakanan(string idmakanan)
        {
            string queryInsertUser = "DELETE FROM tb_menu WHERE kode_menu = '"+ idmakanan+"'";
            OleDbCommand SQLInsert = new OleDbCommand(queryInsertUser, database);
            int result = SQLInsert.ExecuteNonQuery();
            if (result == 1)
                MessageBox.Show(idmakanan + " Dihapus");
            else
                MessageBox.Show("Gagal");

            listBox1.Items.Clear();
            Loadlist();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idmakanan ;
            if (kode.Text != null)
            {
                idmakanan = kode.Text;
                deletemakanan(idmakanan);
            }
        }

    }
}
