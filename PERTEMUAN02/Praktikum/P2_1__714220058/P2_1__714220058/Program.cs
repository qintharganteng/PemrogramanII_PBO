using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1__14220058
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("MASUKAN ANGKA PERTAMA ANDA");
            double hasil1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("MASUKAN ANGKA KEDUA ANDA");
            double hasil2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            double pembagian = hasil1 / hasil2;
            Console.WriteLine("hasil1 /= hasil2 = {0}",pembagian);

            double perkalian = hasil1 * hasil2;
            Console.WriteLine("hasil1 *= hasil2 = {0}" ,perkalian);

            double pejumlahan = hasil1 + hasil2;
            Console.WriteLine("hasil1 += hasil2 = {0}", pejumlahan);

            double pengurangan = hasil1 - hasil2;
            Console.WriteLine("hasil1 -= hasil2 = {0}", pengurangan);

        }
    }
}
