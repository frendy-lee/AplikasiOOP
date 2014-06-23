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
    public partial class index : Form
    {
        public OleDbConnection database;

        public index()
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

        private void index_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_Makanan mm = new Menu_Makanan();
            mm.Show();
            //FrTransaksi tran = new FrTransaksi();
            //tran.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLaporan laporan = new frmLaporan();
            laporan.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //registUser reg = new registUser();
            //reg.Show();
            Member member = new Member();
            member.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrHistory his = new FrHistory();
            his.Show();
        }
    }
}
