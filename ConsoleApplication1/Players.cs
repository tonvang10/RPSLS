using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PaperScissorRockLizardSpock
{
    public class Players : Game
    {
        public string playerOne;
        public string playerTwo;

        public string GetFirstPlayerName()
        {
            Console.WriteLine("What is your name?");
            playerOne = Console.ReadLine();
            return playerOne;

        }
        public string GetSecondPlayerName()
        {
            Console.WriteLine("Ok, what is the other players name?");
            playerTwo = Console.ReadLine();          
            Human humanVsHuman = new Human();
            return playerTwo;
        }

    }
}
