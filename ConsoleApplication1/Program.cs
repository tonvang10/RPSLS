using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorRockLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro intro = new Intro();
            intro.Welcome();

            Players players = new Players();
            players.DecidePlayers();
             
           

            Console.ReadKey();  
        }
    }
}
