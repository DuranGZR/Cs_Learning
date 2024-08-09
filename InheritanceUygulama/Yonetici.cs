using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    internal class Yonetici : Calısan
    {
        private int SorumluKisiSayisi;
        public Yonetici(int id,string isim,string soyisim, int sorumluKisiSayisi) : base(id,isim,soyisim)
        {
            this.SorumluKisiSayisi = sorumluKisiSayisi;
        }

        public void zamYap(int zamMiktari)
        {
            Console.WriteLine(getIsim()+" "+zamMiktari+"TL çalışanlara zam yapıyor...");
        }
    }
}
