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
    public partial class FrTransaksi : Form
    {
        public class menu_selected
        {
            public string kode {private set; get; }
            public string nama { private set; get; }
            public int harga { private set; get; }
            public int jumlah { private set; get; }
            public int stotal { private set; get; }

            public menu_selected(string kode, string nama, int harga, int jumlah)
            {
                this.kode = kode;
                this.nama = nama;
                this.harga = harga;
                this.jumlah = jumlah;
                this.stotal = harga * jumlah;
            }

            public void update_menu(int jumlah){
                this.jumlah = jumlah;
                this.stotal = harga * jumlah;
            }
        }

        public class Mnu
        {
            public string kode { get; set; }
            public string nama { set; get; }
            public int harga { set; get; }
        }

        OleDbConnection database;
        ArrayList slect;
        DataGridViewButtonColumn bdelete;
        int subtotal, total, pajak, bayar, kembali;

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

            slect = new ArrayList();
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
                option[option.GetUpperBound(0)] = row[0].ToString() + "-" + row[1].ToString();
            }

            selectmenu.DataSource = option;
        }

        public void loadDataGrid(ArrayList slect)
        {
            subtotal = pajak = total = bayar = kembali = 0;
            if (slect.Count == 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();                
            }
            else
            {                
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();

                dataGridView1.DataSource = slect;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;

                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Width = 100;

                bdelete = new DataGridViewButtonColumn();
                bdelete.Name = "delete";
                bdelete.HeaderText = "Delete";
                bdelete.Text = "Delete";
                bdelete.FlatStyle = FlatStyle.Flat;                
                bdelete.UseColumnTextForButtonValue = true;
                bdelete.Width = 50;
                dataGridView1.Columns.Add(bdelete);

                foreach (menu_selected i in slect)
                    subtotal += i.stotal;

                pajak = (int)(subtotal * 0.1f);
                total = subtotal + pajak;                
            }
            txtstotal.Text = subtotal.ToString();
            txtpajak.Text = pajak.ToString();
            txttotal.Text = total.ToString();
            txtbayar.Text = bayar.ToString();
            txtkembali.Text = kembali.ToString();
        }

        private void FrTransaksi_Load(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("id-ID");
            DateTime sekarang;
            sekarang = DateTime.Now;

            tanggal.Text = sekarang.ToString("dddd, dd-MMMM-yyyy", culture);
            waktu.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Enabled = true;
            loadComboBox();
        }

        
        private void buka_Click(object sender, EventArgs e)
        {
            string selected = selectmenu.Text;
            string[] menu_split = (selected).Split('-');
            int jumlah = Convert.ToInt32(jumlahUpDown.Value);            
            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = new DataTable();
            SQLQuery.CommandText = "SELECT kode_menu,nama_menu,harga FROM tb_menu";
            SQLQuery.Connection = database;
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            bool exist = false;
            foreach (menu_selected i in slect)
            {
                if (i.kode == menu_split[0])
                {
                    exist = true;
                    MessageBox.Show("Data sudah pernah dimasukkan, jumlah akan diupdate");
                    foreach (DataRow row in data.Rows)
                    {
                        if (row[0].ToString() == menu_split[0])
                        {
                            i.update_menu(jumlah);
                            break;
                        }
                    }
                    break;
                }
            }
            if (exist == false)
            {
                foreach (DataRow row in data.Rows)
                {
                    if (row[0].ToString() == menu_split[0])
                    {
                        slect.Add(new menu_selected(menu_split[0], menu_split[1], int.Parse(row["harga"].ToString()), jumlah));
                        break;
                    }
                }
            }

            loadDataGrid(slect);
            txtbayar.Text = "";
            txtbayar.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            int currentRow = int.Parse(e.RowIndex.ToString());            
            if (dataGridView1.Columns[e.ColumnIndex] == bdelete && currentRow >= 0)
            {                
                slect.RemoveAt(currentRow);                               
            }

            loadDataGrid(slect);
        }

        private void txtbayar_Enter(object sender, EventArgs e)
        {
            if (int.Parse(txtbayar.Text) < total)
            {
                MessageBox.Show("Pembayaran lebih kecil dari Total");
                txtbayar.Focus();
                bayar = 0;
                kembali = 0;
            }
            else
            {
                bayar = int.Parse(txtbayar.Text);
                kembali = bayar - total;
            }

            txtbayar.Text = bayar.ToString();
            txtkembali.Text = kembali.ToString();
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            string no_kwitansi = new_no_kwitansi();
            DateTime sekarang=  DateTime.Now;            
            string tgl = sekarang.ToString("dd/MMMM/yyyy");
            string waktu = sekarang.ToString("hh:mm:ss");
            int subtotal = int.Parse(txtstotal.Text);
            int nilaipajak = int.Parse(txtpajak.Text);
            int total = int.Parse(txttotal.Text);
            int bayar = int.Parse(txtbayar.Text);
            string kodemember = kode_member.Text;
            
            string queryInsertUser = "INSERT INTO tb_transaksi([no_kwitansi],[id_user],[kode_member],[tanggal],[waktu],[subtotal],[nilai_pajak],[total],[bayar])  VALUES('" + no_kwitansi + "','12123','" + kodemember + "','"+tgl+"','"+waktu+"',"+subtotal+","+nilaipajak+","+total+","+bayar+")";
            OleDbCommand SQLInsert = new OleDbCommand(queryInsertUser, database);
            int result = SQLInsert.ExecuteNonQuery();
            if (result == 1)
            {
                MessageBox.Show("Pesanan disimpan. Masukkan Pemesanan Baru.");
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                txtstotal.Clear();
                txtpajak.Clear();
                txttotal.Clear();
                txtbayar.Clear();
                kode_member.Clear();
                tambah.Focus();
            }
            else
            {
                MessageBox.Show("Penyimpanan Gagal.");
            }
        }

        public string new_no_kwitansi()
        {
            string last_kwitansi;
            string new_kwitansi = "";
            string year = DateTime.Now.Year.ToString();
            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data2 = new DataTable();
            SQLQuery.CommandText = "SELECT no_kwitansi FROM tb_transaksi order by id_transaksi desc ";
            SQLQuery.Connection = database;
            OleDbDataAdapter dataAdapter2 = new OleDbDataAdapter(SQLQuery);
            dataAdapter2.Fill(data2);

            if (data2.Rows.Count > 0)
            {
                last_kwitansi = data2.Rows[0]["no_kwitansi"].ToString();
                string last_year = last_kwitansi.Substring(0,4);
                string last_number = last_kwitansi.Substring(5);
                if (int.Parse(last_year) < int.Parse(year))
                {
                    new_kwitansi = year + "|" + 0;
                }
                else if (int.Parse(last_year) == int.Parse(year))
                {
                    new_kwitansi = year + "|" + (int.Parse(last_number) + 1);
                }
                else
                {
                    new_kwitansi = year + "|" + 0;
                }
            }
            else
            {
                new_kwitansi = year + "|" + 0;
            }

            return new_kwitansi;
        }

        private void selectmenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void lbltanggal_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            waktu.Text = DateTime.Now.ToString("hh:mm:ss");
            waktu.Font = new Font("DS-Digital", 10, FontStyle.Bold);
        }

    }
}
