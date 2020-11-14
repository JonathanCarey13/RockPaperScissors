using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class RPS
    {
        public int CompPick { get; set; }

        public RPS() { }

        public RPS(int compPick)
        {
            CompPick = compPick;
        }
    }
}
