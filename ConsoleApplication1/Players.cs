using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PaperScissorRockLizardSpock
{
    public class Players : Game
    {
        public string userInput;

        public void DecidePlayers()
        {
            Console.WriteLine("Do you want to play against computer or another player?");
            userInput = Console.ReadLine().ToLower();

            if (userInput == "computer")
            {
                Console.WriteLine("Ok great, good luck!");
                Human players = new Human();
                players.GetFirstPlayerName();
                Computer computer = new Computer();
                computer.StartGameWithComputer();
            }
            else if (userInput == "another player")
            {
                Console.WriteLine("Okay.");
                Human players = new Human();
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
