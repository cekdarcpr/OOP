using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Ogrenci
    {
        public string OgrenciAd;
        public string OgrenciSoyad;
        public string Sınıf;
        public int OgrenciVize;
        public int OgrenciFinal;
        public double ortalama;

        public void setOgrenciBilgi(string ogrAd, string ogrSoyAd, string ogrSınıf, int OgrVize, int ogrFinal)
        {
            if (ogrAd.Length > 0 && ogrSoyAd.Length > 0)
            {
                this.ortalama = (OgrVize * 0.4) + (ogrFinal * 0.6);

                if (ortalama >= 65)
                {
                    this.OgrenciAd = ogrAd;
                    this.OgrenciSoyad = ogrSoyAd;
                    this.Sınıf = ogrSınıf;
                    this.OgrenciVize = OgrVize;
                    this.OgrenciFinal = ogrFinal;

                    //if (ortalama >65)
                    //{
                    //    this.ortalama = (OgrVize * 0.4) + (ogrFinal * 0.6);
                    //}



                }
            }



        }
        public void getOgrenciBilgi()
        {
            if (OgrenciVize > 0 && OgrenciVize <= 100 || OgrenciFinal > 0 && OgrenciFinal >= 100)
            {
                Console.WriteLine($"Öğrenci Adı {OgrenciAd}\nÖğrenci Soyadı {OgrenciSoyad}\n Öğrenci Sınıf {Sınıf}\n Öğrenci Vize {OgrenciVize}\n Öğrenci Final {OgrenciFinal}\n Öğrenci Ortalama {ortalama} \n GEÇTİNİZ...\n\n");
            }
            else if (ortalama < 65)
            {
                Console.WriteLine($"Öğrenci Adı {OgrenciAd}\nÖğrenci Soyadı {OgrenciSoyad}\n Öğrenci Sınıf {Sınıf}\n Öğrenci Vize {OgrenciVize}\n Öğrenci Final {OgrenciFinal}\n Öğrenci Ortalama {ortalama} \n KALDINIZ...\n\n ");
            }
            else { Console.WriteLine("Bilgiler yanlış"); }
        }
    }
}
