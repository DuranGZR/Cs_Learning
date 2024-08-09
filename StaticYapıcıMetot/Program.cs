using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StaticYapıcıMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kullanici K1 = new Kullanici(1,"duran","gezer");

            K1.KullaniciBligileriGoster();

            K1.zamYap(500); 
        }
    }
}
