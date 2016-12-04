using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSouls
{
    abstract class Sorter<T> : ISorter<T> 
    {
        private T[] itemsList;


        public Sorter(T[] itemsList)
        {
            this.itemsList = itemsList;
        }

        public abstract void Sort();

        public void Swap(int a, int b)
        {
            T temp;
            temp = itemsList[a];
            itemsList[a] = itemsList[b];
            itemsList[b] = temp;
        }

        public void Print()
        {
                                
            string test;
            test = itemsList[0] as string;
            if (test == string.Empty)
            {
                Console.WriteLine("Cannot display results");
            }
            else
            {
                foreach (T i in itemsList)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }
        }
     }
    }

