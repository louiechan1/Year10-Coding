using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            while (choice != "4")
            {
                //menu
                Console.Clear();
                Console.WriteLine("Choose an Option:");
                Console.WriteLine("1. Area of a Rectangle");
                Console.WriteLine("2. Area of a Triangle");
                Console.WriteLine("3. Area of a Circle");
                Console.WriteLine("4. Exit");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Rectangle
                    Console.WriteLine();
                    Console.Write("Width: ");
                    float Width = float.Parse(Console.ReadLine());
                    Console.Write("Length: ");
                    float Length = float.Parse(Console.ReadLine());
                    Console.WriteLine("Area: " + (Width * Length));
                }
                else if (choice == "2")
                {
                    // Triangle
                    Console.WriteLine();
                    Console.Write("Base: ");
                    float Width = float.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    float Height = float.Parse (Console.ReadLine());
                    Console.WriteLine("Area: " + (0.5 * Width * Height));

                }
                else if (choice == "3")
                {
                    // Circle
                    Console.WriteLine();
                    Console.Write("Radius: ");
                    float Radius = float.Parse(Console.ReadLine());
                    Console.WriteLine("Area: " + (Math.PI * Radius * Radius));

                }
                else if (choice == "4")
                {
                    break;
                }
                // Wait
                Console.WriteLine();
                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
