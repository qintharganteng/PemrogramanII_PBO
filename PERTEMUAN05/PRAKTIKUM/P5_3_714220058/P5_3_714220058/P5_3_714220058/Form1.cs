using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_714220058
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {

            string os = "";
            string status = "";

            if (rb_android.Checked == true)
            {
                os = "Android";
            }
            else if (rb_ios.Checked == true)
            {
                os = "IOS";
            }

            if (cbYa.Checked == true)
            {
                status = "YA, SUDAH DI PERBAIKI MAS";
            }

            MessageBox.Show(
                "Merk HP: " + txtMerkHP.Text + "\nSistem Operasi : " + os + "\nStatus Perbaikan :" + status, "Informasi Service HP", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
               
        }
    }
}
