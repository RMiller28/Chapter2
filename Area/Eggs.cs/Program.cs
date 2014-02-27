using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs2
{
    class Program
    {
        static void Main(string[] args)
        {

            int eggs;
            int chick1 = 6;
            int chick2 = 4;
            int chick3 = 6;
            int chick4 = 8;

            eggs = chick1 + chick2 + chick3 + chick4;

            double dozen = eggs / 12;
            double total = eggs % dozen;



            Console.Write(" The total is {0} dozen and {1} eggs", dozen, total);







        }
    }
}