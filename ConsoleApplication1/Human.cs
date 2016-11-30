using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorRockLizardSpock
{
    public class Human : Players
    {
        public void StartGameWithHuman()
        {
            Players intro = new Players();
            intro.IntroducePlayers();
        }

        
            
    }
}
