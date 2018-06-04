using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_1_Flight_Tickets
{
    public class Flight
    {
        public string Name;
        public int MinCost;
        public Dictionary<string, int> NextNodes;

        public Flight(string name)
        {
            Name = name;
            MinCost = int.MaxValue;
            NextNodes = new Dictionary<string, int>();
        }
    }
}
