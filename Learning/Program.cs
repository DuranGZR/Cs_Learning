using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola");
            Console.WriteLine("Amigos");    
            

            //Console.Write("Durna");
            //Console.Write("Gezre");
            
            //sa
            int birinci = 0;
            Console.WriteLine(birinci);


            char karakter = '+';
            Console.WriteLine(karakter);

            string isim = "enes";
            Console.WriteLine(isim);

            //Console.WriteLine("Lütfen Adınızı Giriniz");
            //string iisim = Console.ReadLine();
            //Console.WriteLine(iisim);

            int a = 5;
            byte b = (byte)a;
            Console.WriteLine(b);

            string sayı1 = "2";
            string sayı2 = "1";

            int c = int.Parse(sayı1);
            int d = int.Parse(sayı2);
            Console.WriteLine(c+d);


            int an = 20;
            int bn = 10;
            Console.WriteLine(an+bn);

            string na = an.ToString();
            string nb = bn.ToString();
            Console.WriteLine(na+nb);


            /*
            //Mini ATM

            int Bakiye = 1000;

            //1- Bakiye görüntüleme
            //2- Para çekme
            //3- Para YAtırma
            // q ya basarsa çıkış

            Console.WriteLine("ATM ye hoşgeldiniz");
            Console.WriteLine("Yapmak istediğiniz işlemi girin");

            String secim = Console.ReadLine();

            if(secim =="1")
            {
                Console.WriteLine("BAkiyeniz"+ Bakiye);
            }
            else if(secim == "2")
            {
                Console.WriteLine("Çekmek isteddiğiniz tutarı giriniz");
                int cekşlecekTutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kalan tutar: "+ (Bakiye-cekşlecekTutar));
            }
            else if(secim == "3")
            {
                Console.WriteLine("Yatırmak istediğinşz miktarı girin");
                int yatırmaTutatarı = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yeni bakiye: "+(Bakiye+yatırmaTutatarı));
                
            }
            else if(secim == "q")
            {
                Console.WriteLine("ATM den Çıkış yapıldı");

            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir işlem girin");
            }

            */

            for(int i =1; i<11; i++)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("Amigos");    
            

            int[] sayılar = new int[3];

            sayılar[0] = 10;
            sayılar[1] = 20;
            sayılar[2] = 30;
            
            for (int i=0; i<sayılar.Length;i++)
            {
                Console.WriteLine(sayılar[i]);
            }
            //Console.Write("Durna");
            //Console.Write("Gezre");
            


            foreach (int t in sayılar)
            {
                Console.WriteLine(t);
            }



            Selamver();
            Toplama(30,1);
            CarpmaYap(10, 2, 3);
            int donenDEger = Bolme(2, 10);
            Console.WriteLine(donenDEger);






            //Kullanıcıdan aldığımız sayının karekökü 25 ten büyükmü değilmi
           /* Console.WriteLine("bir sayı giriniz");


            int alınansayı = Convert.ToInt32(Console.ReadLine());

            if (KareAl(alınansayı) > 25)
            {
                Console.WriteLine("SAyının karesi 25 ten büyük");
            }
            else
            {
                Console.WriteLine("Satının karesi 25 ten küçük");
            }

            */



            Console.ReadLine();

            

        }
        static void Selamver()
        {
            Console.WriteLine("Selamlar");
            
        }
        static void Toplama(int sayı11,int sayı12)
        {
            Console.WriteLine("Girilen sayılarn toplamı: "+(sayı11+sayı12));
            
        }
        static void CarpmaYap(int sayı1,int sayı2,int sayı3)
        {
            Console.WriteLine("3 sayının çarpımı"+ (sayı1*sayı2*sayı3));
        }
        static int Bolme(int sayı1,int sayı2)
        {
            int sonuc = sayı2 / sayı1;
            return sonuc;
        }
        static int KareAl(int a)
        {
            return a * a;
        }
    }
 }
