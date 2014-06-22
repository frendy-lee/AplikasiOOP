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
            Application.Exit();
        }

        private void btnHarian_Click(object sender, EventArgs e)
        {
            int a = dateTimePicker1.Value.Day;
            btnHarian.Location = new Point(154, 146);
            btnBulanan.Location = new Point(456, 146);
            btnTahunan.Location = new Point(299, 305);
            timer3.Enabled = true;
            OleDbCommand SQLQuery = new OleDbCommand();
            SQLQuery.CommandText = "Select [id_user], [kode_member], tanggal , [total] from tb_transaksi WHERE '" + a + "' = DATEPART('d', tanggal)";
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
            timer3.Enabled = true;
            OleDbCommand SQLQuery = new OleDbCommand();
            SQLQuery.CommandText = "Select [id_user], [kode_member], tanggal, [total] from tb_transaksi WHERE '" + a + "' = DatePart('yyyy', tanggal)";
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
            timer3.Enabled = true;
            OleDbCommand SQLQuery = new OleDbCommand();
            SQLQuery.CommandText = "Select [id_user], [kode_member], tanggal, [total] from tb_transaksi WHERE '" + a + "' = DatePart('m', tanggal)";
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
        private void timer3_Tick(object sender, EventArgs e)
        {
            btnHarian.Show();
            btnBulanan.Show();
            btnTahunan.Show();
            int a = 20;
            if (btnHarian.Location.X == a)
            {
                if (btnTahunan.Location.X == a)
                {
                    timer3.Stop();
                }
                else
                {
                    btnBulanan.Location = new Point(btnBulanan.Location.X - 3, 200);
                    btnTahunan.Location = new Point(btnTahunan.Location.X - 2, 300);
                }
            }
            else
            {
                btnHarian.Location = new Point(btnHarian.Location.X - 2, 100);
                btnBulanan.Location = new Point(btnBulanan.Location.X - 2, 200);
                btnTahunan.Location = new Point(btnTahunan.Location.X - 1, 300);
            }
            dataGridView1.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
