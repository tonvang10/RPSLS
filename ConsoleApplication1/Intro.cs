using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PaperScissorRockLizardSpock
{
    public class Intro
    {
        public string userInput, otherPlayer;

        public void Welcome()
        {
            Console.WriteLine("Hi, let's play paper, scissor, rock, lizard, spock.");
            GetRules();
            Console.ReadLine();
        }
        public void GetPlayers()
        {
            Console.WriteLine("Do you want to play against me or another player?");
            userInput = Console.ReadLine().ToLower();

            if (userInput == "you" || userInput == "against you")
            {
                Console.WriteLine("Ok great, let's play!");
                Computer computer = new Computer();
                computer.StartGame();
            }
            if (userInput == "another player")
            {
                Console.WriteLine("Okay.");
                Players users = new Players();
                users.GetName();
            }
            else
            {
                Console.WriteLine("Oops, please enter YOU or ANOTHER PLAYER");
                GetPlayers();
            }
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
