using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Player
    {
        public int familywon = 0;
        public int wealthwon = 0;
        public int RandomNum = 0;
        public int RandLife = 0;

        public void LifeBit()
        {
            Console.WriteLine("This will be added to one of your life bits");
        }
        public int RndLife()
        {
            Random rnd = new Random();
            int rand_life = rnd.Next(1, 20);

            return rand_life;
        }
    }
}