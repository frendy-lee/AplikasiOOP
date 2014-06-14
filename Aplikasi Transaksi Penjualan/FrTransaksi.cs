using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Transaksi_Penjualan
{
    public partial class FrTransaksi : Form
    {
        public FrTransaksi()
        {
            InitializeComponent();
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

            string[] arr1 = new String[] { "a", "b", "c" }; 
            string[] arr2 = new String[] { "d", "e", "f" }; 
            DataTable dt = new DataTable(); 
            dt.Columns.Add("Column1"); 
            dt.Columns.Add("Column2");

            for (int i = 0; i < arr1.Length; i++)
            {
                DataRow row = dt.NewRow(); row[0] = arr1[i]; row[1] = arr2[i]; dt.Rows.Add(row);
            }
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

        public void loadDataGrid()
        {
        }
    }
}
