using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_7142220058
{
    internal class Inheritance
    {
    }

    public class Car
    {
        public int Roda { get; set; }
        public int Tahun { get; set; }

        public void Klakson2()
        {
            Console.WriteLine("HEHEHEHEHHEHE");
        }
            
    }

    public class Avanza : Car
    {
        public Avanza()
        {
        Roda = 4; 
        }
        public void Klakson()
        {
            Console.WriteLine(" NGENGGGGGGGG-----!!!");
        }
    }

}
