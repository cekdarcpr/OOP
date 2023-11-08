using System.Threading.Channels;

namespace WorkOut01
{
    internal class Program
    {
        internal class Staff
        {
            
            public int kenar { get; set; }
            public int kenar2 { get; set; }
            public double yarıcapı { get; set; }

            public  double cember
            {
                get
                {
                    return  Math.PI * Math.Pow(yarıcapı,2) ;
                }
            }
        }

        internal class Worker : Staff
        {
            public int dikdortgen
            {
                get
                {
                    return kenar * kenar2;
                }
            }
        }

        internal class Manager : Staff
        {
            public int kare
            {
                get
                {
                    return kenar * kenar2 ;
                }
            }
        }

    

        static void Main(string[] args)
        {


            Staff cember = new Staff();
            cember.yarıcapı = 5 ;
          

            Worker dikdortgen = new Worker();
            dikdortgen.kenar = 8;
            dikdortgen.kenar2 = 11;
           

            Manager kare = new Manager();
            kare.kenar = 10;
            kare.kenar2 = 10;

           

            Console.WriteLine($"Cemberin Yarıçapı {cember.yarıcapı} Cemberin Alanı {cember.cember}");
            Console.WriteLine(dikdortgen.dikdortgen);
            Console.WriteLine(kare.kare);
        


        }
    }
}