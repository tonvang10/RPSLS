using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorRockLizardSpock
{
        public class Computer : Human

        {
        string move;
        int win = 1;
        int lose = 1;
        int tie = 1;
        int game = 1;
       
        public void StartGameWithComputer()
            {    

            while (win < 3 || lose < 3)
            {       
                Console.WriteLine();
                Console.WriteLine("Paper, Scissor, Rock, Lizard, Spock. Which do you choose {0}?", playerOne);
                move = Console.ReadLine().ToLower();
            
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
                                           
                if (win > 3)
                {
                    Console.WriteLine("Good Job! You WON!");
                    Console.WriteLine(PlayAgain());
                }
                else if (lose > 3)
                {
                    Console.WriteLine("Sorry, You Lose.");
                }
                else if (tie == 3)
                {
                    Console.WriteLine("Wow, we've tied!");;
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

