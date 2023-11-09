namespace P7_1_714220058
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
            this.labelnama = new System.Windows.Forms.Label();
            this.labelprodi = new System.Windows.Forms.Label();
            this.labelkelas = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttoncek = new System.Windows.Forms.Button();
            this.buttonform = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rbsenin = new System.Windows.Forms.RadioButton();
            this.rbminggu = new System.Windows.Forms.RadioButton();
            this.cbkuliah = new System.Windows.Forms.CheckBox();
            this.cbtraveling = new System.Windows.Forms.CheckBox();
            this.cbtidur = new System.Windows.Forms.CheckBox();
            this.buttonprint = new System.Windows.Forms.Button();
            this.buttonreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelnama
            // 
            this.labelnama.AutoSize = true;
            this.labelnama.Location = new System.Drawing.Point(189, 91);
            this.labelnama.Name = "labelnama";
            this.labelnama.Size = new System.Drawing.Size(55, 20);
            this.labelnama.TabIndex = 0;
            this.labelnama.Text = "NAMA";
            // 
            // labelprodi
            // 
            this.labelprodi.AutoSize = true;
            this.labelprodi.Location = new System.Drawing.Point(190, 150);
            this.labelprodi.Name = "labelprodi";
            this.labelprodi.Size = new System.Drawing.Size(60, 20);
            this.labelprodi.TabIndex = 1;
            this.labelprodi.Text = "PRODI";
            // 
            // labelkelas
            // 
            this.labelkelas.AutoSize = true;
            this.labelkelas.Location = new System.Drawing.Point(190, 218);
            this.labelkelas.Name = "labelkelas";
            this.labelkelas.Size = new System.Drawing.Size(61, 20);
            this.labelkelas.TabIndex = 2;
            this.labelkelas.Text = "KELAS";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(390, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(390, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(390, 212);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 5;
            // 
            // buttoncek
            // 
            this.buttoncek.BackColor = System.Drawing.Color.Silver;
            this.buttoncek.Location = new System.Drawing.Point(206, 294);
            this.buttoncek.Name = "buttoncek";
            this.buttoncek.Size = new System.Drawing.Size(83, 37);
            this.buttoncek.TabIndex = 6;
            this.buttoncek.Text = "CEK";
            this.buttoncek.UseVisualStyleBackColor = false;
            this.buttoncek.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonform
            // 
            this.buttonform.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonform.Location = new System.Drawing.Point(390, 294);
            this.buttonform.Name = "buttonform";
            this.buttonform.Size = new System.Drawing.Size(141, 37);
            this.buttonform.TabIndex = 7;
            this.buttonform.Text = "TUTUP FORM";
            this.buttonform.UseVisualStyleBackColor = false;
            this.buttonform.Click += new System.EventHandler(this.buttonform_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "LIST KEGIATAN";
            // 
            // rbsenin
            // 
            this.rbsenin.AutoSize = true;
            this.rbsenin.Location = new System.Drawing.Point(193, 424);
            this.rbsenin.Name = "rbsenin";
            this.rbsenin.Size = new System.Drawing.Size(75, 24);
            this.rbsenin.TabIndex = 9;
            this.rbsenin.TabStop = true;
            this.rbsenin.Text = "Senin";
            this.rbsenin.UseVisualStyleBackColor = true;
            this.rbsenin.CheckedChanged += new System.EventHandler(this.rbsenin_CheckedChanged);
            // 
            // rbminggu
            // 
            this.rbminggu.AutoSize = true;
            this.rbminggu.Location = new System.Drawing.Point(194, 454);
            this.rbminggu.Name = "rbminggu";
            this.rbminggu.Size = new System.Drawing.Size(86, 24);
            this.rbminggu.TabIndex = 10;
            this.rbminggu.TabStop = true;
            this.rbminggu.Text = "Minggu";
            this.rbminggu.UseVisualStyleBackColor = true;
            this.rbminggu.CheckedChanged += new System.EventHandler(this.rbminggu_CheckedChanged);
            // 
            // cbkuliah
            // 
            this.cbkuliah.AutoSize = true;
            this.cbkuliah.Location = new System.Drawing.Point(194, 531);
            this.cbkuliah.Name = "cbkuliah";
            this.cbkuliah.Size = new System.Drawing.Size(78, 24);
            this.cbkuliah.TabIndex = 11;
            this.cbkuliah.Text = "Kuliah";
            this.cbkuliah.UseVisualStyleBackColor = true;
            // 
            // cbtraveling
            // 
            this.cbtraveling.AutoSize = true;
            this.cbtraveling.Location = new System.Drawing.Point(193, 561);
            this.cbtraveling.Name = "cbtraveling";
            this.cbtraveling.Size = new System.Drawing.Size(98, 24);
            this.cbtraveling.TabIndex = 12;
            this.cbtraveling.Text = "Traveling";
            this.cbtraveling.UseVisualStyleBackColor = true;
            // 
            // cbtidur
            // 
            this.cbtidur.AutoSize = true;
            this.cbtidur.Location = new System.Drawing.Point(193, 600);
            this.cbtidur.Name = "cbtidur";
            this.cbtidur.Size = new System.Drawing.Size(70, 24);
            this.cbtidur.TabIndex = 13;
            this.cbtidur.Text = "Tidur";
            this.cbtidur.UseVisualStyleBackColor = true;
            // 
            // buttonprint
            // 
            this.buttonprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonprint.Location = new System.Drawing.Point(206, 655);
            this.buttonprint.Name = "buttonprint";
            this.buttonprint.Size = new System.Drawing.Size(105, 36);
            this.buttonprint.TabIndex = 14;
            this.buttonprint.Text = "PRINT";
            this.buttonprint.UseVisualStyleBackColor = false;
            this.buttonprint.Click += new System.EventHandler(this.buttonprint_Click);
            // 
            // buttonreset
            // 
            this.buttonreset.BackColor = System.Drawing.Color.Silver;
            this.buttonreset.Location = new System.Drawing.Point(390, 655);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(135, 37);
            this.buttonreset.TabIndex = 15;
            this.buttonreset.Text = "RESET FORM";
            this.buttonreset.UseVisualStyleBackColor = false;
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 704);
            this.Controls.Add(this.buttonreset);
            this.Controls.Add(this.buttonprint);
            this.Controls.Add(this.cbtidur);
            this.Controls.Add(this.cbtraveling);
            this.Controls.Add(this.cbkuliah);
            this.Controls.Add(this.rbminggu);
            this.Controls.Add(this.rbsenin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonform);
            this.Controls.Add(this.buttoncek);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelkelas);
            this.Controls.Add(this.labelprodi);
            this.Controls.Add(this.labelnama);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnama;
        private System.Windows.Forms.Label labelprodi;
        private System.Windows.Forms.Label labelkelas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttoncek;
        private System.Windows.Forms.Button buttonform;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbsenin;
        private System.Windows.Forms.RadioButton rbminggu;
        private System.Windows.Forms.CheckBox cbkuliah;
        private System.Windows.Forms.CheckBox cbtraveling;
        private System.Windows.Forms.CheckBox cbtidur;
        private System.Windows.Forms.Button buttonprint;
        private System.Windows.Forms.Button buttonreset;
    }
}

