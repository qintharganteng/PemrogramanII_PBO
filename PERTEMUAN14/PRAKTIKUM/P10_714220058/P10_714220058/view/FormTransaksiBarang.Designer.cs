namespace P10_714220058.view
{
    partial class FormTransaksiBarang
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
            this.harga = new System.Windows.Forms.TextBox();
            this.id_barang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nama_barang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataTransaksi = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(141, 124);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(406, 26);
            this.harga.TabIndex = 13;
            this.harga.TextChanged += new System.EventHandler(this.harga_TextChanged);
            // 
            // id_barang
            // 
            this.id_barang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_barang.FormattingEnabled = true;
            this.id_barang.Items.AddRange(new object[] {
            "Pemrograman I",
            "Pemrograman II",
            "Pemrograman II",
            "Pemrograman IV",
            "Literasi Data",
            "Sistem ERP",
            "RPL",
            "Metodologi Penelitian",
            "PKN",
            "General English I"});
            this.id_barang.Location = new System.Drawing.Point(141, 26);
            this.id_barang.Name = "id_barang";
            this.id_barang.Size = new System.Drawing.Size(406, 28);
            this.id_barang.TabIndex = 11;
            this.id_barang.SelectedIndexChanged += new System.EventHandler(this.id_barang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.harga);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.id_barang);
            this.groupBox2.Controls.Add(this.nama_barang);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(50, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 183);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Data Mahasiswa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rp";
            // 
            // nama_barang
            // 
            this.nama_barang.Location = new System.Drawing.Point(141, 65);
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.Size = new System.Drawing.Size(406, 26);
            this.nama_barang.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga Barang";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Barang";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnhapus);
            this.groupBox3.Controls.Add(this.btnubah);
            this.groupBox3.Controls.Add(this.btnsimpan);
            this.groupBox3.Controls.Add(this.btnrefresh);
            this.groupBox3.Location = new System.Drawing.Point(758, 489);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 220);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(161, 187);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 30);
            this.btnhapus.TabIndex = 3;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnubah
            // 
            this.btnubah.Location = new System.Drawing.Point(161, 140);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(75, 29);
            this.btnubah.TabIndex = 2;
            this.btnubah.Text = "Ubah";
            this.btnubah.UseVisualStyleBackColor = true;
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(161, 91);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(75, 31);
            this.btnsimpan.TabIndex = 1;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(161, 42);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 33);
            this.btnrefresh.TabIndex = 0;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(90, 26);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(287, 26);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbCariData);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(758, 405);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(383, 78);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pencarian";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataTransaksi);
            this.groupBox1.Location = new System.Drawing.Point(50, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 382);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Transaksi Barang";
            // 
            // DataTransaksi
            // 
            this.DataTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTransaksi.Location = new System.Drawing.Point(1, 25);
            this.DataTransaksi.Name = "DataTransaksi";
            this.DataTransaksi.RowHeadersWidth = 62;
            this.DataTransaksi.RowTemplate.Height = 28;
            this.DataTransaksi.Size = new System.Drawing.Size(1084, 351);
            this.DataTransaksi.TabIndex = 0;
            this.DataTransaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTransaksi_CellContentClick);
            this.DataTransaksi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataTransaksi_CellFormatting_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 591);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 629);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 626);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Rp";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(191, 626);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(406, 26);
            this.total.TabIndex = 14;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(191, 588);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(406, 26);
            this.qty.TabIndex = 15;
            this.qty.TextChanged += new System.EventHandler(this.qty_TextChanged);
            // 
            // FormTransaksiBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::P10_714220058.Properties.Resources.john_towner_JgOeRuGD_Y4_unsplash;
            this.ClientSize = new System.Drawing.Size(1191, 713);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTransaksiBarang";
            this.Text = "FormTransaksiBarang";
            this.Load += new System.EventHandler(this.FormTransaksiBarang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.ComboBox id_barang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nama_barang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataTransaksi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox qty;
    }
}