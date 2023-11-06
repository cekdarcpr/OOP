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

            Console.ReadKey();
        }
    }
}