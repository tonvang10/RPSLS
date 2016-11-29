using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
        public class Myself
        {
        string theirFirstMove;
        int win = 1;
        int lose = 1;
        int tie = 1;
        int game = 1;

        public void PlayMe()
            {
                Console.WriteLine();
                Console.WriteLine("Paper, Scissor, Rock, Lizard, Spock. Which do you choose?");
                theirFirstMove = Console.ReadLine().ToLower();

                switch (theirFirstMove)
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
            PlayMe();

            }
        }
}
