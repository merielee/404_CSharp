using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Player
    {
        int Lived = 50;
        int BoardPosition = 0;

        Random random = new Random();

        int random_number = new Random().Next(1, 7);
    }
}     