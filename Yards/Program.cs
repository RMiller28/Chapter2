using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 180;
            int hours = minutes / 60;
            minutes = minutes % 60;
            
            Console.WriteLine(" The time you worked was {0} Hours {1} minutes", hours, minutes);
            
        }
    }
}