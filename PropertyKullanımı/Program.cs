using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyKullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.KİLO = 84;

            Console.WriteLine(musteri1.KİLO);

            Console.ReadLine();
        }
    }
}
