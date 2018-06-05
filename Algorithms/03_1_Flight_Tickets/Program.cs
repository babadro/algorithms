using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_1_Flight_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = new List<string>
            {
                "A->B,100",
                "A->C,400",
                "B->C,100",
                "C->D,100",
                "C->A,10"
            };

            var optimalRoute = new OptimalRoute(lines);
            Console.WriteLine(optimalRoute.MinPrice("A", "D", 1));
            Console.ReadLine();
        }
    }
}
