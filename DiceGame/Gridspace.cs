using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
     class Gridspace
    {
        public int lifespace = 0;
        public void WhichLife()
        {
            Console.WriteLine("Your moving up on...");
        }
        public int pointsCategory()
        {
            Random random = new Random();
            int pointsCategory = random.Next(1, 3);

            return pointsCategory;
        }
    }
    }    