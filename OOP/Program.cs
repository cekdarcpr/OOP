using System.IO.Pipes;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

           Personel personel = new Personel();
           Personel personel2 = new Personel(); 
           Personel personel3 = new Personel();   
           Personel personel4 = new Personel(); 
           Personel personel5 = new Personel();
           Personel personel6 = new Personel();    
           Personel personel7 = new Personel();
           Personel personel8 = new Personel();
           Personel personel9 = new Personel();    
           Personel personel10 = new Personel();

           int maasilk = 10000;
           int maasSon = 20000;

           personel.setPersonelBilgi("Çekdar", "ÇAPAR", new Random().Next(maasilk,maasSon));
           personel2.setPersonelBilgi("Ahmet", "GÖKÇAY", new Random().Next(maasilk, maasSon));
           personel3.setPersonelBilgi("Tarık", "ZİYA", new Random().Next(maasilk, maasSon));
           personel4.setPersonelBilgi("Öykü", "YURDAGÜL", new Random().Next(maasilk, maasSon));
           personel5.setPersonelBilgi("Yusuf", "YILMAZ", new Random().Next(maasilk, maasSon));
           personel6.setPersonelBilgi("Ahmet", "CEYLAN", new Random().Next(maasilk, maasSon));
           personel7.setPersonelBilgi("Umut", "ÖZTÜRK", new Random().Next(maasilk, maasSon));
           personel8.setPersonelBilgi("Hazal", "KUTLU", new Random().Next(maasilk, maasSon));
           personel9.setPersonelBilgi("Emine", "MUTLU", new Random().Next(maasilk, maasSon));
           personel10.setPersonelBilgi("Mehmet", "MUTSUZ", new Random().Next(maasilk, maasSon));

           */

            /* ------------->

            Ogrenci ogrenci = new Ogrenci();
            Ogrenci ogrenci1 = new Ogrenci();
            Ogrenci ogrenci2 = new Ogrenci();
            Ogrenci ogrenci3 = new Ogrenci();
            Ogrenci ogrenci4 = new Ogrenci();
            Ogrenci ogrenci5 = new Ogrenci();


            ogrenci.setOgrenciBilgi("Çekdar", "Çapar", "9/b", 15, 60);
            ogrenci1.setOgrenciBilgi("Ahmet", "Çapar", "9/b", 60, 60);
            ogrenci2.setOgrenciBilgi("Umut", "Çapar", "9/b", 75, 90);
            ogrenci3.setOgrenciBilgi("Öykü", "Çapar", "9/b", 95, 85);
            ogrenci4.setOgrenciBilgi("Mehmet", "Çapar", "9/b", 95, 55);
            ogrenci5.setOgrenciBilgi("Çekooo", "Çapar", "9/b", 45, 100);


            ogrenci.getOgrenciBilgi();
            ogrenci1.getOgrenciBilgi();
            ogrenci2.getOgrenciBilgi();
            ogrenci3.getOgrenciBilgi();
            ogrenci4.getOgrenciBilgi();
            ogrenci5.getOgrenciBilgi();

            <----------         */


            /*

            BookStore bookStore = new BookStore();
            BookStore bookStore1 = new BookStore();
            BookStore bookStore2 = new BookStore();
            BookStore bookStore3 = new BookStore();
            BookStore bookStore4 = new BookStore();

            bookStore.setBook(1, "Harry Potter", "Çekdar Çapar");
            bookStore1.setBook(2, "Şeker Portakal", "Öykü Yurdagül");
            bookStore2.setBook(3, "Başlangıç", "Dan Brown");
            bookStore3.setBook(4, "Titanic", "Ahmet Gökçay");
            bookStore4.setBook(5, "Açlık Oyunları", "Mauro Icardi");



            Console.Write("1 ile 5 arası bir kitap ID'si giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine()); 

            while (true)
            {
                if (sayi == 1)
                {
                    Console.WriteLine(bookStore.getBook());
                    break;

                }
                else if (sayi == 2)
                {
                    Console.WriteLine(bookStore1.getBook());
                    break;
                }
                else if (sayi == 3)
                {
                    Console.WriteLine(bookStore2.getBook());
                    break;
                }
                else if (sayi == 4)
                {
                    Console.WriteLine(bookStore3.getBook());
                    break;
                }
                else if (sayi == 5)
                {
                    Console.WriteLine(bookStore4.getBook());
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen 1 ile 5 arası sayı giriniz...");
                    break;
                }
            }
              */


            /*

            Islem islem = new Islem();

            Console.WriteLine("1.SAYINIZI GİRİNİZ : ");
            islem.Sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayınızı Giriniz : ");
            islem.Sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşlem Kodu (+,-,*,/)");
            islem.islem = Convert.ToChar(Console.ReadLine());

            islem.setSonuc();

            Console.WriteLine("Sonuc : {0}",islem.getSonuc());

            */
            
            

            Console.ReadKey();
        }
    }
}