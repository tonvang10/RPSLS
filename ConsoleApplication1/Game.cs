using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorRockLizardSpock

{
    public class Game
    {
        public string playerOne;
        public string playerTwo;
        public string userInput;


       

        public void DecidePlayers()
        {
            Console.WriteLine("Do you want to play against computer or another player?");
            userInput = Console.ReadLine().ToLower();

            if (userInput == "computer")
            {
                Console.WriteLine("Ok great, good luck!");
                Computer computer = new Computer();
                computer.StartGameWithComputer();
            }
            else if (userInput == "another player")
            {
                Console.WriteLine("Okay.");
                
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


