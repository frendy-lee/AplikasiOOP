namespace Aplikasi_Transaksi_Penjualan
{
    partial class frmLaporan
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
            this.components = new System.ComponentModel.Container();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnBulanan = new System.Windows.Forms.Button();
            this.btnTahunan = new System.Windows.Forms.Button();
            this.btnHarian = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkOrange;
            this.button5.BackgroundImage = global::Aplikasi_Transaksi_Penjualan.Properties.Resources.Untitled;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button5.Location = new System.Drawing.Point(625, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "  Keluar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOrange;
            this.button4.BackgroundImage = global::Aplikasi_Transaksi_Penjualan.Properties.Resources.Backward_icon2;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(519, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 12;
            this.button4.Text = "   Kembali";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(304, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 21);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btnBulanan
            // 
            this.btnBulanan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBulanan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBulanan.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnBulanan.FlatAppearance.BorderSize = 2;
            this.btnBulanan.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btnBulanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBulanan.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBulanan.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnBulanan.Location = new System.Drawing.Point(434, 236);
            this.btnBulanan.Name = "btnBulanan";
            this.btnBulanan.Size = new System.Drawing.Size(145, 48);
            this.btnBulanan.TabIndex = 18;
            this.btnBulanan.Text = "Bulanan";
            this.btnBulanan.UseVisualStyleBackColor = false;
            this.btnBulanan.Click += new System.EventHandler(this.btnBulanan_Click);
            // 
            // btnTahunan
            // 
            this.btnTahunan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTahunan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTahunan.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnTahunan.FlatAppearance.BorderSize = 2;
            this.btnTahunan.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btnTahunan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTahunan.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTahunan.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnTahunan.Location = new System.Drawing.Point(258, 335);
            this.btnTahunan.Name = "btnTahunan";
            this.btnTahunan.Size = new System.Drawing.Size(145, 49);
            this.btnTahunan.TabIndex = 17;
            this.btnTahunan.Text = "Tahunan";
            this.btnTahunan.UseVisualStyleBackColor = false;
            this.btnTahunan.Click += new System.EventHandler(this.btnTahunan_Click);
            // 
            // btnHarian
            // 
            this.btnHarian.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHarian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHarian.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnHarian.FlatAppearance.BorderSize = 2;
            this.btnHarian.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btnHarian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHarian.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHarian.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnHarian.Location = new System.Drawing.Point(82, 236);
            this.btnHarian.Name = "btnHarian";
            this.btnHarian.Size = new System.Drawing.Size(145, 48);
            this.btnHarian.TabIndex = 16;
            this.btnHarian.Text = "Harian";
            this.btnHarian.UseVisualStyleBackColor = false;
            this.btnHarian.Click += new System.EventHandler(this.btnHarian_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(234, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(504, 134);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.Visible = false;
            // 
            // frmLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(750, 750);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBulanan);
            this.Controls.Add(this.btnTahunan);
            this.Controls.Add(this.btnHarian);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLaporan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btnBulanan;
        private System.Windows.Forms.Button btnTahunan;
        private System.Windows.Forms.Button btnHarian;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}