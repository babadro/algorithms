using System;
using System.Linq;

namespace _05_Histogram_of_array
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 5, 4, 0, 3, 4, 1 };

            var maxNum = arr.Max();

            for (var i = maxNum; i >= 0; i--)
            {
                foreach (var num in arr)
                {
                    if (num < i)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
