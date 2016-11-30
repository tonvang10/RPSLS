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
            Game intro = new Game();
            intro.Welcome();

            Players decidePlayers = new Players();
            decidePlayers.DecidePlayers();
             
           

            Console.ReadKey();  
        }
    }
}
