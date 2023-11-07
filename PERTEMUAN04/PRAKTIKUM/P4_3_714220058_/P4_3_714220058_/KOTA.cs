using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_3_714220058_
{
    internal class KOTA
    {
    }
    
    class Kota
    {
        public virtual void HEHE()
        {
            Console.WriteLine("KOTA GARUT MENJADI KOTA PALING BERSIH DI DUNIA");
        }
    }

    class Leles : Kota
    {
        public override void HEHE()
        {
            Console.WriteLine("LELES MERUPAKAN DAERAH PALING BERSIH DI GARUT");
        }
    }
}
