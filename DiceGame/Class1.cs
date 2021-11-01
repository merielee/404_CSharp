using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Player
    {
        public String username { get; set; } = string.Empty;

        public int Lived = 50;
        public int BoardPosition = 0;
        public int RandomNum { get; set; } 

    }         
}     