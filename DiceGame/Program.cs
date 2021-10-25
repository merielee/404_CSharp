﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Program
    {
            public int Add(int player1Points, int player1Family)
            {
                // returns the add of num1 and num2
                return player1Points + player1Family;
            }

        static void Main(string[] args)
        {
            int player1RandomNum;
            int player2RandomNum;

            int player1Points = 0;
            int player2Points = 0;

            int player1Family = 0;

            Random random = new Random();

            // Loop 5 times
            for (int i = 0; i < 5; i++)
            {
                // Displays message asking player1 to press any key
                Console.WriteLine("Who will have a better life? Press any key to roll the dice.");

                // Waits for the player1 to press any key before generating number
                Console.ReadKey();

                // Generates a random number between 1 and 6 for player1
                player1RandomNum = random.Next(1, 7);

                // Prints out player1's randomly generated number
                Console.WriteLine("Player 1 rolled a " + player1RandomNum);

                Console.WriteLine("...");

                // Waits one second
                System.Threading.Thread.Sleep(1000);

                // Generates a random number between 1 and 6 for player2
                player2RandomNum = random.Next(1, 7);

                // Prints out player2's randomly generated number
                Console.WriteLine("Player 2 rolled a " + player2RandomNum);

                // If the player1 rolls higher than player2
                if (player1RandomNum > player2RandomNum)
                {
                    //Increase player1 points by rolled number
                    player1Points = player1Points += player1RandomNum;

                    {
                        Program points = new Program();
                        int result;
                        // calling the function add that will return 9 to the result vaiable.
                        result = points.Add(player1Points, player1Family);
                        Console.WriteLine(result);

                        Console.ReadLine();
                    }

                    // Display message saying player1 has won this round
                    Console.WriteLine("Player 1 wins this round!");
                }
                // If the player2 rolls higher than player1
                else if (player1RandomNum < player2RandomNum)
                {
                    // Increase player2 points by rolled number
                    player2Points = player2Points += player2RandomNum;

                    // Display message saying player2 has won this round
                    Console.WriteLine("Player 2 wins this round!");
                }
                // If player1 and player2 have rolled the same number
                else
                {
                    // Display message saying this round is a draw
                    Console.WriteLine("Draw!");
                }

                // Displays player1 and player2 scores
                Console.WriteLine("The score is now - Player 1 : " + player1Points + ". Player 2 : " + player2Points + ".");

                // Creates an empty line in between each round
                Console.WriteLine();
            }

            // If the player1 has scored higher than player2
            if (player1Points > player2Points)
            {
                // Display a message saying player1 wins
                Console.WriteLine("Player 1 wins a better life!");
            }
            // If the player2 has scored higher than player1
            else if (player1Points < player2Points)
            {
                // Display message saying player1 loses
                Console.WriteLine("Player 2 wins a better life!");
            }
            // If player1 and player2 score the same amount of points
            else
            {
                // Display message saying it's a draw
                Console.WriteLine("It's a draw!");
            }
            // Wait for user input before console window closes
            Console.ReadKey();
        }
    }
}    