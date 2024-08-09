using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace InheritanceUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Çalışan uygulamasına hoşgeldiniz...");

            

            while (true)

            {
                Console.WriteLine("1- Yazılımcı işlemkeri");
                Console.WriteLine("2- Yönetici işlemleri");
                Console.WriteLine("q- Çıkış");

                string islem = Console.ReadLine();

                switch (islem)
                {
                    case "q":
                        Console.WriteLine("Uygulamadan çıkılıyor...");
                        return;

                    case "1":
                        Yazılımcı yazilimci = new Yazılımcı(1,"Enes","Bayram","java,c#,c++");

                      

                        while (true)
                        {
                            Console.WriteLine("Yazılımcı işlemi seçiniz");
                            Console.WriteLine("1- Format At");
                            Console.WriteLine("2- Yazılımcının Bilgilerini Göster");
                            Console.WriteLine("q- çıkış");
                            string yazilimciIslem = Console.ReadLine();

                            if (yazilimciIslem == "q")
                            {
                                Console.WriteLine("Yazılımcı işlemlerinden çıkış yapılıyor");
                                break;
                            }
                            else if (yazilimciIslem == "1")
                            {
                                Console.Write("İşletim sistemi giriniz: ");
                                string IsletimSistemi = Console.ReadLine();

                                yazilimci.formatAt(IsletimSistemi);
                            }
                            else if(yazilimciIslem == "2")
                            {
                                yazilimci.BilgileriGorter();
                            }
                            else
                            {
                                Console.WriteLine("Lüten geçerli bir işlem giriniz.");
                            }
                        }

                        break;

                    case "2":
                        Yonetici yonetici = new Yonetici(2,"Yakup","Reçber",12);
                      
                        while (true)
                        {
                            Console.WriteLine("Yönetici işlemi seçiniz");
                            Console.WriteLine("1- Zam Yap");
                            Console.WriteLine("2- Yöneticinin Bilgilerini Göster");
                            Console.WriteLine("q- çıkış");
                            string yoneticiIslem = Console.ReadLine();

                            if (yoneticiIslem == "q")
                            {
                                Console.WriteLine("Yönetici işlemlerinden çıkış yapılıyor");
                                break;
                            }
                            else if (yoneticiIslem == "1")
                            {
                                Console.Write("Zam miktarını giriniz.");
                                int zam = Convert.ToInt32( Console.ReadLine());

                                yonetici.zamYap(zam);
                            }
                            else if( yoneticiIslem == "2")
                            {
                                yonetici.BilgileriGorter();
                            }
                            else
                            {
                                Console.WriteLine("Lütfen geçerli bir işlem giriniz");
                            }
                        }


                        break;

                    default:
                        Console.WriteLine("Lütfen çalışan uygulaması için geçerli bir işlem giriniz");
                        break;





                }


            }
        }
    }
}
