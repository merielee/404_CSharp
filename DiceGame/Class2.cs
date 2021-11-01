using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Dice
    {
        public void GetNumber()

        {
            Console.WriteLine("Throw Dice");
        }

        class RandomGen
        {
            public void Rnd()
            {
                Random rnd = new Random();
                int rand_num = rnd.Next(1, 7);

                Console.ReadKey();
            }
        }
    }
}