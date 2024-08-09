using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InharitenceGiriş
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kedi kedi = new Kedi();


            kedi.hayvan_isim = "Boncuk";
            kedi.hayvan_rengi = "beyaz";
            kedi.hayvan_cinsiyet = "she/her";


            kedi.BilgileriGoster();

            Console.ReadLine();
        }
    }
}
