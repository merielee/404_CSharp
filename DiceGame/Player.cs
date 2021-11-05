using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Player
    {
        public string name { get; }
        public int familywon { get; set; }
        public int wealthwon { get; set; }
        public int RandomNum { get; set; }
        public int RandLife { get; set; }

        public Player(string name)
        {
            this.familywon = 0;
            this.wealthwon = 0;
            this.RandomNum = 0;
            this.RandLife = 0;
            this.name = name;
        }
        public override string ToString()
        {
            return this.name + ", family " + this.familywon + ", wealth " + this.wealthwon;
        }
    }
}