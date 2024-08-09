using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKullanimi
{
    internal class Musteri : IMusteri
    {
        public void ekle()
        {
            Console.WriteLine("Müşteri eklendi");
        }

        public void getir()
        {
            Console.WriteLine("Müşteri getirildi");
        }

        public void guncelle()
        {
            Console.WriteLine("Müşteri güincellendi");
        }

        public void sil()
        {
            Console.WriteLine("Müşteri silindi");
        }
    }
}
