using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCK_PAPER_SCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            int userScore = 0;
            int computerScore = 0;
            bool repeat = true;

            while(repeat== true)
            {
                string result = "draw";
                PrintScore(ref userScore, ref computerScore);
                string userChoice = userTurn();
                string computerChoice = ComputerTurn();
                result = DetermineWinner(userChoice,computerChoice);
                GiveFeedback(result, userChoice, computerChoice);
                updateScores(result, ref userScore, ref computerScore);
                repeat = PlayAgain();
            }
            
        }

        private static bool PlayAgain()
        {
            Console.WriteLine("Do you want to play again? y/n");
            string choice = Console.ReadLine(). ToLower();
            if (choice =="y" || choice =="yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void updateScores(string result, ref int userScore, ref int computerScore)
        {
            if(result == "Win")
            {
                userScore++;
            }
            else if(result == "Lose")
            {
                computerScore++;
            }
        }

        private static void GiveFeedback(string result, string userChoice, string computerChoice)
        {
            Console.WriteLine(result + "! The computer chose " + computerChoice + " and you chose " + userChoice);
        }

        private static string DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == "Rock")
            {
                if(computerChoice == "Rock")
                {
                    return "Draw";
                }
                else if(computerChoice == "Paper")
                {
                    return "Lose";
                }
                else
                {
                    return "Win";
                }
            }
            else if (userChoice == "Paper")
            {
                if (computerChoice == "Rock")
                {
                    return "Win";
                }
                else if (computerChoice == "Paper")
                {
                    return "Draw";
                }
                else
                {
                    return "Lose";
                }
            }
            else 
            {
                if (computerChoice == "Rock")
                {
                    return "Lose";
                }
                else if (computerChoice == "Paper")
                {
                    return "Win";
                }
                else
                {
                    return "Draw";
                }
            }
        }

        private static string ComputerTurn()
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, 4);
            if (choice == 1)
            {
                return "rock";
            }
            else if (choice == 2)
            {
                return "paper";           
            }
            else
            {
                return "scissors";
            }
        }

        private static string userTurn()
        {
            string choice = "";
            //while (choice != "1" && choice != "2" && choice != "3")
            //{
                Console.WriteLine("1:rock");
                Console.WriteLine("2:paper");
                Console.WriteLine("3:scissors");
                Console.Write("Your Choice: ");
                choice = Console.ReadLine();
            //}     
            if (choice == "1")
            {
                return "rock";
            }
            else if (choice == "2")
            {
                return "paper";
            }
            else if (choice == "3")
            {
                return "scissors";
            }
            else
            {
                return ComputerTurn();
            }
        }

        private static void PrintScore(ref int userScore, ref int computerScore)
        {
            Console.Clear();
            Console.WriteLine("User: " + userScore + "   Computer: " + computerScore);
        }
    }
}
