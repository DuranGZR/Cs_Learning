using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList koleksiyon = new ArrayList();

            koleksiyon.Add("adem");
            koleksiyon.Add("duran");
            koleksiyon.Add("ahmet");
            koleksiyon.Add("emir");


            //koleksiyon.Remove("ahmet");

            int count = koleksiyon.Count;
            Console.WriteLine(count);

            bool kontrol = koleksiyon.Contains("duran");
            Console.WriteLine(kontrol );


            foreach (var a in koleksiyon)
            {
                Console.WriteLine(a);
            }


            ArrayList rakamlar = new ArrayList();

            rakamlar.Add(20);
            rakamlar.Add(3);
            rakamlar.Add(50);    
            rakamlar.Add(5);
            rakamlar.Add(24);
            rakamlar.Add(79);

            foreach (int a in rakamlar)
            {
                Console.WriteLine( a);
            }

            rakamlar.Sort();

            foreach (int a in rakamlar)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
