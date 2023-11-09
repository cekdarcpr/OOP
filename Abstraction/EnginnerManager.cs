using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class EnginnerManager : Employess
    {
        public EnginnerManager() 
        {
            setTitle("Mühendis");
        }

        public override void doRaise()
        {
            double salary = getSallary(); // maaşını öğrendiğin komut

            double raise = salary + 2500; // Zamlı maaş komutu

            setSallary(raise);
        }

        public override void doRaise(double prmRaise)
        {
            double salary = getSallary();

            double raise = salary + (salary * prmRaise / 100) + (salary * 2); // (double prmRaise)'a girilen % zam oranı güncelleyecek

            setSallary(salary);
        }
    }
}
