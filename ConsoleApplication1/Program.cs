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

            Game decidePlayers = new Game();
            decidePlayers.DecidePlayers();
             
           

            Console.ReadKey();  
        }
    }
}
