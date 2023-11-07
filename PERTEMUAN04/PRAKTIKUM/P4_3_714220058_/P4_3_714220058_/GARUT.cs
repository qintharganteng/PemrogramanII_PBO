using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace P4_3_714220058_
{
    public class Garut
    {
        public string tentang;
        public string provinsi;
        public string populasi;

        public void semua()
        {
            this.tentang = tentang;
            this.provinsi = provinsi;
            this.populasi = populasi;
        }

        public Garut(string tentang, string provinsi, string populasi)
        {
            this.tentang = tentang;
            this.provinsi = provinsi;
            this.populasi = populasi;
        }

        public Garut()
        {
            this.tentang = "";
            this.provinsi = "";
            this.populasi = "";
        }
    }

    

}
