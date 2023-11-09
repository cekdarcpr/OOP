using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class Employess
    {
        private string Name, surName, title;
        private double salary; // Maaş
        private int annualLeave; //Yıllık İzni 



        public void getInfo()
        {
            if (annualLeave > 0)
            {
                Console.WriteLine($"Abstract Company Employee\n\n İsim : {Name}\nSoyisim : {surName}\nÜnvan : {title}\nMaaş : {salary}\nYıllık İzin : {annualLeave}\n\n");
            }
            else
            {
                Console.WriteLine("Çalışan Bulunamadı..!");
            }
        }
        public void setInfo(string name,string SurName,double Sallary)
        {
            if (name.Length >= 3 && SurName.Length >= 2)
            {
                if (Sallary >= 8500)
                {
                    this.Name = name;
                    this.surName = SurName;
                    this.salary = Sallary;

                    if (salary >=8500 && salary <=12000)
                    {
                        this.title = "Deneyimli " + title;
                        this.annualLeave = 20;
                    }
                    else if (salary >= 12001 && salary <= 15000)
                    {
                        this.title = "Kıdemli " + title;
                        this.annualLeave = 24;
                    }
                    else if (salary >= 15001)
                    {
                        this.title = "Uzman " + title;
                        this.annualLeave = 30;
                    }
                    else
                    {
                        
                        this.annualLeave = 14;
                    }
                }
                else
                {
                    Console.WriteLine("ERROR : Çalışanınızın Maaşını Kontrol Ediniz En az 8500 olmalıdır...");
                }
            }
            else
            {
                Console.WriteLine("ERROR : Çalışanınızın isim soyisim kısmı gerekli kıriterleri sağlamıyor. Kontrol ediniz...");
            }
        }

        public double getSallary()
        {
            return salary;
        }

        public void setSallary(double Salary)
        {
            this.salary =Salary;
        }

        // Ünvan bilgilerine erişecek 'Get,Set' metodları ...

        public void setTitle(string Title)
        {
            this.title =Title;  
        }
        // Her nesne için ÖZEL zam seçenekleri olabileceği için Abstarct metotlar tanımlanacak... 'Polymorphism' tekniği uygulanacak
        public abstract void doRaise(); // Zam metodu

        public abstract void doRaise(double prmRaise); // zam + Prim  


    }
}
