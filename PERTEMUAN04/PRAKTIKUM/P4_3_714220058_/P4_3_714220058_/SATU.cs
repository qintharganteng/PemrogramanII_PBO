using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_3_714220058_
{
    internal class garuttest
    {
        static void Main(string[] args)
        {
            // MEMANGGIL GARUT
            Garut KotaGarut = new Garut()
            {
                tentang = "Kabupaten Garut adalah sebuah wilayah Kabupaten yang terletak di provinsi Jawa Barat, Indonesia.",
                provinsi = "Kota Garut Terletak di Provinsi Jawa Barat",
              populasi = "Populasi Di Garut Sebanyak 263700000 Jiwa",
            };
            KotaGarut.semua();
            Console.WriteLine(KotaGarut.tentang);
            Console.WriteLine(KotaGarut.provinsi);
            Console.WriteLine(KotaGarut.populasi);

            //MEMANGGIL KOTA
            Kota p = new Kota();
            p.HEHE();

            Leles l = new Leles();
            l.HEHE();
        }
    }
}
