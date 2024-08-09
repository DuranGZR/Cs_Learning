using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            List<int> rakamlar = new List<int>();
            rakamlar.Add(1);
            rakamlar.Add(2);
            rakamlar.Add(3);
            rakamlar.Add(4);
            rakamlar.Add(5);
                
            rakamlar.Add(6);
            rakamlar.Add(7);
            rakamlar.Add(8);
            rakamlar.Add(9);


            foreach (int i in rakamlar)
            {
                Console.WriteLine(i);
            }
            */

            List<Musteri> musteriler = new List<Musteri>();

            musteriler.Add(new Musteri(1, "duran", "gezer", "durangezer2004@gmail.com"));
            musteriler.Add(new Musteri(2, "enes", "bayram", "enes_bayram@gmail.com"));
            musteriler.Add(new Musteri(3, "bilal", "habeşi", "bilal_xxKralxx@gmail.com"));


            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri);
            }

            Console.ReadLine();

        }
    }
}
