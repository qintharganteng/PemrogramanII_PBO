using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Text;

namespace P6_3_714220058
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "") ;
            {
                epWarning.SetError(textBox1, "Textbox Huruf Tidak boleh kososng");
                epWrong.SetError(textBox1, "");
                epCorrect.SetError(textBox1, "");
            }
            if ((textBox1.Text).All(Char.IsLetter)) 
            {
                epWarning.SetError(textBox1, "");
                epWrong.SetError(textBox1, "");
                epCorrect.SetError(textBox1, "BETULL!");
            }
             else
            {
                epWarning.SetError(textBox1, "");
                epWrong.SetError(textBox1, "Inputan hanya boleh HURUF!");
                epCorrect.SetError(textBox1, "");
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "") ;
            {
                epWarning.SetError(textBox2, "Textbox Angka Tidak boleh kososng");
                epWrong.SetError(textBox2, "");
                epCorrect.SetError(textBox2, "");
            }
            if ((textBox2.Text).All(Char.IsNumber))
            {
                epWarning.SetError(textBox2, "");
                epWrong.SetError(textBox2, "");
                epCorrect.SetError(textBox2, "BETULL!");
            }
            else
            {
                epWarning.SetError(textBox2, "");
                epWrong.SetError(textBox2, "Inputan hanya boleh ANGKA!");
                epCorrect.SetError(textBox2, "");
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "") ;
            {
                epWarning.SetError(textBox3, "Textbox Huruf Tidak boleh kososng");
                epWrong.SetError(textBox3, "");
                epCorrect.SetError(textBox3, "");
            }

            if (Regex.IsMatch(textBox3.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(textBox3, "");
                epCorrect.SetError(textBox3, "BETUL!!");
                epWrong.SetError(textBox3, "");
            }
            else
            {
                epWarning.SetError(textBox2, "");
                epWrong.SetError(textBox2, "Format Email Salah!\nContoh: a@b.c");
                epCorrect.SetError(textBox2, "");
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if((textBox4.Text).All(Char.IsNumber))
            {
                epWarning.SetError(textBox4, "");
                epCorrect.SetError(textBox4, "BETULL!");
                epCorrect.SetError(textBox4, "");
            }
            if (textBox4.Text == "")            
            {
                epWarning.SetError(textBox4, "Teks Box Angka 1 Tidak Boleh Kosong!");
                epCorrect.SetError(textBox4, "");
                epWrong.SetError(textBox4, "");
            }
             else
            {
                epWarning.SetError(textBox4, "");
                epWrong.SetError(textBox4, "Inputan harus Angka");
                epCorrect.SetError(textBox4, "");
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            

            if((textBox5.Text).All(Char.IsNumber))
            {
                epWarning.SetError(textBox5, "");
                epCorrect.SetError(textBox5, "BETULL!");
                epCorrect.SetError(textBox5, "");
            }

            if (textBox5.Text == "")
            {
                epWarning.SetError(textBox5, "Teks Box Angka 1 Tidak Boleh Kosong!");
                epCorrect.SetError(textBox5, "");
                epWrong.SetError(textBox5, "");
            }
            else
            {
                epWarning.SetError(textBox5, "");
                epWrong.SetError(textBox5, "Inputan harus Angka");
                epCorrect.SetError(textBox5, "");
            }
            

        }
    }
}
