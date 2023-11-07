using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_714220058
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            String inputText = textBox1.Text;

            if (String.IsNullOrEmpty(inputText))
            {
                epCorrect.SetError(textBox1, "");
                epWarning.SetError(textBox1, "NAMA TIDAK BOLEH KOSONG");
                epWrong.SetError(textBox1, "");
            }
            else
            {
                if (inputText.Substring(0).All(Char.IsLetter)) 
                {
                    epCorrect.SetError(textBox1, "NAMA SUDAH DIINPUT");
                    epWarning.SetError(textBox1, "");
                    epWrong.SetError(textBox1, "");
                }
                else
                {
                    epCorrect.SetError(textBox1, "");
                    epWarning.SetError(textBox1, "");
                    epWrong.SetError(textBox1, "NAMA HARUS BERUPA HURUF");
                }
            }
        }
    

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "") ;
            {
                epWarning.SetError(textBox2, "NOMOR HP Tidak boleh kososng");
                epWrong.SetError(textBox2, "");
                epCorrect.SetError(textBox2, "");
            }
            if ((textBox2.Text).All(Char.IsNumber))
            {
                if(textBox2.Text.Length >= 11 && (textBox2.Text.Length <=12 ))
                {
                    epWarning.SetError(textBox2, "");
                    epWrong.SetError(textBox2, "");
                    epCorrect.SetError(textBox2, "NOMOR HP SUDAH TER INPUT");
                }
                else
                {
                    epWarning.SetError(textBox2, "HARUS LEBIH DARI 11 NOMOR");
                    epWrong.SetError(textBox2, "");
                    epCorrect.SetError(textBox2, "");
                }
            }
            else
            {
                epWarning.SetError(textBox2, "");
                epWrong.SetError(textBox2, "Inputan hanya boleh ANGKA!");
                epCorrect.SetError(textBox2, "");
            }
        }

        private void label4_Leave(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            String MasukanEmail = textBox3.Text;

            if (textBox3.Text == "") ;
            {
                epWarning.SetError(textBox3, "Email Tidak boleh kososng");
                epWrong.SetError(textBox3, "");
                epCorrect.SetError(textBox3, "");
            }

            if (Regex.IsMatch(textBox3.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(textBox3, "");
                epCorrect.SetError(textBox3, "EMAIL SUDAH TER INPUT");
                epWrong.SetError(textBox3, "");
            }
            else
            {
                epWarning.SetError(textBox3, "");
                epWrong.SetError(textBox3, "Format Email Salah!\nContoh: a@b.c");
                epCorrect.SetError(textBox3, "");
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            int sizesepatu = Convert.ToInt32(textBox4.Text);

            if (textBox4.Text == "")
            {
                epCorrect.SetError(textBox4, "");
                epWrong.SetError(textBox4, "");
                epWarning.SetError(textBox4, "SIZE SEPATU HARUS DIISI");
            }
            else
            {
                if ((textBox4.Text).All(Char.IsNumber))
                {
                    if (sizesepatu >= 30 )
                    {
                        epCorrect.SetError(textBox4, "SIZE SEPATU SUDAH TER INPUT");
                        epWrong.SetError(textBox4, "");
                        epWarning.SetError(textBox4, "");
                    }
                    else
                    {
                        epCorrect.SetError(textBox4, "");
                        epWrong.SetError(textBox4, "");
                        epWarning.SetError(textBox4, "SIZE SEPATU HARUS LEBIH DARI 30");
                    }
                }
            else
            {
                    epCorrect.SetError(textBox4, "");
                    epWrong.SetError(textBox4, "HARUS ANGKA");
                    epWarning.SetError(textBox4, "");
            }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") 
            {
                MessageBox.Show("NAMA HARUS DIISI!","WARNING",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("NOMOR HP HARUS DIISI", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("EMAIL HARUS TERISI", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("SIZE SEPATU HARUS DIISI", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("NAMA : " + textBox1 +
                "\n NOMOR HP : " + textBox2 +
                "\n EMAIL : " + textBox3 +
                "\n SIZE : " + textBox4 +
                "\n MERK SEPATU" + comboBox1,
                "PEMESANAN SEPATU", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Close();
        }
    }
}

