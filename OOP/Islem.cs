using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Islem
    {
        public double Sayi;
        public double Sayi2;
        public double Sonuc;
        public char islem;

       public void setSonuc()
        {
            switch (islem)
            {
                case '+':
                    Sonuc = Sayi + Sayi2;
                    break;
                case '-':
                    Sonuc = Sayi - Sayi2;
                    break;
                case '*':
                    Sonuc = Sayi * Sayi2;
                    break;
                case '/':
                    

                    if (Sayi != 0 && Sayi2 != 0)
                    {
                        Sonuc = Sayi / Sayi2;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz İşlem...");
                       
                    }

                    break;
                default:
                    break;
            }


            
        }
        public double getSonuc()
        {
            return Sonuc;
        }

    }
}
