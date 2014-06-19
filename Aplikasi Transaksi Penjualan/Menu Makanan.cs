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
    public partial class Menu_Makanan : Form
    {
        Tambah_Makanan tm = new Tambah_Makanan();
        public Menu_Makanan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tm.Show();
        }
    }
}
