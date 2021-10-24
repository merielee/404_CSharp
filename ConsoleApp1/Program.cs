using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public int ThrowDice()
        {
            Random r = new Random();
            int genRand = r.Next(1, 7);
            Console.WriteLine("" + genRand);

            return genRand;
        }              
                
            public static void Main(string[] args)

        {
            //Establishing Players

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

            int playerRandomNum;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);
            }

            Console.ReadKey();

            Console.WriteLine("Now you've live");

            Console.Read();
        }
    }
}   