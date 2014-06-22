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
        public class tambahmakanan
        {
            public string idmakanan { private set; get; }
            public string namamakanan { private set; get; }
            public int hargamakanan { private set; get; }
            public int satuanmakanan { private set; get; }
            public DateTime tanggal { private set; get; }
            public string keterangan { private set; get; }

            public tambahmakanan(string idmakanan, string namamakanan, int hargamakanan, int satuanmakanan, DateTime tanggal, string keterangan)
            {
                this.idmakanan = idmakanan;
                this.namamakanan = namamakanan;
                this.hargamakanan = hargamakanan;
                this.satuanmakanan = satuanmakanan;
                this.tanggal = tanggal;
                this.keterangan = keterangan;
                MessageBox.Show(this.idmakanan + "-" +this.namamakanan+ "-" +this.hargamakanan+ "-" +this.satuanmakanan+ "-" +this.keterangan);
            }
        }
        OleDbConnection database;
        ArrayList slect1;
        DataGridViewButtonColumn bdelete;

        public Tambah_Makanan()
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

            slect1 = new ArrayList();
        }

        private void Tambah_Makanan_Load(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("id-ID");
            DateTime sekarang;
            sekarang = DateTime.Now;

            /*Tanggal.Text = sekarang.ToString("dddd, dd-MMMM-yyyy", culture);
            timer1.Enabled = true;
            loadComboBox();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            string s3 = textBox3.Text;
            //string s4 = textBox4.Text;
            string s5 = textBox5.Text;
            string s6 = textBox6.Text;
            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = new DataTable();
            SQLQuery.CommandText = "SELECT kode_menu,nama_menu,harga FROM tb_menu";
            SQLQuery.Connection = database;
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            DateTime sekarang;
            sekarang = DateTime.Now;
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
            //waktu.Text = DateTime.Now.ToString("hh:mm:ss");
            //waktu.Font = new Font("DS-Digital", 16, FontStyle.Bold);
        }
    }
}
