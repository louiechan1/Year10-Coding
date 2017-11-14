using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_my_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess My Number");

            Random rnd = new Random();
            int rand = rnd.Next(1, 101);

            int guess = -1;
            int count = 0;
            while(guess != rand)
            {
                count++;
                Console.Write("guess: ");
                guess = int.Parse(Console.ReadLine());
                if(guess < rand)
                {
                    Console.WriteLine("Too Low!"); 
                }
                else if (guess>rand)
                {
                    Console.WriteLine("Too High!");
                }
                else
                {
                    Console.WriteLine($"You Guessed My Number, it took {count} tries!");
                    Console.ReadKey(); 
                }
            }
        }
    }
}
