namespace P10_714220058.view
{
    partial class FormBarang
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
            this.Databarang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.harga = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nama_barang = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.caridata = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Databarang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Databarang
            // 
            this.Databarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Databarang.Location = new System.Drawing.Point(1, 25);
            this.Databarang.Name = "Databarang";
            this.Databarang.RowHeadersWidth = 62;
            this.Databarang.RowTemplate.Height = 28;
            this.Databarang.Size = new System.Drawing.Size(1084, 351);
            this.Databarang.TabIndex = 0;
            this.Databarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNilai_CellContentClick);
            this.Databarang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Databarang_CellFormatting_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Harga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Barang";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnhapus);
            this.groupBox3.Controls.Add(this.btnubah);
            this.groupBox3.Controls.Add(this.btnsimpan);
            this.groupBox3.Controls.Add(this.btnrefresh);
            this.groupBox3.Location = new System.Drawing.Point(758, 425);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 230);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Databarang);
            this.groupBox1.Location = new System.Drawing.Point(50, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 382);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Barang";
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(174, 65);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(406, 26);
            this.harga.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nama_barang);
            this.groupBox2.Controls.Add(this.harga);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(50, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 111);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Barang";
            // 
            // nama_barang
            // 
            this.nama_barang.Location = new System.Drawing.Point(174, 31);
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.Size = new System.Drawing.Size(406, 26);
            this.nama_barang.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.caridata);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(51, 533);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(580, 80);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Form Pencarian";
            // 
            // caridata
            // 
            this.caridata.Location = new System.Drawing.Point(174, 31);
            this.caridata.Name = "caridata";
            this.caridata.Size = new System.Drawing.Size(406, 26);
            this.caridata.TabIndex = 10;
            this.caridata.TextChanged += new System.EventHandler(this.caridata_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cari Data";
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::P10_714220058.Properties.Resources.pexels_steve_johnson_1572386;
            this.ClientSize = new System.Drawing.Size(1191, 716);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormBarang";
            this.Text = "FormBarang";
            this.Load += new System.EventHandler(this.FormBarang_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Databarang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Databarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox nama_barang;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox caridata;
        private System.Windows.Forms.Label label4;
    }
}