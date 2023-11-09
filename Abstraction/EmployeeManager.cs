using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{

    internal class EmployeeManager : Employess
    {
        // Constructor 

        public EmployeeManager() 
        {
            //İlk yaratıldığı anda default bazı tanımlamalar yapabilmek için...
            setTitle("Beden İşçisi");

        }    


        public override void doRaise() //Sadece Zam...
        {
            double salary = getSallary(); // maaşını öğrendiğin komut
            
            double raise = salary + 500; // Zamlı maaş komutu

            setSallary(raise);

            
        }

        public override void doRaise(double prmRaise) //  Zam + Prim
        {
            double salary = getSallary();

            double raise = salary + (salary * prmRaise/100); // (double prmRaise)'a girilen % zam oranı güncelleyecek

            setSallary(salary);
            
        }


    }
}
