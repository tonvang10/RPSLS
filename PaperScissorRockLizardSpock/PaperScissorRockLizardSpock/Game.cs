using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorRockLizardSpock
{
    class Game
    {
        List<Player> player;
        int numberOfPlayers;
        int players;
        
        public Game()
        {
            player = new List<Player>();
        }
        public void StartGame()
        {
            Welcome();
            ShowRules();
            GetNumberOfPlayers();
            AcknowledgePlayer();
        }
        //public bool AskPlayAgain()
        //{
        //    Console.WriteLine("Would you like to play again?  (y|n)");
        //    string answer = Console.ReadLine().ToLower();
        //    if (answer == "y")
        //    {
        //    }
        //    if (answer == "n")
        //    {
        //        Console.WriteLine("THANKS FOR PLAYING!");
        //    }
        //    return false;
        //}
        public void AcknowledgePlayer()
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                player.Add(new Player());
                Console.WriteLine("Player {0}, what is your name?", i + 1);
                player[i].name = Console.ReadLine();
            }
        }
        public int GetNumberOfPlayers()
        { 
            Console.WriteLine("How many players will be playing? (1 or 2)");
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            switch (numberOfPlayers)
            {
                case 1:
                case 2:
                    break;
                default:
                Console.WriteLine("Please enter (1) or (2)");
                GetNumberOfPlayers();
                    break;
            }
            return numberOfPlayers;    
        }
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
            Console.WriteLine("First to get 3 wins, WINS!\n");
            Console.WriteLine("Press ENTER to begin");
            Console.ReadLine();
        }
        public void Welcome()
        {
            Console.WriteLine("Hi, let's play paper, scissor, rock, lizard, spock.");
        }
    }
}
