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
using System.Security.Cryptography;

namespace Aplikasi_Transaksi_Penjualan
{
    public partial class TambahMember : Form
    {
        OleDbConnection database7;

        
        List<string> member;
        public string kodeMember { set; get; }
        public string namaMember { set; get; }
        public DateTime tglDaftarMember { set; get; }
        public string alamatMember { set; get; }
        public string noKTPMember{ set; get; }
        public TambahMember()
        {
            InitializeComponent();
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=../../Dbase/TP.mdb";
            try
            {
                database7 = new OleDbConnection(connectionString);
                database7.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
        public bool saveMember(string kodeMember, string namaMember,DateTime tglDaftarMember,string noKTPMember, string alamatMember )
        {
            string queryInsertUser = "INSERT INTO tb_member([kode_member],[nama_member],[tanggal_daftar],[no_ktp],[alamat]) VALUES('" + kodeMember + "','" + namaMember + "','" + tglDaftarMember+ "','" + noKTPMember + "','" + alamatMember+ "')";
            OleDbCommand SQLInsert = new OleDbCommand(queryInsertUser, database7);
            int result = SQLInsert.ExecuteNonQuery();
            MessageBox.Show(result.ToString());
            if (result == 1)
                return true;
            else
                return false;
        }
        private void nama_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void alamat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nama.Text != null && tglDaftar.Text!=null && alamat.Text != null && kode_member.Text!=null && noKTP.Text!=null)
            {
                member = new List<string>();
                namaMember = nama.Text;
                tglDaftarMember = tglDaftar.Value;
                alamatMember = alamat.Text;
                kodeMember = kode_member.Text;
                noKTPMember = noKTP.Text;
                saveMember(kodeMember, namaMember, tglDaftarMember,noKTPMember,alamatMember);
           
               
            }
            Member memberform = new Member();
            memberform.Show();
            Close();
        }

        private void TambahMember_Load(object sender, EventArgs e)
        {
            kode_member.Focus();
        }

        private void lk_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void pr_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

    }
}
