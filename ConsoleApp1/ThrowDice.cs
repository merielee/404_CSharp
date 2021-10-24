using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static ThrowDice
    {
    Random r = new Random();
    int genRand = r.Next(1, 7);

    return genRand;
}

//Having a life (adding Throwdice score to Family and Friends)

int Living()
{
    int Lifescore = FunFamily + ThrowDice;

    return Lifescore;

}
}