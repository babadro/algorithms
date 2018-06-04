using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_1_Flight_Tickets
{
    public class OptimalRoute
    {
        private readonly List<string> _lines;

        public OptimalRoute(List<string> lines)
        {
            _lines = lines;
        }

        public int MinPrice(string source, string target, int k)
        {
            if (_lines.Count == 0 || k < 0)
                return -1;

            var nodes = new Dictionary<string, Flight>();

            foreach (var line in _lines)
            {
                string[] s = line.Trim().Split(',');
                string[] t = s[0].Trim().Split(new[]{"->"}, StringSplitOptions.None);
                string from = t[0];
                string to = t[1];
                int cost = int.Parse(s[1].Trim());
                if (!nodes.ContainsKey(from))
                    nodes.Add(from, new Flight(from));
                if (!nodes.ContainsKey(to))
                    nodes.Add(to, new Flight(to));
                nodes[from].NextNodes.Add(to, cost);
            }

            var find = false;
            var q = new Queue<string>();
            var costQueue = new Queue<int>();

            q.Enqueue(source);
            costQueue.Enqueue(0);
            int stops = -1;

            while (q.Count != 0)
            {
                stops++;
                if (stops > k + 1)
                    break;

                int qSize = q.Count;
            }
        }
    }
}
