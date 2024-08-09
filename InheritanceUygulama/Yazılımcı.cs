using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    internal class Yazılımcı : Calısan
    {

        private string diller;
        public Yazılımcı(int id,string isim, string soyisim,string diller) : base(id,isim,soyisim)
        {
                this.diller = diller;
        }

        public void formatAt(string işletimSistemi)
        {
            Console.WriteLine(getIsim()+"şuanda"+" "+işletimSistemi+" işletim sistemine format atıyor...");
        }
    }
}
