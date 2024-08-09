using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şekil uygulamasına hoşgeldiniz");

            while (true)
            {
                Console.WriteLine("İşlem seçiniz");
                Console.WriteLine("1- Dikdörtgen işlemleri");
                Console.WriteLine("2- Üçgen işlemleri");
                Console.WriteLine("q- Çıkış");

                string secim = Console.ReadLine();

                if( secim == "q")
                {
                    break;
                }
                else if (secim == "1")

                {
                  
                    while (true)
                    {
                        Console.WriteLine("1- Dikdörtgen alanı hesapla");
                        Console.WriteLine("2- Dikdörtgen bilgileri göster");
                        Console.WriteLine("3- Dikdörtgen çıkış yap");

                        string Dsecim = Console.ReadLine();

                        if ( Dsecim == "3")
                        {
                            break;
                        }
                        else if ( Dsecim == "1")
                        {
                            Console.Write("Kısa Kenar giriniz: ");
                            int KK = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Uzun Kenar giriniz: ");
                            int UK = Convert.ToInt32(Console.ReadLine());

                            Dikdortgen dikdortgen = new Dikdortgen("Dikdörtgen",UK,KK);

                            dikdortgen.sekilHesapla();
                        }
                        else if( Dsecim == "2")
                        {

                            Console.Write("Kısa Kenar giriniz: ");
                            int KK = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Uzun Kenar giriniz: ");
                            int UK = Convert.ToInt32(Console.ReadLine());

                            Dikdortgen dikdortgen = new Dikdortgen("Dikdörtgen", UK, KK);

                            dikdortgen.sekilBilgileriGoster();

                        }
                    }
                }
                else if( secim == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("1- Üçgen alanı hesapla");
                        Console.WriteLine("2- Üçgen bilgileri göster");
                        Console.WriteLine("3- Üçgenden çıkış yap");

                        string Usecim = Console.ReadLine();

                        if (Usecim == "3")
                        {
                            break;
                        }
                        else if (Usecim == "1")
                        {
                            Console.Write("Üçgenin yüksekliğini giriniz: ");
                            int Yukseklik = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Üçgenin taban alanını giriniz: ");
                            int TabanAlan = Convert.ToInt32(Console.ReadLine());

                            Ucgen ucgen = new Ucgen("Üçgen", Yukseklik, TabanAlan);
                            ucgen.sekilHesapla();

                        }
                        else if (Usecim == "2")
                        {
                            Console.Write("Üçgenin yüksekliğini giriniz: ");
                            int Yukseklik = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Üçgenin taban alanını giriniz: ");
                            int TabanAlan = Convert.ToInt32(Console.ReadLine());

                            Ucgen ucgen = new Ucgen("Üçgen", Yukseklik, TabanAlan);
                            ucgen.sekilBilgileriGoster();
                        }
                    }
                }


            }
        }
    }
}
