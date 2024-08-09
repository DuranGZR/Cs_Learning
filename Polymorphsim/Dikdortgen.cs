using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    internal class Dikdortgen : Sekil
    {

        public int uzunKenar { get; set; }
        public int kisaKenar { get; set; }
        public Dikdortgen(string isim, int uzunkenar,int kisakenar) :base( isim)
        {
            this.uzunKenar = uzunkenar;
            this.kisaKenar = kisakenar;
        }

        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim()+" nin alanı: "+(uzunKenar*kisaKenar));
        }

        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine("Şeklin ismi: "+getIsim());
            Console.WriteLine(getIsim()+" nin kısa kenarı: "+ this.kisaKenar);
            Console.WriteLine(getIsim()+" nin uzun kenarı: "+this.uzunKenar);
        }
    }
}
