using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorRockLizardSpock
{
        public class Computer : Game

        {
        string move, answerToPlayAgain;
       
        int lose = 1;
        int tie = 1;
        int game = 1;

        public void PlayAgain()
        {
            Console.WriteLine("Would you like to play again?  (y|n)");
            answerToPlayAgain = Console.ReadLine().ToLower();
            if (answerToPlayAgain == "y")
            {
                StartGameWithComputer();
            }
        }
        public void StartGameWithComputer()
            {
              
            
                Console.WriteLine();
                Console.WriteLine("Paper, Scissor, Rock, Lizard, Spock. Which do you choose {0}?", playerOne);
                move = Console.ReadLine().ToLower();

            int win = 1;
            while (win > 3)
            {
 
                switch (move)
                {
                    case "scissor":
                        Console.WriteLine("You lose. I have  " + lose++ + ". Game " + game++);
                        break;
                    case "lizard":
                        Console.WriteLine("You lose. I have  " + lose++ + ". Game " + game++);
                        break;
                    case "rock":
                        Console.WriteLine("Tied  " + tie++ + ". Game " + game++);
                        break;
                    case "spock":
                        Console.WriteLine("You win. You Have  " + win++ + ". Game " + game++);
                        break;
                    case "paper":
                        Console.WriteLine("You win. You Have  " + win++ + ". Game " + game++);
                        break;
                    default:
                        Console.WriteLine("Oops, try again");
                        break;
                }
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

