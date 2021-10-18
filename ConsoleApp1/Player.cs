using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Player
{
    public void Setup(string[] args)

    {
        //Establishing Players

        string Name;
        int Family;
        int Friends;               
            
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