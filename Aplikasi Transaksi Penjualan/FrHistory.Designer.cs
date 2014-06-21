namespace Aplikasi_Transaksi_Penjualan
{
    partial class FrHistory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tambah = new System.Windows.Forms.Button();
            this.lblkgtn = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.selectmenu = new System.Windows.Forms.ComboBox();
            this.lblusrid = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblsd = new System.Windows.Forms.Label();
            this.lbltanggal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tambah);
            this.groupBox1.Controls.Add(this.lblkgtn);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.selectmenu);
            this.groupBox1.Controls.Add(this.lblusrid);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblsd);
            this.groupBox1.Controls.Add(this.lbltanggal);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari";
            // 
            // tambah
            // 
            this.tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tambah.FlatAppearance.BorderSize = 0;
            this.tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambah.Location = new System.Drawing.Point(230, 98);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(273, 32);
            this.tambah.TabIndex = 5;
            this.tambah.Text = "Lihat History";
            this.tambah.UseVisualStyleBackColor = false;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // lblkgtn
            // 
            this.lblkgtn.AutoSize = true;
            this.lblkgtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkgtn.Location = new System.Drawing.Point(29, 64);
            this.lblkgtn.Name = "lblkgtn";
            this.lblkgtn.Size = new System.Drawing.Size(58, 20);
            this.lblkgtn.TabIndex = 13;
            this.lblkgtn.Text = "Kegiatan";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(446, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 4;
            // 
            // selectmenu
            // 
            this.selectmenu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.selectmenu.FormattingEnabled = true;
            this.selectmenu.Location = new System.Drawing.Point(111, 62);
            this.selectmenu.Name = "selectmenu";
            this.selectmenu.Size = new System.Drawing.Size(200, 21);
            this.selectmenu.TabIndex = 3;
            // 
            // lblusrid
            // 
            this.lblusrid.AutoSize = true;
            this.lblusrid.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusrid.Location = new System.Drawing.Point(360, 62);
            this.lblusrid.Name = "lblusrid";
            this.lblusrid.Size = new System.Drawing.Size(50, 20);
            this.lblusrid.TabIndex = 5;
            this.lblusrid.Text = "User ID";
            this.lblusrid.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(446, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lblsd
            // 
            this.lblsd.AutoSize = true;
            this.lblsd.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsd.Location = new System.Drawing.Point(360, 27);
            this.lblsd.Name = "lblsd";
            this.lblsd.Size = new System.Drawing.Size(28, 20);
            this.lblsd.TabIndex = 2;
            this.lblsd.Text = "s.d.";
            // 
            // lbltanggal
            // 
            this.lbltanggal.AutoSize = true;
            this.lbltanggal.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltanggal.Location = new System.Drawing.Point(29, 26);
            this.lbltanggal.Name = "lbltanggal";
            this.lbltanggal.Size = new System.Drawing.Size(56, 20);
            this.lbltanggal.TabIndex = 1;
            this.lbltanggal.Text = "Tanggal";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(24, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 439);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History";
            // 
            // FrHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(750, 750);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrHistory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbltanggal;
        private System.Windows.Forms.Label lblsd;
        private System.Windows.Forms.Label lblusrid;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox selectmenu;
        private System.Windows.Forms.Label lblkgtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}