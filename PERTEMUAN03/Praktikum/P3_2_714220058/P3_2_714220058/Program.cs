using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P3_2_714220058
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("MASUKAN JUMLAH AYAM :");
            int Q = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ANAK AYAM TURUN " + Q);
            Console.WriteLine(" ");

            if (Q <= 0 || Q > 10)
            {
                Console.WriteLine("Nilai tidak boleh kurang dari 0, dan maksimal bernilai 10");
            }
            else
            {
                for (int i = Q; Q>= 1; Q--)
                {
                    if (Q == 1)
                    {
                        Console.WriteLine("Anak ayam turun 1, mati satu tinggal induknya");
                    }
                    else
                    {
                        Console.WriteLine($"Anak ayam turun {Q}, mati satu tinggal lah {Q - 1}");
                    }
                }
            }
        }
    }
}





