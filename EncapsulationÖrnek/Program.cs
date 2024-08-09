using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationÖrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel p1 = new Personel();

            p1.TCNO = "123a5678912";

            Console.WriteLine("TC kimlik numaranız: "+ p1.TCNO);

            Console.ReadLine();
        }
    }
}
