using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Circular_Queue
{
    public class CircularQueue
    {
        private int[] ele;
        private int front;
        private int rear;
        private int max;
        private int count;

        public CircularQueue(int size)
        {
            ele = new int[size];
            front = 0;
            rear = -1;
            max = size;
            count = 0;
        }

        public void Insert(int item)
        {
            if (count == max)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                rear = (rear + 1) % max;
                ele[rear] = item;

                count++;
            }
        }

        public void Delete()
        {
            if (count == 0)
                Console.WriteLine("Queue is Empty");
            else
            {
                Console.WriteLine("Deleted element is: " + ele[front]);

                front = (front + 1) % max;

                count--;
            }
        }

        public void PrintQueue()
        {
            int i = 0;
            int j = 0;

            if (count == 0)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else
            {
                for (i = front; j < count;)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + ele[i]);

                    i = (i + 1) % max;
                    j++;
                }
            }
        }
    }
}
