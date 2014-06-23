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
    public partial class FrmLogin : Form
    {
        string nm, pas;
        public string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=../../Dbase/TP.mdb;Persist Security Info=False;";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            if (txtPassword.Text == "")
                txtPassword.Text = "Password";
            lblarrow.Location = new Point(119, 284);
        }
        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            if (txtUsername.Text == "")
                txtUsername.Text = "USERNAME";
            lblarrow.Location = new Point(119, 333);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            timer1.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                OleDbDataReader rdr = null;
                {
                    string sql = string.Format("select * from tb_user where username = '{0}' and password = '{1}'", txtUsername.Text, txtPassword.Text);
                    OleDbConnection conn = new OleDbConnection(connectionString);
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        nm = rdr[1].ToString();
                        pas = rdr[3].ToString();
                        MessageBox.Show("UserName dan Password Sudah Benar....", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        if (nm == "tiasore" && pas == "tiasore2012")
                        {
                            FrTransaksi tran = new FrTransaksi();
                            tran.Show();
                            this.Hide();
                        }
                        else if (nm == "admin" && pas == "adminserver")
                        {
                            index index = new index();
                            index.Show();
                            this.Hide();
                        }
                        
                    }
                    else
                    {
                        txtUsername.Text = "";
                        txtUsername.Focus();
                        txtPassword.Text = "";
                        MessageBox.Show("Username atau Password Salah........ !", "Informasi" , MessageBoxButtons.OK, MessageBoxIcon.Information , MessageBoxDefaultButton.Button1);
                        lblarrow.Location = new Point(119, 284);
                    }

                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Maaf, Lengkapi Username dan Password terlebih dahulu..!!!", "Informasi" , MessageBoxButtons.OK, MessageBoxIcon.Information , MessageBoxDefaultButton.Button1);
                lblarrow.Location = new Point(119, 284);
            } 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblarrow.Visible == true)
                lblarrow.Visible = false;
            else
                lblarrow.Visible = true;
        }

        
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblarrow.Location = new Point(119, 333);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblarrow.Location = new Point(119, 284);
        }

    }
}
