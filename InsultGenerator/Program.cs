using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string name = getname();

            GenerateInsult(name, rnd);
             
        }
        private static string getname()
        {
            Console.WriteLine("Welcome to the insult generator you idiot. What is your name?");
            return Console.ReadLine();
        }
        private static void GenerateInsult(string name, Random rnd)
        {
            Console.WriteLine(name + ", you are" + getadjective(rnd) + getcompoundadjective(rnd) + getobject(rnd));
            Menu(name, rnd);
        }
        private static void Menu(string name, Random rnd)
        {
            Console.Write("Would you like another insult? y/n: ");
            if(Console.ReadLine() == "y")
            {
                GenerateInsult(name, rnd);
            }
        }
        private static string getadjective(Random rnd)
        {
            string[] adjectives = { " a stupid " , " an ignorant " , " an idiotic " , " a twatish " , " a lost " , " a shitty " , " a fugly " , " a disgusting " , " a disgraceful " };
            return adjectives[rnd.Next(8)];
        }
        private static string getcompoundadjective(Random rnd)
        {
            string[] compoundadjectives = { "drop-kick", "two-faced", "back-stabbing", "crack-head", "lanky-bodied " };
            return compoundadjectives[rnd.Next(4)];
        }
        private static string getobject(Random rnd)
        {
            string[] objects = { " flop ", " pussy ", " muppet ", " walrus ", " vegan ", " pig ", " bastard ", " duck " };
            return objects[rnd.Next(7)]; 
        }
    }
}
