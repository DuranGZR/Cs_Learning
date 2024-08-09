using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationÖrnek
{
    public class Personel
    {

        private string tcno;
        public string TCNO 
        {
            get
            {
                if (tcno != null)
                {
                    return tcno.Substring(0, 5);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                bool kontrol = false;   
                if(value.Length == 11)
                {
                    for (int i = 0;i<value.Length;i++)
                    {
                        bool sayıMi = char.IsNumber(value[i]);

                        if (sayıMi)
                        {

                        }
                        else
                        {
                            kontrol = true;
                        }
                    }
                    if (kontrol) {
                        Console.WriteLine("lütfen geçerli bir tc no giriniz.");
                    }
                    else
                    {
                        tcno = value;
                    }
                }
                else
                {
                    Console.WriteLine("TC no 11 karakter olmalı");
                }
            }
        }
    }
}
