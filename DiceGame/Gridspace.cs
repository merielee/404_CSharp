using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Gridspace
    {
        public class Player
        {
            public int familyposition = 0;
            public int wealthposition = 0;
            
            public Player()
            {
                Console.WriteLine("Players Scores");

                List<Player> players = new List<Player>();

                //New instance of player
                Player player1 = new Player();
                Player player2 = new Player();

                //Add items
                players.Add(player1);
                players.Add(player2);

                return;

            }

        }



    }

}    