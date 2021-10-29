using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class ThrowDice
    {
        public Random random = new Random();
        public int RolledDice = random.Next(1, 7);

        public int getNumber()
        {
            return random;
        }         


    }
}
