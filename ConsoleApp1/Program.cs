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

        //Establish Board
        Object Board;
        
        Object Player;
        
            //Establishing Players

            string Name;
            int Birthscore;

            static void Main(string[] args)
            {
                Player spawn = new Player();
                spawn.Name = "Player 1";
                spawn.Birthscore = 0;
                Console.WriteLine(spawn.Name);
                Console.WriteLine(spawn.Birthscore);

                Player spawn2 = new Player();
                spawn2.Name = "Player 2";
                spawn2.Birthscore = 0;
                Console.WriteLine(spawn2.Name);
                Console.WriteLine(spawn2.Birthscore);

                Console.ReadKey();
   
             }
        
        //This is for showing initial score
                int Birthscore = 0;

	                    //Dice function
	                    Console.WriteLine("Rolling Fate");
	            
                    //RollDice method
                    static void RollDice(Random + Birthscore)
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

	            while (i< 50);

                // Scoreboard
                static void PlayerScore;
                List<PlayerScore> score = new List<PlayerScore>();
                int Birthscore;
                int Family;
                int Friends;

    //Need break at some point

    //How to keep score
    public void Keepscore()
    {
        static int KeepScore(int Birthscore, int Family, int Friends);
            private int Family = 0;
    private int Friends = 0;
    public struct TotalScore;

            {
                return Birthscore + Family + Friends;
            }
        }
                Console.WriteLine("Your score is " + Birthscore);

    }


Console.WriteLine("Now you've live");

	            Console.Read();

                

    
    }
            
            

   
}

