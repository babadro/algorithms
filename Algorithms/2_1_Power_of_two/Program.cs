using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_Power_of_two
{
    class Program
    {
        static bool IsPowerOfTwo(ulong x)
        {
            return (x != 0) && (x & (x - 1)) == 0;
        }

        static void Main(string[] args)
        {
        }
    }
}
