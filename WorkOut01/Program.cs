using System.Threading.Channels;

namespace WorkOut01
{
    internal class AlanHsplm
    {
        public int Kenar1 { get; set; }
        public int Kenar2 { get; set; }

        public double YariCap { get; set; }

        public double Cember
        {
            get
            {

                return Math.PI * Math.Pow(YariCap, 2);
            }
        }

    }

    internal class DikdörtgenHsplm : AlanHsplm
    {
        public int dikdörtgen
        {
            get
            {
                return Kenar1 * Kenar2;
            }
        }
    }

    internal class KareHsplm : AlanHsplm
    {
        public int kare
        {
            get
            {
                return Kenar1 * Kenar2;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {



            while (true)
            {
                Console.WriteLine("Hangi Alan Hesabı İstediğinizi Seçin :");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    AlanHsplm alanHsplm = new AlanHsplm();
                    Console.WriteLine("Lütfen Yarıçapı giriniz : ");
                    alanHsplm.YariCap = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Cemberin Yarıçapı {alanHsplm.YariCap} Cemberin Alanı {alanHsplm.Cember}");
                }
                else if (secim == 2)
                {
                    DikdörtgenHsplm dikdörtgenHsplm = new DikdörtgenHsplm();
                    Console.WriteLine("1. Kenarı giriniz : ");
                    dikdörtgenHsplm.Kenar1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2. Kenarı giriniz : ");
                    dikdörtgenHsplm.Kenar2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($" Dikdörtgenin Alanı : {dikdörtgenHsplm.dikdörtgen}");
                }
                else if (secim == 3)
                {
                    KareHsplm kareHsplm = new KareHsplm();
                    Console.WriteLine("1. Kenarı giriniz : ");
                    kareHsplm.Kenar1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2. Kenarı giriniz : ");
                    kareHsplm.Kenar2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($" Kare Alanı : {kareHsplm.kare}");

                }
                else
                {
                    Console.WriteLine("Hatalı seçim...");
                }
            }


            //Console.WriteLine("Lütfen Yarıçapı giriniz : ");
            //alanHsplm.YariCap = Convert.ToDouble(Console.ReadLine());

            //DikdörtgenHsplm dikdörtgenHsplm = new DikdörtgenHsplm();
            //Console.WriteLine("1. Kenarı giriniz : ");
            //dikdörtgenHsplm.Kenar1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2. Kenarı giriniz : ");
            //dikdörtgenHsplm.Kenar2 = Convert.ToInt32(Console.ReadLine());

            //KareHsplm kareHsplm = new KareHsplm();
            //Console.WriteLine("1. Kenarı giriniz : ");
            //kareHsplm.Kenar1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2. Kenarı giriniz : ");
            //kareHsplm.Kenar2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Cemberin Yarıçapı {alanHsplm.YariCap} Cemberin Alanı {alanHsplm.Cember}");

            

            Console.ReadKey();
        }
    }
}