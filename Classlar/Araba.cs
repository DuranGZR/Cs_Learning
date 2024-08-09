using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    public class Araba
    {
        public int kapiSayisi;
        public string arabaModel;
        public string arabaRengi;

        public Araba(int _kapiSayisi,string _arabaModel, string _arabaRengi)
        {
            kapiSayisi = _kapiSayisi;
            arabaModel = _arabaModel;
            arabaRengi = _arabaRengi;
            Console.WriteLine("1");

        }
        public void MotorCalistir()
        {
            Console.WriteLine("Motor çalıştırılıyor...");
        }

        public void KapilariKilitle()
        {
            Console.WriteLine("Kapılar kilitleniyor...");
        }
    }
}
