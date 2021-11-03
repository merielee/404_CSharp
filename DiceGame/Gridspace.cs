using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Gridspace
    {
        public int player1 = 0;
        public int player2 = 0;

        public void Gridspacelist()
        {
            List<Gridspace> gridspaces = new List<Gridspace>();

            //New instance of a gridspace
            Gridspace player1list = new Gridspace();
            Gridspace player2list = new Gridspace();
            Gridspace family = new Gridspace();
            Gridspace wealth = new Gridspace();

            //Add items
            gridspaces.Add(player1list);
            gridspaces.Add(player2list);
            gridspaces.Add(family);
            gridspaces.Add(wealth);

        }
        

        public void Scoring()
        {
            List<Player> players = new List<Player>();

            //New instance of player
            Player player1 = new Player();
            Player player2 = new Player();

            //Add items
            players.Add(player1);
            players.Add(player2);
        }
    }
}
