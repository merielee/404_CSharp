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
            Console.WriteLine("Player1 Starting");

            //This is for showing initial score
            int Birthscore = 0;
            Console.WriteLine("Your score is " + Birthscore);

            //Dice function
            Console.WriteLine("Rolling Fate");
            int RollDice;
            Random r = new Random();
            int genRand = r.Next(1, 7);
            Console.WriteLine("Fate = " + genRand);

            //Add score to Birthscore
            int Lifescore = Birthscore + genRand;
            Console.WriteLine("Lifescore = " + genRand);

            //Roll dice until 50 is reach
            Console.WriteLine("Keep living");

            int i = Lifescore;
            do
            {
                Console.WriteLine(i);
                i++;
            }

            while (i < 50);
        
            Console.WriteLine("Now you've live");

            Console.Read();



            //Establishing Players
            Object Player1;

        }
    }
}