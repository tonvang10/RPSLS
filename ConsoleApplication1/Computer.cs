using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorRockLizardSpock
{
        public class Computer
        {
        string move;
        int win = 1;
        int lose = 1;
        int tie = 1;
        int game = 1;

        public void StartGame()
            {
                Console.WriteLine();
                Console.WriteLine("Paper, Scissor, Rock, Lizard, Spock. Which do you choose?");
                move = Console.ReadLine().ToLower();

                switch (move)
                {
                    case "scissor":
                        Console.WriteLine("You lose. I have  " + lose++ + ". Game " + game++);
                        break;
                    case "lizard":
                        Console.WriteLine("You lose. I have  " + lose ++ + ". Game " + game++);
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
            StartGame();

            }
        }
}
