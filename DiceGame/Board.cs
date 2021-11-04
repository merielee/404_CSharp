using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Board
    {
        public List<Gridspace> gridspaces = new List<Gridspace>();

        //Constructor
        public Board()
        {
            Console.WriteLine("Game starting");
        }

        public class Gridspace
        {
            //Constructor
            public Gridspace()
            {
                Console.WriteLine("Creating Gridspace");                
            }

        }
    }
}