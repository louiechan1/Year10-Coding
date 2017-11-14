using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_8_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            playGame();
        }

        private static void playGame()
        {
            string[] answer = { "no", "yes", "idk", "possibly", "that could be true", "Nah probably not", "lol no" };
            Console.Write("Ask me a yes or no question (or type 'exit'):");
            string choice = Console.ReadLine();
            if (choice != "exit")
            {
                Random rnd = new Random();
                Console.WriteLine(answer[rnd.Next(0, 6)]);              
                playGame();
            }
        }
    }
}
