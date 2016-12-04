using System;

namespace GenericSouls
{
    class MyStack<T>: Buffer<T>, IMyStack<T>
    {
      
        public void Push(T toPushValue)
        {
            if (IsFull())
            {
                Console.WriteLine("stack overflow");
                Console.ReadKey();
                Environment.Exit(0);
            }
            itemsList[counter] = toPushValue;
            counter++;
        }

        public T Pop()
        {
            counter--;
            return itemsList[counter];
        }

        public T Peek()
        {
            return itemsList[counter - 1];
        }
        public override bool IsFull()
        {
            if (counter == itemsList.Length)
            {
                return true;
            }
            return false;

        }
    }
}
