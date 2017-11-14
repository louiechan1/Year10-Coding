using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age");
            int age = int.Parse(Console.ReadLine()); 

            if (age < 0)
            {
                Console.WriteLine("you are a mistake");
            }
            else if (age < 13)
            {
                Console.WriteLine("you are a child");
            }
            else if (age < 20)
            {
                Console.WriteLine("you are a teenager");
            }
            else if (age < 100)
            {
                Console.WriteLine("you are a adult"); 
            }
            else
            {
                Console.WriteLine("you are ancient");
                     
            }



            Console.ReadKey();
        }
    }
}
