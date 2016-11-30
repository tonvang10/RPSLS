using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorRockLizardSpock
{
    public class Human : Players
    {
        public string playerOneChoice;
        public string playerTwoChoice;
        int playerOneWin = 1;
        int playerTwoWin = 1;
        int tie = 1;

        public void StartPlayerVsPlayer()
        {
            while (playerOneWin < 4 || playerTwoWin < 4)
            {
                Console.WriteLine("Paper, Scissor, Rock, Lizard, Spock. Which do you choose {0}?", playerOne);
                playerOneChoice = Console.ReadLine().ToLower();


                Console.WriteLine("Paper, Scissor, Rock, Lizard, Spock. Which do you choose {0}?", playerTwo);
                playerTwoChoice = Console.ReadLine().ToLower();



                if (playerOneChoice == "scissor" && playerTwoChoice == "paper")
                {
                    Console.WriteLine("{0} wins ", playerOne + playerOneWin++);
                }
                else if (playerOneChoice == "scissor" && playerTwoChoice == "lizard")
                {
                    Console.WriteLine("{0} wins ", playerOne + playerOneWin++);
                }
                else if (playerOneChoice == "scissor" && playerTwoChoice == "scissor")
                {
                    tie++;
                }
                else if (playerOneChoice == "rock" && playerTwoChoice == "scissors")
                {
                    Console.WriteLine("{0} wins ", playerOne + playerOneWin++);
                }
                else if (playerOneChoice == "rock" && playerTwoChoice == "lizard")
                {
                    Console.WriteLine("{0} wins ", playerOne + playerOneWin++);
                }
                else if (playerOneChoice == "rock" && playerTwoChoice == "rock")
                {
                    tie++;
                }
                else if (playerOneChoice == "paper" && playerTwoChoice == "rock")
                {
                    Console.WriteLine("{0} wins ", playerOne + playerOneWin++);
                }
                else if (playerOneChoice == "paper" && playerTwoChoice == "spock")
                {
                    Console.WriteLine("{0} wins ", playerOne + playerOneWin++);
                }
                else if (playerOneChoice == "paper" && playerTwoChoice == "paper")
                {
                    tie++;
                }
                else if (playerOneChoice == "lizard" && playerTwoChoice == "spock")
                {
                    Console.WriteLine("{0} wins ", playerOne + playerOneWin++);
                }
                else if (playerOneChoice == "lizard" && playerTwoChoice == "paper")
                {
                    Console.WriteLine("{0} wins ", playerOne + playerOneWin++);
                }
                else if (playerOneChoice == "lizard" && playerTwoChoice == "lizard")
                {
                    tie++;
                }
                else if (playerOneChoice == "spock" && playerTwoChoice == "scissors")
                {
                    Console.WriteLine("{0} wins ", playerOne + playerOneWin++);
                }
                else if (playerOneChoice == "spock" && playerTwoChoice == "rock")
                {
                    Console.WriteLine("{0} wins ", playerOne + playerOneWin++);
                }
                else if (playerOneChoice == "spock" && playerTwoChoice == "spock")
                {
                    tie++;
                }
                else if (playerOneChoice == "scissors" && playerTwoChoice == "rock")
                {
                    Console.WriteLine("{0} wins ", playerTwo + playerTwoWin++);
                }
                else if (playerOneChoice == "scissors" && playerTwoChoice == "spock")
                {
                    Console.WriteLine("{0} wins ", playerTwo + playerTwoWin++);
                }
                else if (playerOneChoice == "rock" && playerTwoChoice == "paper")
                {
                    Console.WriteLine("{0} wins ", playerTwo + playerTwoWin++);
                }
                else if (playerOneChoice == "rock" && playerTwoChoice == "spock")
                {
                    Console.WriteLine("{0} wins ", playerTwo + playerTwoWin++);
                }
                else if (playerOneChoice == "paper" && playerTwoChoice == "scissors")
                {
                    Console.WriteLine("{0} wins ", playerTwo + playerTwoWin++);
                }
                else if (playerOneChoice == "paper" && playerTwoChoice == "lizard")
                {
                    Console.WriteLine("{0} wins ", playerTwo + playerTwoWin++);
                }
                else if (playerOneChoice == "lizard" && playerTwoChoice == "rock")
                {
                    Console.WriteLine("{0} wins ", playerTwo + playerTwoWin++);
                }
                else if (playerOneChoice == "lizard" && playerTwoChoice == "scissors")
                {
                    Console.WriteLine("{0} wins ", playerTwo + playerTwoWin++);
                }
                else if (playerOneChoice == "spock" && playerTwoChoice == "lizard")
                {
                    Console.WriteLine("{0} wins ", playerTwo + playerTwoWin++);
                }
                else if (playerOneChoice == "spock" && playerTwoChoice == "paper")
                {
                    Console.WriteLine("{0} wins ", playerTwo + playerTwoWin++);
                }

            }
        }
    }
}
