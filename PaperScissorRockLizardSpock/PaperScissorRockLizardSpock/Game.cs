using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorRockLizardSpock
{
    class Game
    {
        Player players;
        public Game()
        {
            players = new Player();
        }
        public void StartGame()
        {
            Welcome();
            ShowRules();
        }
        //public bool AskPlayAgain(string answer)
        //{
        //    Console.WriteLine("Would you like to play again?  (y|n)");
        //    answer = Console.ReadLine().ToLower();
        //    if (answer == "y")
        //    {
        //    }
        //    if (answer == "n")
        //    {
        //        Console.WriteLine("THANKS FOR PLAYING!");
        //    }
        //    return false;
        //}
        public void ShowRules()
        {
            Console.WriteLine("\nRules for Paper, Scissor, Rock, Lizard, Spock:");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("Rock crushes Scissors\n");
            Console.WriteLine("First to get 3 wins, WINS!");
            Console.WriteLine("Press ENTER to begin");
        }
        public void Welcome()
        {
            Console.WriteLine("Hi, let's play paper, scissor, rock, lizard, spock.");
        }
    }
}
