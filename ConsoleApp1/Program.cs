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
                //Dice function
                int RollDice;
                Random r = new Random();
                int genRand = r.Next(1, 7);
                Console.WriteLine("Fate = " + genRand);

                //Add score to Birthscore
                int Lifescore = Birthscore + genRand;
                Console.WriteLine("Lifescore = " + genRand);

                //Roll dice until 50 is reach
                Console.WriteLine("Keep living");
                for (int i = Lifescore; i < 50; i++) ;
            }
        }
}