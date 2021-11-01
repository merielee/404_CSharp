using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Board
    {
        public void Setup()
        {
            Console.WriteLine("Board Created");
        }
        int familyspace = 0;
        int wealthspace = 0;

        class Gridspace
        {
            public void Showscore()
            {
                //Create list of gridspaces
                List<Gridspace> gridspaces = new List<Gridspace>();

                //New instances of a gridspace
                Gridspace family = new Gridspace();
                Gridspace wealth = new Gridspace();

                //Add items
                gridspaces.Add(family);
                gridspaces.Add(wealth);

                Console.WriteLine("Family Points" + family + "Wealth Points" + wealth);



            }
        }
    }
}
