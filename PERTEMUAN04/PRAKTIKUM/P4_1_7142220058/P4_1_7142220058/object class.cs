using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_7142220058
{
    internal class object_class
    {
    }


    //CLASS
    public class Mobil
    {
        public double kecepatan;
        public double bensin;
        public double posisi;
        public string nama;

        public void percepat()
        {
            this.kecepatan += 10;
            this.bensin -= 5;
        }
        public void maju()
        {
            this.posisi += this.kecepatan;
            this.bensin -= 2;
        }
        public void isiBensin(double bensin)
        {
            this.bensin += bensin;
        }

        //PARAMETER
        public Mobil(string nama, double kecepatan, double bensin)
        {
            //FIELD
            this.nama = nama;
            this.kecepatan = kecepatan;
            this.bensin = bensin;
            this.posisi = 0;
        }

        public Mobil()
        {
            this.nama = "";
            this.kecepatan = 0;
            this.bensin = 0;
            this.posisi = 0;
        }
    }
}
