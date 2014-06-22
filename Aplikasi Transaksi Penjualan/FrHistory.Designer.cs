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
            this.components = new System.ComponentModel.Container();
            this.labeldate = new System.Windows.Forms.Label();
            this.labeltime = new System.Windows.Forms.Label();
            this.groupBoxcari = new System.Windows.Forms.GroupBox();
            this.buttonhistory = new System.Windows.Forms.Button();
            this.labelkegiatan = new System.Windows.Forms.Label();
            this.textBoxuserid = new System.Windows.Forms.TextBox();
            this.labeluserid = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.selectkegiatan = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelsd = new System.Windows.Forms.Label();
            this.labeltanggal = new System.Windows.Forms.Label();
            this.groupBoxhistory = new System.Windows.Forms.GroupBox();
            this.datagridhistory = new System.Windows.Forms.DataGridView();
            this.buttonkembali = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kegiatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxcari.SuspendLayout();
            this.groupBoxhistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridhistory)).BeginInit();
            this.SuspendLayout();
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldate.Location = new System.Drawing.Point(31, 25);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(62, 20);
            this.labeldate.TabIndex = 1;
            this.labeldate.Text = "Tanggal :";
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltime.Location = new System.Drawing.Point(552, 25);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(49, 20);
            this.labeltime.TabIndex = 2;
            this.labeltime.Text = "Waktu :";
            // 
            // groupBoxcari
            // 
            this.groupBoxcari.Controls.Add(this.buttonhistory);
            this.groupBoxcari.Controls.Add(this.labelkegiatan);
            this.groupBoxcari.Controls.Add(this.textBoxuserid);
            this.groupBoxcari.Controls.Add(this.labeluserid);
            this.groupBoxcari.Controls.Add(this.dateTimePicker2);
            this.groupBoxcari.Controls.Add(this.selectkegiatan);
            this.groupBoxcari.Controls.Add(this.dateTimePicker1);
            this.groupBoxcari.Controls.Add(this.labelsd);
            this.groupBoxcari.Controls.Add(this.labeltanggal);
            this.groupBoxcari.Location = new System.Drawing.Point(35, 70);
            this.groupBoxcari.Name = "groupBoxcari";
            this.groupBoxcari.Size = new System.Drawing.Size(678, 148);
            this.groupBoxcari.TabIndex = 0;
            this.groupBoxcari.TabStop = false;
            this.groupBoxcari.Text = "Cari";
            // 
            // buttonhistory
            // 
            this.buttonhistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(172)))), ((int)(((byte)(194)))));
            this.buttonhistory.FlatAppearance.BorderSize = 0;
            this.buttonhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhistory.Location = new System.Drawing.Point(230, 98);
            this.buttonhistory.Name = "buttonhistory";
            this.buttonhistory.Size = new System.Drawing.Size(273, 32);
            this.buttonhistory.TabIndex = 5;
            this.buttonhistory.Text = "Lihat History";
            this.buttonhistory.UseVisualStyleBackColor = false;
            this.buttonhistory.Click += new System.EventHandler(this.buttonhistory_Click);
            // 
            // labelkegiatan
            // 
            this.labelkegiatan.AutoSize = true;
            this.labelkegiatan.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkegiatan.Location = new System.Drawing.Point(360, 27);
            this.labelkegiatan.Name = "labelkegiatan";
            this.labelkegiatan.Size = new System.Drawing.Size(58, 20);
            this.labelkegiatan.TabIndex = 4;
            this.labelkegiatan.Text = "Kegiatan";
            // 
            // textBoxuserid
            // 
            this.textBoxuserid.Location = new System.Drawing.Point(111, 27);
            this.textBoxuserid.Name = "textBoxuserid";
            this.textBoxuserid.Size = new System.Drawing.Size(200, 20);
            this.textBoxuserid.TabIndex = 1;
            // 
            // labeluserid
            // 
            this.labeluserid.AutoSize = true;
            this.labeluserid.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluserid.Location = new System.Drawing.Point(29, 27);
            this.labeluserid.Name = "labeluserid";
            this.labeluserid.Size = new System.Drawing.Size(50, 20);
            this.labeluserid.TabIndex = 3;
            this.labeluserid.Text = "User ID";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(447, 64);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // selectkegiatan
            // 
            this.selectkegiatan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.selectkegiatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectkegiatan.FormattingEnabled = true;
            this.selectkegiatan.Location = new System.Drawing.Point(447, 27);
            this.selectkegiatan.Name = "selectkegiatan";
            this.selectkegiatan.Size = new System.Drawing.Size(200, 21);
            this.selectkegiatan.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // labelsd
            // 
            this.labelsd.AutoSize = true;
            this.labelsd.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsd.Location = new System.Drawing.Point(360, 64);
            this.labelsd.Name = "labelsd";
            this.labelsd.Size = new System.Drawing.Size(28, 20);
            this.labelsd.TabIndex = 6;
            this.labelsd.Text = "s.d.";
            // 
            // labeltanggal
            // 
            this.labeltanggal.AutoSize = true;
            this.labeltanggal.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltanggal.Location = new System.Drawing.Point(29, 64);
            this.labeltanggal.Name = "labeltanggal";
            this.labeltanggal.Size = new System.Drawing.Size(56, 20);
            this.labeltanggal.TabIndex = 5;
            this.labeltanggal.Text = "Tanggal";
            // 
            // groupBoxhistory
            // 
            this.groupBoxhistory.Controls.Add(this.datagridhistory);
            this.groupBoxhistory.Controls.Add(this.buttonkembali);
            this.groupBoxhistory.Location = new System.Drawing.Point(35, 242);
            this.groupBoxhistory.Name = "groupBoxhistory";
            this.groupBoxhistory.Size = new System.Drawing.Size(678, 481);
            this.groupBoxhistory.TabIndex = 1;
            this.groupBoxhistory.TabStop = false;
            this.groupBoxhistory.Text = "History";
            // 
            // datagridhistory
            // 
            this.datagridhistory.AllowUserToAddRows = false;
            this.datagridhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridhistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tanggal,
            this.userID,
            this.kegiatan});
            this.datagridhistory.Location = new System.Drawing.Point(33, 40);
            this.datagridhistory.Name = "datagridhistory";
            this.datagridhistory.Size = new System.Drawing.Size(613, 374);
            this.datagridhistory.TabIndex = 15;
            this.datagridhistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridhistory_CellContentClick);
            // 
            // buttonkembali
            // 
            this.buttonkembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(172)))), ((int)(((byte)(194)))));
            this.buttonkembali.FlatAppearance.BorderSize = 0;
            this.buttonkembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonkembali.Location = new System.Drawing.Point(230, 436);
            this.buttonkembali.Name = "buttonkembali";
            this.buttonkembali.Size = new System.Drawing.Size(273, 32);
            this.buttonkembali.TabIndex = 14;
            this.buttonkembali.Text = "Kembali";
            this.buttonkembali.UseVisualStyleBackColor = false;
            this.buttonkembali.Click += new System.EventHandler(this.buttonkembali_Click);
            // 
            // tanggal
            // 
            this.tanggal.HeaderText = "Tanggal";
            this.tanggal.Name = "tanggal";
            // 
            // userID
            // 
            this.userID.HeaderText = "User ID";
            this.userID.Name = "userID";
            // 
            // kegiatan
            // 
            this.kegiatan.HeaderText = "Kegiatan";
            this.kegiatan.Name = "kegiatan";
            // 
            // FrHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(750, 750);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.groupBoxhistory);
            this.Controls.Add(this.groupBoxcari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrHistory";
            this.Load += new System.EventHandler(this.FrHistory_Load);
            this.groupBoxcari.ResumeLayout(false);
            this.groupBoxcari.PerformLayout();
            this.groupBoxhistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridhistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxcari;
        private System.Windows.Forms.GroupBox groupBoxhistory;
        private System.Windows.Forms.Label labeltanggal;
        private System.Windows.Forms.Label labelsd;
        private System.Windows.Forms.Label labelkegiatan;
        private System.Windows.Forms.Label labeluserid;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox selectkegiatan;
        private System.Windows.Forms.TextBox textBoxuserid;
        private System.Windows.Forms.Button buttonhistory;
        private System.Windows.Forms.Button buttonkembali;
        private System.Windows.Forms.DataGridView datagridhistory;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn kegiatan;
    }
}