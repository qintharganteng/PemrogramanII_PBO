﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_3_714220058
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.Write("MENU PERSEGI PANJANG\n-------------------------------");
                Console.WriteLine("\n1. Hitung Luas");
                Console.WriteLine("\n2. Hitung Keliling");
                Console.WriteLine("MENU PILIHAN : ");

                int hasil = Convert.ToInt16(Console.ReadLine());

                double panjang, lebar;

                if (hasil == 1)
                {
                    Console.WriteLine("Masukan panjang");
                    int angka1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukan Lebar");
                    int angka2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    int Luas = angka1 * angka2;
                    Console.WriteLine("Luas persegi panjang = {2}", angka1, angka2, Luas);
                }

                else if (hasil == 2)
                {
                    Console.WriteLine("Masukan panjang");
                    int angka1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukan Lebar");
                    int angka2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    int keliling = 2 * (angka1 + angka2);
                    Console.WriteLine("Keliling persegi panjang = {3}", 2, angka1, angka2, keliling);

                }
                Console.Write("\nINGIN MENGULANG KEMBALI (Y/T)? ");

            }

            while (Console.ReadLine() == "Y");
        }
    }
}
