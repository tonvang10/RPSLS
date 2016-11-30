using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorRockLizardSpock

{
    public class Game
    {

        public string answerToPlayAgain;

        public void Welcome()
        {
            Console.WriteLine("Hi, let's play paper, scissor, rock, lizard, spock.");
            GetRules();
            Console.ReadLine();
        }

        public string PlayAgain()
        {
            Console.WriteLine("Would you like to play again?  (y|n)");
            answerToPlayAgain = Console.ReadLine().ToLower();
            if (answerToPlayAgain == "y")
            {
                Players playagain = new Players();
                playagain.DecidePlayers();
            }
            if (answerToPlayAgain == "n")
            {
                Console.WriteLine("THANKS FOR PLAYING NICE DAY!");
            }
            return answerToPlayAgain;
        }

        public void GetRules()
        {
            Console.WriteLine();
            Console.WriteLine("Rules for Paper, Scissor, Rock, Lizard, Spock:");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine();
            Console.WriteLine("First to get 3 wins, WINS!");
            Console.WriteLine("Press ENTER to begin");
        }


    }
}

//Scissors cuts Paper
//Scissors decapitates Lizard

//Rock crushes Lizard
//Rock crushes Scissors

//Lizard poisons Spock
//Lizard eats Paper

//Spock smashes Scissors
//Spock vaporizes Rock

//Paper covers Rock
//Paper disproves Spock


