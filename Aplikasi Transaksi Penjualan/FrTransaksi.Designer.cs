namespace Aplikasi_Transaksi_Penjualan
{
    partial class FrTransaksi
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
            this.lbltanggal = new System.Windows.Forms.Label();
            this.tanggal = new System.Windows.Forms.Label();
            this.waktu = new System.Windows.Forms.Label();
            this.lblwaktu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblidkasir = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kode_member = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tambah = new System.Windows.Forms.Button();
            this.selectmenu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jumlahUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtstotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpajak = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbayar = new System.Windows.Forms.TextBox();
            this.txtkembali = new System.Windows.Forms.TextBox();
            this.Simpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltanggal
            // 
            this.lbltanggal.AutoSize = true;
            this.lbltanggal.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltanggal.Location = new System.Drawing.Point(13, 13);
            this.lbltanggal.Name = "lbltanggal";
            this.lbltanggal.Size = new System.Drawing.Size(56, 20);
            this.lbltanggal.TabIndex = 0;
            this.lbltanggal.Text = "Tanggal";
            this.lbltanggal.Click += new System.EventHandler(this.label1_Click);
            // 
            // tanggal
            // 
            this.tanggal.AutoSize = true;
            this.tanggal.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal.Location = new System.Drawing.Point(70, 13);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(0, 20);
            this.tanggal.TabIndex = 1;
            // 
            // waktu
            // 
            this.waktu.AutoSize = true;
            this.waktu.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waktu.Location = new System.Drawing.Point(639, 13);
            this.waktu.Name = "waktu";
            this.waktu.Size = new System.Drawing.Size(0, 20);
            this.waktu.TabIndex = 3;
            this.waktu.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblwaktu
            // 
            this.lblwaktu.AutoSize = true;
            this.lblwaktu.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwaktu.Location = new System.Drawing.Point(590, 13);
            this.lblwaktu.Name = "lblwaktu";
            this.lblwaktu.Size = new System.Drawing.Size(43, 20);
            this.lblwaktu.TabIndex = 2;
            this.lblwaktu.Text = "Waktu";
            this.lblwaktu.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kasir :";
            // 
            // lblidkasir
            // 
            this.lblidkasir.AutoSize = true;
            this.lblidkasir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidkasir.Location = new System.Drawing.Point(70, 50);
            this.lblidkasir.Name = "lblidkasir";
            this.lblidkasir.Size = new System.Drawing.Size(0, 20);
            this.lblidkasir.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Member ID";
            // 
            // kode_member
            // 
            this.kode_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kode_member.Location = new System.Drawing.Point(594, 50);
            this.kode_member.Name = "kode_member";
            this.kode_member.Size = new System.Drawing.Size(123, 24);
            this.kode_member.TabIndex = 7;
            this.kode_member.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode,
            this.nama,
            this.harga,
            this.jumlah,
            this.stotal,
            this.delete});
            this.dataGridView1.Location = new System.Drawing.Point(18, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(699, 378);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kode
            // 
            this.kode.HeaderText = "Kode Menu";
            this.kode.Name = "kode";
            this.kode.ReadOnly = true;
            // 
            // nama
            // 
            this.nama.HeaderText = "Nama";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            this.nama.Width = 200;
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga";
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            // 
            // jumlah
            // 
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.Name = "jumlah";
            this.jumlah.ReadOnly = true;
            // 
            // stotal
            // 
            this.stotal.HeaderText = "Sub total";
            this.stotal.Name = "stotal";
            this.stotal.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 50;
            // 
            // tambah
            // 
            this.tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tambah.FlatAppearance.BorderSize = 0;
            this.tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambah.Location = new System.Drawing.Point(444, 91);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(273, 32);
            this.tambah.TabIndex = 9;
            this.tambah.Text = "&Tambah";
            this.tambah.UseVisualStyleBackColor = false;
            this.tambah.Click += new System.EventHandler(this.buka_Click);
            // 
            // selectmenu
            // 
            this.selectmenu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.selectmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectmenu.FormattingEnabled = true;
            this.selectmenu.Location = new System.Drawing.Point(138, 96);
            this.selectmenu.Name = "selectmenu";
            this.selectmenu.Size = new System.Drawing.Size(121, 21);
            this.selectmenu.TabIndex = 10;
            this.selectmenu.SelectedIndexChanged += new System.EventHandler(this.selectmenu_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Jumlah";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pilih Menu";
            // 
            // jumlahUpDown
            // 
            this.jumlahUpDown.Location = new System.Drawing.Point(358, 96);
            this.jumlahUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.jumlahUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jumlahUpDown.Name = "jumlahUpDown";
            this.jumlahUpDown.Size = new System.Drawing.Size(47, 20);
            this.jumlahUpDown.TabIndex = 14;
            this.jumlahUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(521, 584);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total";
            // 
            // txtstotal
            // 
            this.txtstotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstotal.Location = new System.Drawing.Point(575, 524);
            this.txtstotal.Name = "txtstotal";
            this.txtstotal.ReadOnly = true;
            this.txtstotal.Size = new System.Drawing.Size(142, 24);
            this.txtstotal.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(519, 613);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Bayar";
            // 
            // txtpajak
            // 
            this.txtpajak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpajak.Location = new System.Drawing.Point(575, 554);
            this.txtpajak.Name = "txtpajak";
            this.txtpajak.ReadOnly = true;
            this.txtpajak.Size = new System.Drawing.Size(142, 24);
            this.txtpajak.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(504, 647);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Kembali";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(575, 584);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(142, 24);
            this.txttotal.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(499, 524);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "SubTotal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(491, 554);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Pajak 10%";
            // 
            // txtbayar
            // 
            this.txtbayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbayar.Location = new System.Drawing.Point(575, 614);
            this.txtbayar.Name = "txtbayar";
            this.txtbayar.Size = new System.Drawing.Size(142, 24);
            this.txtbayar.TabIndex = 23;
            this.txtbayar.TabIndexChanged += new System.EventHandler(this.txtbayar_Enter);
            // 
            // txtkembali
            // 
            this.txtkembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkembali.Location = new System.Drawing.Point(575, 647);
            this.txtkembali.Name = "txtkembali";
            this.txtkembali.ReadOnly = true;
            this.txtkembali.Size = new System.Drawing.Size(142, 24);
            this.txtkembali.TabIndex = 24;
            this.txtkembali.Enter += new System.EventHandler(this.txtbayar_Enter);
            // 
            // Simpan
            // 
            this.Simpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Simpan.FlatAppearance.BorderSize = 0;
            this.Simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Simpan.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Simpan.Location = new System.Drawing.Point(18, 690);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(699, 48);
            this.Simpan.TabIndex = 25;
            this.Simpan.Text = "&SIMPAN";
            this.Simpan.UseVisualStyleBackColor = false;
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // FrTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(750, 750);
            this.Controls.Add(this.Simpan);
            this.Controls.Add(this.txtkembali);
            this.Controls.Add(this.txtbayar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtpajak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtstotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.jumlahUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectmenu);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kode_member);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblidkasir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waktu);
            this.Controls.Add(this.lblwaktu);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.lbltanggal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrTransaksi";
            this.Load += new System.EventHandler(this.FrTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltanggal;
        private System.Windows.Forms.Label tanggal;
        private System.Windows.Forms.Label waktu;
        private System.Windows.Forms.Label lblwaktu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblidkasir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kode_member;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.ComboBox selectmenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown jumlahUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn stotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtstotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpajak;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbayar;
        private System.Windows.Forms.TextBox txtkembali;
        private System.Windows.Forms.Button Simpan;
    }
}