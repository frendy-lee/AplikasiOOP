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
    public partial class Tambah_Makanan : Form
    {
        OleDbConnection database;
        Menu_Makanan mm = new Menu_Makanan();
        public string idmakanan { set; get; }
        public string namamakanan { set; get; }
        public int hargamakanan { set; get; }
        public int satuanmakanan {set; get; }
        public DateTime tanggal { set; get; }
        public string keterangan {set; get; }

        public Tambah_Makanan()
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
        
        ArrayList slect1;

        public bool savemakanan(string idmakanan, string namamakanan, int hargamakanan, DateTime tanggal, string keterangan)
        {
            string queryInsertUser = "INSERT INTO tb_menu([kode_menu],[nama_menu],[harga],[tanggal],[keterangan]) VALUES('" + idmakanan + "','" + namamakanan + "','" + int.Parse(hargamakanan.ToString()) + "','"+ tanggal +"','" + keterangan + "')";
            OleDbCommand SQLInsert = new OleDbCommand(queryInsertUser, database);
            int result = SQLInsert.ExecuteNonQuery();
            MessageBox.Show(result.ToString());
            if (result == 1)
                return true;
            else
                return false;
             
        }
        private void Tambah_Makanan_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && textBox6.Text != null)
            {
                idmakanan = textBox1.Text;
                namamakanan = textBox2.Text;
                hargamakanan = int.Parse(textBox3.Text);
                keterangan = textBox6.Text;
                tanggal = dateTimePicker1.Value;
                savemakanan(idmakanan,namamakanan,hargamakanan,tanggal,keterangan);
            }
            mm.Show();
            Close();
            slect1.Add(new tambahmakanan(s1.ToString(), s2.ToString(), int.Parse(s3.ToString()), int.Parse(s5.ToString()),sekarang, s6.ToString()));
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
