using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    internal class Ucgen : Sekil
    {

        public int yukseklik { get; set; }

        public int tabanAlanı { get; set; }
        public Ucgen(string isim,int Yukseklik, int Taban) :base(isim)
        {
            this.tabanAlanı = Taban;
            this.yukseklik = Yukseklik;
        }

        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim()+ " nin alanı: "+((this.tabanAlanı*this.yukseklik)/2));
        }

        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine("Şeklin ismi: "+getIsim());
            Console.WriteLine(getIsim()+" nin tabanı: "+this.tabanAlanı);
            Console.WriteLine(getIsim()+" nin yüksekliği: "+this.yukseklik);
        }
    }
}
