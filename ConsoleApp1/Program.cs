using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is for showing initial score
            int Birthscore = 0;
            Console.WriteLine("Your score is" + Birthscore);

            {
                //Add score to initial score
                int RollDice;
                Random r = new Random();
                int genRand = r.Next(10, 50);
                Console.WriteLine("Fate = " + genRand);
            }
        }
    }
}
