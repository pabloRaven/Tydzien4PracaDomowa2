using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa2Tydzien4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj Liczbę całkowitą : ");
                var number = int.Parse(Console.ReadLine());

                if (number % 3 == 0 && number % 5 == 0 )
                    Console.WriteLine("Fiz Bazz");                
                else if (number % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (number % 5 == 0)
                    Console.WriteLine("Bazz");
                else
                    Console.WriteLine("Podana liczba to :  " + number);
                           
                
            }
            catch (Exception)
            {
                Console.WriteLine("Podane dane nie są prawidłowe");
            }
            
        }
        

    }
}
