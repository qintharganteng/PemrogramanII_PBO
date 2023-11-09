using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714220058
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(500, 255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorMessage += "Nama Belum Diisi\n";
            }

            if (String.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorMessage += "Prodi Belum Diisi\n";
            }else if(!Regex.IsMatch(textBox2.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMessage += "Prodi harus berformat [Strata]-[Prodi]\n";
            }


            if (String.IsNullOrWhiteSpace(textBox3.Text))
            {
                errorMessage += "Kelas Belum Diisi\n";
            }

            if(string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    "Lengkap",
                    "Informasi Data Sumbit",
                    MessageBoxButtons.OK,MessageBoxIcon.Information
                    );
                this.Size = new Size(500, 500);
            }
            else
            {
                MessageBox.Show(
                   errorMessage,
                   "Informasi Data Sumbit",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning
                   );
            }
        }

        private void rbsenin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbsenin.Checked)
            {
                cbkuliah.Enabled = true; cbkuliah.Checked = true;
                cbtraveling.Enabled = false; cbtraveling.Checked = false;
                cbtidur.Enabled = true; cbtidur.Checked = false;
            }
        }

        private void rbminggu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbminggu.Checked)
            {
                cbkuliah.Enabled = false;
                cbtraveling.Enabled = true;
                cbtidur.Enabled = true;
            }
        }

        private void buttonform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            //textBox1.Text = null;
            //textBox2.Text = null;
            //textBox3.Text = null;

            foreach (Control control in Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;

               // UNTUK COMBO BOX
               // else if (control is ComboBox)
                    //((ComboBox)control).SelectedIndex = -1;
            }

            this.Size = new Size(500, 255);
        }

        private void buttonprint_Click(object sender, EventArgs e)
        {
            String Hari = "";
            String Kegiatan = "";

            if (rbsenin.Checked)
            {
                Hari += "Senin";
            }
            else if (rbminggu.Checked)
            {
                Hari += "Minggu";
            }

            if (cbtidur.Checked && cbkuliah.Checked)
            {
                Kegiatan += "Kuliah, Tidur";
            }
            else if (cbtraveling.Checked && cbtidur.Checked)
            {
                Kegiatan += "Travelling, Tidur";
            }

            MessageBox.Show("Nama :" + textBox1.Text +
                "\nProdi :" + textBox2.Text +
                "\nKelas :" + textBox3.Text +
                "\nHari :" + Hari +
                "\nKegiatan :" + Kegiatan,
                "Informasi Kegiatan",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
