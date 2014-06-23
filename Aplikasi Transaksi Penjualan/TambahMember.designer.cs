namespace Aplikasi_Transaksi_Penjualan
{
    partial class TambahMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.alamat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tglDaftar = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.kode_member = new System.Windows.Forms.TextBox();
            this.noKTP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(136, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulir Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(21, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(21, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Daftar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(21, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(22, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "NO KTP";
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(174, 115);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(140, 20);
            this.nama.TabIndex = 2;
            this.nama.TextChanged += new System.EventHandler(this.nama_TextChanged);
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(174, 199);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(140, 20);
            this.alamat.TabIndex = 3;
            this.alamat.TextChanged += new System.EventHandler(this.alamat_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tglDaftar
            // 
            this.tglDaftar.Location = new System.Drawing.Point(174, 158);
            this.tglDaftar.Name = "tglDaftar";
            this.tglDaftar.Size = new System.Drawing.Size(200, 20);
            this.tglDaftar.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(22, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kode Member";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // kode_member
            // 
            this.kode_member.Location = new System.Drawing.Point(174, 73);
            this.kode_member.Name = "kode_member";
            this.kode_member.Size = new System.Drawing.Size(140, 20);
            this.kode_member.TabIndex = 1;
            // 
            // noKTP
            // 
            this.noKTP.Location = new System.Drawing.Point(174, 246);
            this.noKTP.Name = "noKTP";
            this.noKTP.Size = new System.Drawing.Size(140, 20);
            this.noKTP.TabIndex = 4;
            // 
            // TambahMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(414, 370);
            this.Controls.Add(this.noKTP);
            this.Controls.Add(this.kode_member);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tglDaftar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TambahMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Member";
            this.Load += new System.EventHandler(this.TambahMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker tglDaftar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kode_member;
        private System.Windows.Forms.TextBox noKTP;
    }
}