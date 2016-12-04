using System;

namespace GenericSouls
{
    abstract class Buffer<T>: IBuffer<T>
    {
        protected int counter;
        protected T[] itemsList=new T[5];
        
        public abstract bool IsFull();

        public bool IsEmpty()
        {
            if (counter == 0)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            string test;
            test = itemsList[0] as string;
            if (test == string.Empty)
            {
                Console.WriteLine("String is empty");
            }
            else{
            foreach (T i in itemsList)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
         }
        }
    }
}
