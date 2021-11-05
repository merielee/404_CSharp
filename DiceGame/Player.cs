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
        public int RandomNum
        {
            get; set;
        }
        public int RandLife = 0;

public Player(string name)
        {
            this.familywon = 0;
            this.wealthwon = 0;
            this.RandomNum = 0;
            this.name = name;
        }

        public void AddToLife()
        {
            if (this.familywon < 50)
            {
                this.familywon = this.familywon + RandLife;
            }
            Console.WriteLine("This will be added to family");
        }
        public int RndLife()
        {
            Random rnd = new Random();
            int rand_life = rnd.Next(1, 20);

            return rand_life;
        }

        public override string ToString()
        {
            return this.name + ", family" + this.familywon + ", wealth" + this.wealthwon;
        }
    }
}