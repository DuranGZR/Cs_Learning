using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    internal class Calısan
    {
        private int id;
        private string isim;
        private string soyisim;

        public Calısan(int _id, string _isim, string _soyisim)
        {
            this.id = _id;
            this.isim = _isim;
            this.soyisim = _soyisim;
        }

        public int getId() { return id; }
        public void setId(int id) { this.id = id; }


        public string getIsim() { return isim; }
        public void setIsim(string isim) { this.isim = isim; }


        public string getSoyisim() { return soyisim; }
        public void setSoyisim( string soyisim) { this.soyisim = soyisim; }


        public void BilgileriGorter()
        {
            Console.WriteLine("id: "+ this.id);
            Console.WriteLine("isim: "+ this.isim);
            Console.WriteLine("soyisim: "+ this.soyisim);
        }

    }
}
