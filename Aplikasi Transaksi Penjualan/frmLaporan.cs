using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;

namespace Aplikasi_Transaksi_Penjualan
{
    public partial class frmLaporan : Form
    {
        public OleDbConnection database;
        ArrayList selectedmenu;

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
            selectedmenu = new ArrayList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Apakah Anda yakin ingin Keluar ?", "Question" , MessageBoxButtons.YesNo);
            Application.Exit();
        }

        private void btnHarian_Click(object sender, EventArgs e)
        {
            int a = dateTimePicker1.Value.Day;
            btnHarian.Location = new Point(154, 146);
            btnBulanan.Location = new Point(456, 146);
            btnTahunan.Location = new Point(299, 305);
            timer1.Enabled = true;
            timer2.Enabled = false;
            timer3.Enabled = false;
            OleDbCommand SQLQuery = new OleDbCommand();
            SQLQuery.CommandText = "Select [id_user], [kode_member], [waktu], [total] from tb_transaksi WHERE '" + a + "' = DatePart('d', waktu)";
            SQLQuery.Connection = database;
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(SQLQuery);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnTahunan_Click(object sender, EventArgs e)
        {
            int a = dateTimePicker1.Value.Year;
            btnHarian.Location = new Point(154, 146);
            btnBulanan.Location = new Point(456, 146);
            btnTahunan.Location = new Point(299, 305);
            timer1.Enabled = false;
            timer2.Enabled = true;
            timer3.Enabled = false;
            OleDbCommand SQLQuery = new OleDbCommand();
            SQLQuery.CommandText = "Select [id_user], [kode_member], [waktu], [total] from tb_transaksi WHERE '" + a + "' = DatePart('yyyy', waktu)";
            SQLQuery.Connection = database;
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(SQLQuery);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnBulanan_Click(object sender, EventArgs e)
        {
            int a = dateTimePicker1.Value.Month;
            btnHarian.Location = new Point(154, 146);
            btnBulanan.Location = new Point(456, 146);
            btnTahunan.Location = new Point(299, 305);
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = true;
            OleDbCommand SQLQuery = new OleDbCommand();
            SQLQuery.CommandText = "Select [id_user], [kode_member], [waktu], [total] from tb_transaksi WHERE '" + a + "' = DatePart('m', waktu)";
            SQLQuery.Connection = database;
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(SQLQuery);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnBulanan.Show();
            btnTahunan.Show();
            if (btnBulanan.Location.X == 20)
            {
                btnTahunan.Location = new Point(btnTahunan.Location.X - 1, 300);
                if (btnTahunan.Location.X == 20)
                {
                    timer1.Stop();
                }
            }
            else
            {
                btnBulanan.Location = new Point(btnBulanan.Location.X - 2, 200);
                btnTahunan.Location = new Point(btnTahunan.Location.X - 1, 300);
            }
            btnHarian.Hide();
            dataGridView1.Visible = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            btnHarian.Show();
            btnBulanan.Show();

            if (btnHarian.Location.X == 20)
            {
                btnBulanan.Location = new Point(btnBulanan.Location.X - 2, 200);
                if (btnBulanan.Location.X == 20)
                    timer2.Stop();
            }
            else
            {
                btnHarian.Location = new Point(btnHarian.Location.X - 2, 100);
                btnBulanan.Location = new Point(btnBulanan.Location.X - 2, 200);
            }
            btnTahunan.Hide();
            dataGridView1.Visible = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            btnHarian.Show();
            btnTahunan.Show();
            int a = 20;
            if (btnHarian.Location.X == a)
            {
                btnTahunan.Location = new Point(btnTahunan.Location.X - 2, 300);
                if (btnTahunan.Location.X == a)
                    timer3.Stop();
            }
            else
            {
                btnHarian.Location = new Point(btnHarian.Location.X - 2, 100);
                btnTahunan.Location = new Point(btnTahunan.Location.X - 1, 300);
            }
            btnBulanan.Hide();
            dataGridView1.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
