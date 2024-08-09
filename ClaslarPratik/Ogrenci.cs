using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaslarPratik
{
    internal class Ogrenci
    {
        private int ogrno;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okul;


        public Ogrenci(int _ogrno, string _isim,string _soyisim , int _vize1, int _vize2, int _final,string _okul)
        {
            ogrno = _ogrno;
            isim = _isim;       
            soyisim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okul = _okul;

        }

        public void OgrenciBilgileriGoster()
        {
            Console.WriteLine("okul no: "+ogrno);
            Console.WriteLine("isim: " + isim);
            Console.WriteLine("soyisim: " + soyisim);
            Console.WriteLine("vize1: " + vize1);
            Console.WriteLine("vize2: " + vize2);
            Console.WriteLine("final: " + final);
            Console.WriteLine("okul ismi: " + okul);
        }

        public double OgrenciNotuBul()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;

                return ortalama;

        }

        public void OkulaGetir()
        {
            Console.WriteLine("Öğrencinin okulu: "+okul);
        }


    }
}
