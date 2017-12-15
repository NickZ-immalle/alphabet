using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> alpha = new List<string>{ " A" , " B " , " C " };
            alpha.Add(" D ");
            alpha.Add(" E ");
            alpha.Add(" F ");
            alpha.Add(" G ");
            alpha.Add(" H ");
            alpha.Add(" I ");
            alpha.Add(" J ");
            alpha.Add(" K ");
            alpha.Add(" L ");
            alpha.Add(" M ");
            alpha.Add(" N ");
            alpha.Add(" O ");
            alpha.Add(" P ");
            alpha.Add(" Q ");
            alpha.Add(" R ");
            alpha.Add(" S ");
            alpha.Add(" T ");
            alpha.Add(" U ");
            alpha.Add(" V ");
            alpha.Add(" W ");
            alpha.Add(" X ");
            alpha.Add(" Y ");
            alpha.Add(" Z ");

            foreach (string letter in alpha)
            {
             Console.Write(letter);
            }
        }
    }
}