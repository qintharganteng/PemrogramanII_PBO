namespace P10_714220058
{
    partial class Form1
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
            this.DataMahasiswa = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nohp = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.alamat = new System.Windows.Forms.TextBox();
            this.angkatan = new System.Windows.Forms.ComboBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.npm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataMahasiswa);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Data Mahasiswa";
            // 
            // DataMahasiswa
            // 
            this.DataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMahasiswa.Location = new System.Drawing.Point(1, 25);
            this.DataMahasiswa.Name = "DataMahasiswa";
            this.DataMahasiswa.RowHeadersWidth = 62;
            this.DataMahasiswa.RowTemplate.Height = 28;
            this.DataMahasiswa.Size = new System.Drawing.Size(1084, 351);
            this.DataMahasiswa.TabIndex = 0;
            this.DataMahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMahasiswa_CellClick);
            this.DataMahasiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMahasiswa_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nohp);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.alamat);
            this.groupBox2.Controls.Add(this.angkatan);
            this.groupBox2.Controls.Add(this.nama);
            this.groupBox2.Controls.Add(this.npm);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(1, 391);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 367);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Data Mahasiswa";
            // 
            // nohp
            // 
            this.nohp.Location = new System.Drawing.Point(130, 316);
            this.nohp.Name = "nohp";
            this.nohp.Size = new System.Drawing.Size(417, 26);
            this.nohp.TabIndex = 11;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(130, 262);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(417, 26);
            this.email.TabIndex = 10;
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(141, 143);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(406, 26);
            this.alamat.TabIndex = 9;
            // 
            // angkatan
            // 
            this.angkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.angkatan.FormattingEnabled = true;
            this.angkatan.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.angkatan.Location = new System.Drawing.Point(141, 104);
            this.angkatan.Name = "angkatan";
            this.angkatan.Size = new System.Drawing.Size(406, 28);
            this.angkatan.TabIndex = 8;
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(141, 64);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(406, 26);
            this.nama.TabIndex = 7;
            // 
            // npm
            // 
            this.npm.Location = new System.Drawing.Point(141, 27);
            this.npm.Name = "npm";
            this.npm.Size = new System.Drawing.Size(406, 26);
            this.npm.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "NO HP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "EMAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ALAMAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ANGKATAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAMA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NPM";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnhapus);
            this.groupBox3.Controls.Add(this.btnubah);
            this.groupBox3.Controls.Add(this.btnsimpan);
            this.groupBox3.Controls.Add(this.btnrefresh);
            this.groupBox3.Location = new System.Drawing.Point(709, 520);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 238);
            this.groupBox3.TabIndex = 2;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbCariData);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(709, 404);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(383, 78);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pencarian";
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
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(90, 26);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(287, 26);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::P10_714220058.Properties.Resources._6;
            this.ClientSize = new System.Drawing.Size(1395, 793);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ULBI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nohp;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.ComboBox angkatan;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox npm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.DataGridView DataMahasiswa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label label7;
    }
}

