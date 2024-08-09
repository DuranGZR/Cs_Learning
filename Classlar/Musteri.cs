using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    internal class Musteri
    {
        public string isim;
        public string soyisim;
        public int maasDegeri;
        public string cinsiyet;
        private int yas;

        public Musteri()
        {
            Console.WriteLine("müşteri sınıfının yapıcı metodu çalıştı");
        }

        public void MusteriBilgileriGoster()
        {
            Console.WriteLine("isim: "+isim);
            Console.WriteLine("soyisim: "+ soyisim);
            Console.WriteLine("maaş: "+maasDegeri);
            Console.WriteLine("cinsiyet: "+cinsiyet);
            Console.WriteLine("yaş: "+yas);
        }

        private void isimsoysisimyazdir(string musterisim, string musterisoyisim)
        {
            Console.WriteLine("Müşterinin isim ve soyismi: "+ musterisim+" "+ musterisoyisim);
        }
    }
}
