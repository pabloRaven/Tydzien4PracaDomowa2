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
                var fizBazz = new FizzBazz();

                Console.WriteLine("Podaj Liczbę całkowitą : ");
                var number = int.Parse(Console.ReadLine());
                var result = fizBazz.FizzBuzzResult(number);
                Console.WriteLine(result);

            }
            catch (Exception)
            {
                Console.WriteLine("Podane dane nie są prawidłowe");
            }
            
        }

        



        }
        

    }

