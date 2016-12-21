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
            Game game = new Game();
            game.StartGame();

            //DELETE BEFORE TURNING IN
            Console.ReadKey();
        }
    }
}
