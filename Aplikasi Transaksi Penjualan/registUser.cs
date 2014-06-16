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
    public partial class registUser : Form
    {
        OleDbConnection database;

        public registUser()
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

        private void add_Click(object sender, EventArgs e)
        {
            string usrname = username.Text;
            string lgnname = loginname.Text;
            string pass = MD5Hash(password.Text);

            if (saveUser(usrname, lgnname, pass))
            {
                username.Text = "";
                loginname.Text = "";
                password.Text = "";
                username.Focus();
            }
        }

        public bool saveUser(string username, string loginname, string password)
        {
            string queryInsertUser = "INSERT INTO tb_user([username],[loginname],[password]) VALUES('"+username+"','"+loginname+"','"+password+"')";
            OleDbCommand SQLInsert = new OleDbCommand(queryInsertUser,database);
            int result = SQLInsert.ExecuteNonQuery();
            MessageBox.Show(result.ToString());
            if (result == 1)            
                return true;            
            else
                return false;            
        }

        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        private void registUser_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
