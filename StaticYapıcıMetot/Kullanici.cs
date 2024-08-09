using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapıcıMetot
{
    internal class Kullanici
    {

        private int KullanıcıID { get; set; }
        private string isim { get; set; }
        private string soyisim { get; set; }
        private static int maas { get; set; }


        static Kullanici()
        {
            maas = 2500;
        }

        public Kullanici(int _kullanıcıID,string _isim,string _soyisim)
        {
            KullanıcıID = _kullanıcıID;
            isim = _isim;   
            soyisim = _soyisim;
            
        }

        public void KullaniciBligileriGoster()
        {
            Console.WriteLine("Kullanıcı Bilgileri :");
            Console.WriteLine("İD: "+KullanıcıID);
            Console.WriteLine("İsmi: "+isim);
            Console.WriteLine("Soyisim: "+ soyisim);
            Console.WriteLine("Maaş: "+maas );
        }

        public void zamYap(int zamMiktari)
        {
            Console.WriteLine("zAM yapılıyor....");
            Console.WriteLine("Yeni maaş : "+ (maas+zamMiktari);
        }

    }
}
