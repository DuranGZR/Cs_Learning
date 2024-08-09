using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba(4,"BMW","Siyah");

           

            araba1.KapilariKilitle();
            araba1.MotorCalistir();

            Console.WriteLine("Arabanın kapı sayısı: "+ araba1.kapiSayisi );
            Console.WriteLine("Araba rengi: "+ araba1.arabaRengi);
            Console.WriteLine("Arabanın modeli: "+ araba1.arabaModel);

            Musteri Musteri1 = new Musteri();

            Musteri1.isim = "duran";
            Musteri1.soyisim = "gezer";
            Musteri1.maasDegeri = 100000;
            Musteri1.cinsiyet = "erkek";

            Musteri1.MusteriBilgileriGoster();

            Console.ReadLine();
        }
    }
}
