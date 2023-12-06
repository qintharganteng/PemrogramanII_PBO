using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS_714220058
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(800, 250);
            groupBox2.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text).All(Char.IsNumber))
            {
                if (textBox1.Text.Length >= 9 && (textBox1.Text.Length <= 10))
                {
                    warning.SetError(textBox1, "");
                    error.SetError(textBox1, "");
                    correct.SetError(textBox1, "NPM SUDAH BENAR");
                }
                else
                {
                    warning.SetError(textBox1, "MAKSIMAL 10 NOMOR DAN TIDAK BOLEH KOSONG");
                    error.SetError(textBox1, "");
                    correct.SetError(textBox1, "");
                }
            }
            else
            {
                warning.SetError(textBox1, "");
                error.SetError(textBox1, "Inputan hanya boleh ANGKA!");
                correct.SetError(textBox1, "");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                errorMessage += "NPM BELUM DIISI\n";
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                errorMessage += "NAMA BELUM DIISI\n";
            }
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                errorMessage += "JENIS KELAMIN BELUM DIISI\n";
            }
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                errorMessage += "ALAMAT BELUM DIISI\n";
            }
            if (comboBox1.SelectedIndex == -1)
            {
                errorMessage += "PROGRAM STUDI BELUM DIISI";
            }
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                errorMessage += "TAHUN AKADEMIK BELUM DIISI";
            }
            if (String.IsNullOrEmpty(textBox5.Text))
            {
                errorMessage += "SEMESTER BELUM DIISI";
            }
            if (String.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show("LENGKAP", "INFORMASI INPUT DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Size = new Size(800, 500);
            }
            else
            {
                MessageBox.Show(errorMessage, "DIPERHATIKAN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String inputText = textBox2.Text;

            if (String.IsNullOrEmpty(inputText))
            {
                correct.SetError(textBox2, "");
                warning.SetError(textBox2, "NAMA TIDAK BOLEH KOSONG");
                error.SetError(textBox2, "");
            }
            else
            {
                if (inputText.Substring(0).All(Char.IsLetter))
                {
                    correct.SetError(textBox2, "NAMA SUDAH BENAR");
                    warning.SetError(textBox2, "");
                    error.SetError(textBox2, "");
                }
                else
                {
                    correct.SetError(textBox2, "");
                    warning.SetError(textBox2, "");
                    error.SetError(textBox2, "NAMA HARUS BERUPA HURUF");
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox4.Text, @"^\d{4}/\d{4}$"))
            {
                correct.SetError(textBox4, "TAHUN AKADEMIK BENAR");
                warning.SetError(textBox4, "");
                error.SetError(textBox4, "");
            }
            else
            {
                correct.SetError(textBox4, "");
                warning.SetError(textBox4, "");
                error.SetError(textBox4, "HARUS TERDAPAT (/) SEBAGAI PEMISAH DAN (****/****)");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text).All(Char.IsNumber))
            {
                if (textBox1.Text.Length >= 1 && (textBox1.Text.Length <= 14))
                {
                    warning.SetError(textBox5, "");
                    error.SetError(textBox5, "");
                    correct.SetError(textBox5, "SEMESTER SUDAH BENAR");
                }
                else
                {
                    warning.SetError(textBox1, "MAKSIMAL 1-14 SEMESTER DAN TIDAK BOLEH KOSONG");
                    error.SetError(textBox1, "");
                    correct.SetError(textBox1, "");
                }
            }
            else
            {
                warning.SetError(textBox1, "");
                error.SetError(textBox1, "INPUTAN HANYA BOLEH ANGKA ANGKA!");
                correct.SetError(textBox1, "");
            }
        }

        private void radioButton3_TextChanged(object sender, EventArgs e)
        {
            // SALAH EVENT
        }

        private void radioButton4_TextChanged(object sender, EventArgs e)
        {
            //SALAH EVENT
        }

        private void radioButton5_TextChanged(object sender, EventArgs e)
        {
            //SALAH EVENT
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            if (radioButton3.Checked)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = false;
                checkBox9.Checked = false;
                checkBox10.Enabled = true;
                checkBox11.Enabled = true;
                checkBox12.Enabled = false;
                checkBox12.Checked = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            if (radioButton4.Checked)
            {

                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = false;
                checkBox6.Checked = false;
                checkBox7.Enabled = true;
                checkBox8.Enabled = false;
                checkBox8.Checked = false;
                checkBox9.Enabled = true;
                checkBox10.Enabled = true;
                checkBox11.Enabled = true;
                checkBox12.Enabled = true;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            if (radioButton5.Checked)
            {
                checkBox1.Enabled = false;
                checkBox1.Checked = false;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = false;
                checkBox6.Checked = false;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = false;
                checkBox9.Checked = false;
                checkBox10.Enabled = true;
                checkBox11.Enabled = true;
                checkBox12.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Jenis_Kelamin = "";
            string Kurikulum = "";
            string Mata_Kuliah = "";

            if (radioButton1.Checked == true)
            {
                Jenis_Kelamin = "LAKI LAKI";
            }
            else if (radioButton2.Checked == true)
            {
                Jenis_Kelamin = "PEREMPUAN";
            }
            else
            {
                MessageBox.Show("HARUS MEMILIH JENIS KELAMIN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (radioButton3.Checked == true)
            {
                Kurikulum = "Kurikulum 2006";
            }
            else if (radioButton4.Checked == true)
            {
                Kurikulum = "Kurikulum 2013";
            }
            else if (radioButton5.Checked == true)
            {
                Kurikulum = "Kurikulum Meredeka";
            }
            else
            {
                MessageBox.Show("HARUS MEMILIH KURIKULUM", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkBox1.Checked == true)
            {
                Mata_Kuliah += "Matematika";
            }
            if (checkBox2.Checked == true)
            {
                Mata_Kuliah += "Pemrograman 1";
            }
            if (checkBox3.Checked == true)
            {
                Mata_Kuliah += "Pemrograman 2";
            }
            if (checkBox4.Checked == true)
            {
                Mata_Kuliah += "Pemrograman 3";
            }
            if (checkBox5.Checked == true)
            {
                Mata_Kuliah += "Pemrograman 4";
            }
            if (checkBox6.Checked == true)
            {
                Mata_Kuliah += "Fisika";
            }
            if (checkBox7.Checked == true)
            {
                Mata_Kuliah += "Pen. Agama";
            }
            if (checkBox8.Checked == true)
            {
                Mata_Kuliah += "Pen. Kewarganegaraan";
            }
            if (checkBox9.Checked == true)
            {
                Mata_Kuliah += "Pengantar Logistik";
            }
            if (checkBox10.Checked == true)
            {
                Mata_Kuliah += "Jaringan Komputer";
            }
            if (checkBox11.Checked == true)
            {
                Mata_Kuliah += "Sistem Operasi";
            }
            if (checkBox12.Checked == true)
            {
                Mata_Kuliah += "Manajemen Rantai Pasok";
            }

            if (String.IsNullOrWhiteSpace(Mata_Kuliah))
            {
                MessageBox.Show("PILIH SALAH SATU MATA KULIAH!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("NPM : " + textBox1.Text +
            "\nNAMA : " + textBox2.Text +
            "\nJENIS KELAMIN : " + Jenis_Kelamin +
            "\nALAMAT : " + textBox3.Text +
            "\nProgram Studi : " + comboBox1.Text +
            "\nTahun Akademik : " + textBox4.Text +
            "\nSemester : " + textBox5.Text +
            "\n=======================================" +
            "\nKurikulum : " + Kurikulum +
            "\nMata Kuliah : " + Mata_Kuliah,
            "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                    warning.SetError(textBox, "");
                    error.SetError(textBox, "");
                    correct.SetError(textBox, "");
                }
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                    warning.SetError(comboBox, "");
                    error.SetError(comboBox, "");
                    correct.SetError(comboBox, "");
                }
                this.Size = new Size(800, 250);
            }
        }
    }
}
