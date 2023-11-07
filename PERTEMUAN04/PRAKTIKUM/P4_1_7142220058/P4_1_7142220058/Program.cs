using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_7142220058
{
    public class Program
    {
        public void Tes(string a, int b) 
            {
            Console.WriteLine("tes");
            }


        // memanggil 
        static void Main(string[] args)
        {
            Mobil SuatuMobil = new Mobil();
            Mobil MobilSaya = new Mobil() { nama = "AVANZA PUTIH", kecepatan = 0, bensin = 30000, posisi = 0 }; 
            MobilSaya.percepat();
            Console.WriteLine(MobilSaya.nama);
            Console.WriteLine(MobilSaya.bensin);

            MobilSaya.maju();
            Console.WriteLine(MobilSaya.nama);
            Console.WriteLine(MobilSaya.bensin);

            Mobil MobilAnda = new Mobil("AVANZA HITAM", 300, 500);
            Console.WriteLine(MobilAnda.nama);



            //MEMANGGIL FIELD PROPERTY
            PropertyTest prop = new PropertyTest();
            prop.Materi = "PEMROGRAMAN C#";
            Console.WriteLine(prop.Materi);
 
            Person Qinthar = new Person();
            Qinthar.Nilai = 120;
            Console.WriteLine(Qinthar.Nilai);

            Avanza c = new Avanza();
            Console.WriteLine(c.Roda);
            c.Klakson();
            c.Klakson2();

            lingkaran p = new lingkaran();
            p.Gambar();

            Persegi l = new Persegi();
            l.Gambar();
            
        }
    }
}
