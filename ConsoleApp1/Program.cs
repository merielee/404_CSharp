using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int ThrowDice()
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

            //Add DiceNumber to Lifeareas
            spawn.Family = spawn.Family + ThrowDice();
            Console.WriteLine(spawn.Name);
            Console.WriteLine(spawn.Family);
            Console.WriteLine(spawn.Friends);

            spawn2.Family = spawn2.Family + ThrowDice();

            Console.WriteLine(spawn2.Name);
            Console.WriteLine(spawn2.Family);
            Console.WriteLine(spawn2.Friends);

            Console.ReadKey();


            //Roll dice until 50 is reach
            Console.WriteLine("Keep living");


            

            Console.Read();
        }
    }
}   