using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baby_Black_Jack
{
    class Program
    {
        static void Main(string[] args)
        {
            float money = 10;
            PlayGame(ref money);
        }

        private static void PlayGame(ref float money)
        {
            nsole.Clear();
            float BetAmount = MakeBet(ref money);
            Random rnd = new Random();
            int PlayerTotal = DealCards(rnd, "You");
            int DealerTotal = DealCards(rnd, "The dealer");
            bool PlayerWins = DetermineWinner(PlayerTotal, DealerTotal);
            PayOut(PlayerWins, BetAmount, ref money);
            Menu(ref money);
        }

        private static float MakeBet(ref float money)
        {
            float money = 0;
            bool validbet = false);

            Console.Write("Enter your bet. You have $" + money);

            while (validbet != true)
            {
                validbet = float.TryParse(Console.ReadLine(), out BetAmount);
                if (BetAmount > money)
                {
                    Console.WriteLine("sorry, you do not have enough money. Try again");
                    validbet = false;
                }
                else if (BetAmount < 0)
                {
                    Console.WriteLine("Sorry, you cannot bet a negative amount. Try agin.");
                    validbet = false;
                }
            }

            money = money - BetAmount;
            return BetAmount;

        }

        private static int DealCards(Random rnd, string player)
        {
            int card1 = rnd.Next(11);
            int card2 = rnd.Next(11);
            int total = card1 + card2;
            Console.WriteLine(player + " drew " + card1 + " and " + card2 + " for a total of " + total);
            return total;
        }

        private static bool DetermineWinner(int player, int dealer)
        {
            if (player > dealer)
            {
                Console.WriteLine("You Win!");
                return true;
            }
            else if (player < dealer)
            {
                Console.WriteLine9"You Lose!");
                return false;
            }
            else
            {
                Console.WriteLine("Its a Draw! Dealer still Wins!");
                return false;
            }
        }

        private static void PayOut(bool PlayerWins, float BetAmount, ref float money)
        {
            if (PlayerWins)
            {
                money = money + (BetAmount * 2);
            }
        }
    
    }
}
