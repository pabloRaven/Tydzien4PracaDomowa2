using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa2Tydzien4
{
     class FizzBazz
    {
        
        public string FizzBuzzResult(int number)
        {

            if (number % 3 == 0 && number % 5 == 0)

            {
                return "Fiz Bazz";
            }

            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Bazz";

            }
            else
            {
                return ("Podałeś liczbe : "+ number.ToString()) ;
            }

        }
    }
}
