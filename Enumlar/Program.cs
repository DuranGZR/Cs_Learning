using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gunler gun = Gunler.pazartesi;

            if(gun == Gunler.pazartesi)
            {
                Console.WriteLine("gün pazartesidir");
            }
            else if(gun == Gunler.salı)
            {
                Console.WriteLine("gün salıdır");
            }

            Console.ReadLine();
;       }
    }
}
