using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorRockLizardSpock

{
    public class Game
    {
        public string userInput;
        public string answerToPlayAgain;


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
        public void DecidePlayers()
        {
            Console.WriteLine("Do you want to play against computer or another player?");
            userInput = Console.ReadLine().ToLower();

            if (userInput == "computer")
            {
                Console.WriteLine("Ok great, good luck!");
                Players players = new Players();
                players.GetFirstPlayerName();
                Computer computer = new Computer();
                computer.StartGameWithComputer();
            }
            else if (userInput == "another player")
            {
                Console.WriteLine("Okay.");
                Players players = new Players();
                players.GetFirstPlayerName();
                players.GetSecondPlayerName();
                Human humanVsHuman = new Human();
                humanVsHuman.StartPlayerVsPlayer();
            }
            else
            {
                Console.WriteLine("Oops, please enter COMPUTER or ANOTHER PLAYER");
                DecidePlayers();
            }
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


