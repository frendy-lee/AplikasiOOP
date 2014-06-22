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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tambah_Makanan tm = new Tambah_Makanan();
            tm.Show();
            Close();
        }
        public void show()
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
            for (int i = 0; i < option.Length; i++)
            {

            }
        }

    }
}
