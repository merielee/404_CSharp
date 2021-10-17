using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args);

        class Player
        {
            //Establishing Players

            string Name;
            int Family;
            int Friends; 

            void Main(string[] args)
            {
                Player spawn = new Player();
                spawn.Name = "Player 1";
                spawn.Family = 0;
                spawn.Friends = 0;
                Console.WriteLine(spawn.Name);
                Console.WriteLine(spawn.Family);
                Console.WriteLine(spawn.Friends);

                Player spawn2 = new Player();
                spawn2.Name = "Player 2";
                spawn2.Family = 0;
                spawn2.Friends = 0;
                Console.WriteLine(spawn2.Name);
                Console.WriteLine(spawn2.Family);
                Console.WriteLine(spawn2.Friends);

                Console.ReadKey();

            }
        }

        //RollDice method
        void Main(string[] args)
        {
            Random r = new Random();
            int genRand = r.Next(1, 7);
            System.Console.WriteLine("" + genRand);

            Console.ReadKey();

            //Add DiceNumber to Lifeareas
            int Lifeareas = 0;
            int NewScore = genRand + Lifeareas;
            System.Console.WriteLine("" + NewScore);

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