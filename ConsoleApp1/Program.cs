using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public void Setup(string[] args)


        //RollDice method
        {
            Random r = new Random();
            int genRand = r.Next(1, 7);
            Console.WriteLine("" + genRand);

            Console.ReadKey();

            //Add DiceNumber to Lifeareas
            int Lifeareas = 0;
            int NewScore = genRand + Lifeareas;
            Console.WriteLine("" + NewScore);

            //Roll dice until 50 is reach
            Console.WriteLine("Keep living");

            int TotalScore = NewScore;
            do
            {
                Console.WriteLine(TotalScore);
                TotalScore++;
            }

            while (TotalScore < 50);

            System.Console.WriteLine("" + TotalScore);


            Console.WriteLine("Now you've live");

            Console.Read();
        }
    }
}   