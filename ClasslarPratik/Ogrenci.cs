using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaslarPratik
{
    public class Ogrenci
    {
        private string ogrno;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okul;




        public Ogrenci(string _ogrno, string _isim, string _soyisim, int _vize1, int _vize2, int _final, string _okul)
        {


        }

        public void OgrenciBilgileriGoster()
        {
            Console.WriteLine("isim : "+isim);
            Console.WriteLine("soyisim : " + soyisim);
            Console.WriteLine("ogrno : " + ogrno);
            Console.WriteLine("vize1 : " + vize1);
            Console.WriteLine("vize2 : " + vize2);
            Console.WriteLine("final : " + final);
            Console.WriteLine("okul : " + okul);
        }


        public double OgrenciNotuBul()
        {
            double ortlama = vize1*0.2 + vize2*0.2 + final*0.6
                return ortlama;
        }


        public void OkulGetir()
        {
            Console.WriteLine("Öğrenci okul adı: "+okul);
        }
    }
}


