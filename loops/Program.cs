using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter a number");
            Console.BackgroundColor = ConsoleColor.DarkBlue; 
            int number = int.Parse(Console.ReadLine());
            Console.BackgroundColor = ConsoleColor.Black;   
            
            for(int x = 1; x <= number; x++)
            {
                Console.WriteLine(x);   
            }

            Console.ReadKey();

            Console.WriteLine("start");
            Console.ReadLine();

            int number2 = 1;

            while(number2 <= 10)
            {
                Console.WriteLine(number2);
                number2++;
            }

            Console.ReadLine();

        }  

        
    }
}
