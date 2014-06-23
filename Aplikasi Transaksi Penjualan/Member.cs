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
    public partial class Member : Form
    {



        

        OleDbConnection database7;

        public Member()

        {

            InitializeComponent();

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=../../Dbase/TP.mdb";

            try

            {

                database7 = new OleDbConnection(connectionString);

                database7.Open();

            }

            catch(Exception ex)

            {

                Console.WriteLine(ex.Message);

                return;

            }



        }

        public void loadListBox()
        {
            string[] option = new string[0];
            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = new DataTable();
            SQLQuery.CommandText = "SELECT kode_member FROM tb_member";
            SQLQuery.Connection = database7;
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
        private void Member_Load(object sender, EventArgs e)

        {

            loadListBox();

        }

        

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)

        {



            

        }



        private void button1_Click(object sender, EventArgs e)

        {



            TambahMember tb = new TambahMember();

            

            tb.Show(); 

            Close();

            

        }


         



        private void listBox1_SelectedValueChanged_1(object sender, EventArgs e)
        {
            string pilih = listBox1.GetItemText(listBox1.SelectedItem);
            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = new DataTable();
            SQLQuery.CommandText = "SELECT * FROM tb_member WHERE [kode_member] = '" + pilih + "'";
            SQLQuery.Connection = database7;
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            foreach (DataRow row in data.Rows)
            {
                lblnama.Text = row["nama_member"].ToString();
                tglDaftar.Text = row["tanggal_daftar"].ToString();
                noKTP.Text = row["no_ktp"].ToString();
                alamat.Text = row["alamat"].ToString();
            }
            kode.Text = pilih;
        }
        public void cari(string kode1)
        {
            string ketik = listBox1.GetItemText(listBox1.SelectedItem);
            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = new DataTable();
            SQLQuery.CommandText = "SELECT * FROM tb_member WHERE [kode_member] = '" + kode1 + "'";
            SQLQuery.Connection = database7;
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            foreach (DataRow row in data.Rows)
            {
                kode.Text = row["kode_member"].ToString();
                lblnama.Text = row["nama_member"].ToString();
                tglDaftar.Text = row["tanggal_daftar"].ToString();
                noKTP.Text = row["no_ktp"].ToString();
                alamat.Text = row["alamat"].ToString();
            }
            //kode.Text = ketik;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string kode;
            kode = textBox1.Text;
            cari(kode);
        }
        public void deleteMember(string kode)
        {
            string queryInsertUser = "DELETE FROM tb_member WHERE kode_member = '" + kode + "'";
            OleDbCommand SQLInsert = new OleDbCommand(queryInsertUser, database7);
            int result = SQLInsert.ExecuteNonQuery();
            if (result == 1)
                MessageBox.Show(kode + " Dihapus");
            else
                MessageBox.Show("Gagal");

            listBox1.Items.Clear();
            loadListBox();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string kodeM;
            if (kode.Text != null)
            {
                kodeM= kode.Text;
                deleteMember(kodeM);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            index i = new index();
            i.Show();
        }



        
    }

}
