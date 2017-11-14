using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickADoor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick A Door");
            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                Console.WriteLine("Behind door 1 is a wild chav");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Behind door 2 is a crackhead");
            
            }
            else if (choice == "3")
            {
                Console.WriteLine("Behind door 3 is a Meme");
            }


            Console.ReadKey();
        
        }
    }
}
