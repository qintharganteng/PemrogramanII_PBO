using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace P5_4_714220058_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jadwal = "";
            string kelas = "";

            if (textBox1.Text == "")
            {
                MessageBox.Show("WARNING!", "NAMA HARUS DIISI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.Text != "LAKI LAKI" && comboBox1.Text != "PEREMPUAN") ;
            {
                MessageBox.Show("WARNING!", "JENIS KELAMIN TIDAK VALID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkBox1.Checked)
            {
                kelas += "Biola, ";
            }
            if (checkBox2.Checked)
            {
                kelas += "Gitar, ";
            }
            if (checkBox3.Checked)
            {
                kelas += "Saxophone, ";
            }
            if (checkBox4.Checked)
            {
                kelas += "Konduktor, ";
            }
            if (checkBox5.Checked)
            {
                kelas += "Piano, ";
            }
            if (checkBox6.Checked)
            {
                kelas += "Drum, ";
            }
            if (checkBox7.Checked)
            {
                kelas += "Vokal, ";
            }
            if (checkBox8.Checked)
            {
                kelas += "Komposer, ";
            }

            kelas = kelas.TrimEnd(',', ' ');

            if (string.IsNullOrWhiteSpace(kelas))
            {
                MessageBox.Show("WARNING!", "HARUS MEMILIH SALAH SATU DARI KELAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (radioButton1.Checked == true)
            {
                jadwal = "Senin & Rabu, 14.00 - 16.00";
            }
            else if (radioButton2.Checked == true)
            {
                jadwal = "Selasa & Kamis, 14.00 - 16.00";
            }
            else if (radioButton3.Checked == true)
            {
                jadwal = "Sabtu & Minggu, 09.00 - 11.00";
            }
            else if (radioButton4.Checked == true)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }
            else
            {
                MessageBox.Show("WARNING!"," HARUS MEMILIH SALAH SATU JADWAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            MessageBox.Show("Nama :" + textBox1.Text +
                "\nJenis Kelamin : " + comboBox1.Text +
                "\nTanggal Lahir : " + dateTimePicker1.Text +
                "\nPilihan Kelas : " + kelas +
                "\nPilihan Jadwal : " + jadwal,
                "INFORMASI PENDAFTARAN", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


    }
}
