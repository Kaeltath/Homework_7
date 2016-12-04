using System;

namespace GenericSouls
{
    internal class MyQueue<T> : Buffer<T>, IMyQueue<T>
    {
        private int tail;
        private int head;

      
        public void Enqueue(T elementToEnqueue)
        {
            counter++;
            if (IsFull())
            {
                Console.WriteLine(" item overlaped...");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (tail < itemsList.Length - 1)
            {
                itemsList[tail] = elementToEnqueue;
                tail++;

            }
            else
            {
                itemsList[tail] = elementToEnqueue;
                tail = 0;
            }
        }

        public T Dequeue()
        {
            T value;
            if (head < itemsList.Length - 1)
            {
                value = itemsList[head];
                head++;
                counter--;
                return value;
            }

            value = itemsList[head];
            head = 0;
            counter--;
            return value;
        }
        public override bool IsFull()
        {
            if (counter > itemsList.Length)
            {
                return true;
            }

            return false;
        }
    }
}