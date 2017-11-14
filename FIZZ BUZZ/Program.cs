using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIZZ_BUZZ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop 100 Times
            for(int i = 1; i <= 100; i++)
            {
                // If divisible by both 3 and 5
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                // If divisible by 3
                else if(i%3==0)
                {
                    Console.WriteLine("FIZZ"); 
                }
                // If divisible by 5
                else if(i%5==0)
                {
                    Console.WriteLine("BUZZ"); 
                }
                // Otherwie, just print the number
                else
                {
                    Console.WriteLine(i); 
                }
               
            }
            //Wait
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); 

        }
    }
}
