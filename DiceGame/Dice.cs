﻿using System;
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
        public int Rnd()
        {
            Random rnd = new Random();
            int rand_num = rnd.Next(1, 7);

            return rand_num;
        }
    }
}