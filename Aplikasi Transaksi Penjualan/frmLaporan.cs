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
    public partial class frmLaporan : Form
    {
        public OleDbConnection database;
        public frmLaporan()
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

        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Apakah Anda yakin ingin Keluar ?", "Question" , MessageBoxButtons.YesNo);
            Application.Exit();
        }

        private void btnHarian_Click(object sender, EventArgs e)
        {
            OleDbDataReader rdr = null;
            string querytampil = "Select * from tb_transaksi;";
            OleDbCommand SQLtampil = new OleDbCommand(querytampil, database);
            rdr = SQLtampil.ExecuteReader();
            rdr.Read();
            label1.Text = "Total dari Pembayaran tgl ini : \n";
            btnBulanan.Show();
            btnTahunan.Show();
            btnBulanan.Location = new Point(20, 200);
            btnTahunan.Location = new Point(20, 300);
            btnHarian.Hide();
            label1.Visible = true;
        }

        private void btnTahunan_Click(object sender, EventArgs e)
        {
            btnHarian.Show();
            btnBulanan.Show();
            btnHarian.Location = new Point(20, 100);
            btnBulanan.Location = new Point(20, 200);
            btnTahunan.Hide();
            label1.Visible = true;
            label1.Text = "Tahunan";
        }

        private void btnBulanan_Click(object sender, EventArgs e)
        {

            btnHarian.Show();
            btnTahunan.Show();
            btnHarian.Location = new Point(20, 100);
            btnTahunan.Location = new Point(20, 300);
            btnBulanan.Hide();
            label1.Visible = true;
            label1.Text = "Bulanan";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
