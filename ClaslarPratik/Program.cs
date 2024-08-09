using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaslarPratik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogrenci1 = new Ogrenci(319,"Duran","Gezer",40,60,80,"İnönü");

            Console.WriteLine("Uygulamamıza hoş geldiniz... Yapmak iatediğiniz işlemi seçin");
            islemleriGözter();

          

            while (kontrol)
            {
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        ogrenci1.OgrenciBilgileriGoster();
                        break;

                    case "2":
                        double ogrenciOrt = ogrenci1.OgrenciNotuBul();
                        Console.WriteLine("Öğrencinin Ortalaması: "+ogrenciOrt);
                        break;

                    case "3":
                        ogrenci1.OkulaGetir();
                        break;

                    case "4":
                        kontrol = false;
                        break;
                }


            }



        }
        static void islemleriGözter()
        {
            Console.WriteLine("1- Öğrenci bilgileri göster");
            Console.WriteLine("2- Öğrenci ortalaması göster");
            Console.WriteLine("3- Öğrenci okulunu göster");
            Console.WriteLine("4- Çıkış yap");

        }
    }
}
