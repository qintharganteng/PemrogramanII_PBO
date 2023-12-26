using P10_714220058.controller;
using P10_714220058.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_714220058.view
{
    public partial class FormBarang : Form
    {

        Koneksi koneksi = new Koneksi();
        M_barang m_barang = new M_barang();
        string id_barang;
        public FormBarang()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            Databarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang");
            Databarang.Columns[0].HeaderText = "ID Barang";
            Databarang.Columns[1].HeaderText = "Nama Barang";
            Databarang.Columns[2].HeaderText = "Harga";
        }

        public void resetForm()
        {
            namabarang.Text = "";
            harga.Text = "";
            caridata.Text = "";
        }

        private void DataNilai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (namabarang.Text == "" || (namabarang.Text).All(Char.IsNumber) || harga.Text == "" || (harga.Text).All(Char.IsLetter))
            {
                MessageBox.Show("Isi data dengan benar sebelum dimasukkan!", "Terjadi Kesalahan Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Barang barang = new Barang();
                m_barang.Nama_barang = namabarang.Text;
                m_barang.Harga = harga.Text;

                barang.Insert(m_barang);
                resetForm();
                Tampil();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            {
                resetForm();
                Tampil();
            }
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            if (namabarang.Text != "" || !namabarang.Text.All(Char.IsNumber) || harga.Text != "" || !harga.Text.All(Char.IsLetter))
            {
                Barang barang = new Barang();
                m_barang.Nama_barang = namabarang.Text;
                m_barang.Harga = harga.Text;

                barang.Update(m_barang, id_barang);
                resetForm();
                Tampil();
            }
            else
            {
                MessageBox.Show("Isi data dengan benar sebelum diperbarui!", "Terjadi Kesalahan Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah kamu yakin ingin menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                Barang barang = new Barang();
                barang.Delete(id_barang);
                resetForm();
                Tampil();
            }
        }

        private void caridata_TextChanged(object sender, EventArgs e)
        {
            Databarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang WHERE id_barang LIKE '%' '" + caridata.Text + "' '%' OR nama_barang LIKE '%' '" + caridata.Text + "' '%' OR harga LIKE '%' '" + caridata.Text + "' '%'");
        }

        private void FormBarang_Load_1(object sender, EventArgs e)
        {
            Tampil();
        }

        private string FormatDigitAngka(int number)
        {
            return string.Format("Rp {0:N0}", number);
        }


        private void DataBarang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }
        }

        private void DataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_barang = Databarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            namabarang.Text = Databarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            harga.Text = Databarang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
