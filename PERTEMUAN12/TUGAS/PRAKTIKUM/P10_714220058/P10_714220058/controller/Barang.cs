using P10_714220058.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_714220058.controller
{
    internal class Barang
    {

        Koneksi koneksi = new Koneksi();

        public bool Insert(model.M_barang barang) //masuk
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_barang (nama_barang,harga) VALUES('" + barang.Nama_barang + "', '" + barang.Harga + "')");
                status = true;
                MessageBox.Show("Data Berhasil Ditambahkan", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Aktifitas Gagal", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Update(M_barang barang, string id) //update
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_barang SET nama_barang='" +
               barang.Nama_barang + "'," + "harga='" + barang.Harga + "' WHERE id_barang = '" + id + "'");

                status = true;
                MessageBox.Show("Data Berhasil Diubah", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, " Aktifitas Gagal", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Delete(string id) //hapus
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM t_barang WHERE id_barang='"
               + id + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Aktifitas Gagal", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
