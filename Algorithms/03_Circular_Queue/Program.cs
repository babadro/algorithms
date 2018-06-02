using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Circular_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var Q = new CircularQueue(5);

            Q.Insert(10);
            Q.Insert(20);
            Q.Insert(30);
            Q.Insert(40);
            Q.Insert(50);

            Console.WriteLine("Items are : ");
            Q.PrintQueue();

            Q.Delete();
            Q.Delete();

            Q.Insert(60);
            Q.Insert(70);

            Console.WriteLine("Items are : ");
            Q.PrintQueue();

            Console.ReadLine();
        }
    }
}
