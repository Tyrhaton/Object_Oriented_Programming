using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._1
{
    internal class StackElement
    {
        public int Data = 0;
        public StackElement Next = null;
        private DateTime creationDate;

        public StackElement(int data, StackElement next)
        {
            this.Data = data;
            this.Next = next;
            creationDate = DateTime.Now;
        }
        public void Print(DateTime date)
        {
            TimeSpan age = date - creationDate;
            Console.WriteLine(date + " - " + age.ToString());
            if (Next != null)
            {
                Next.Print(date);
            }
        }

        public void Print()
        {
            Console.WriteLine(Data);
            if (Next != null)
            {
                Next.Print();
            }
        }

        public void ReversePrint()
        {
            if (Next != null)
            {
                Next.Print();
            }
            Console.WriteLine(Data);
        }

        public bool Search(int number)
        {
            if (Data == number) return true;

            if (Next != null)
            {
                return Next.Search(number);
            }
            else
            {
                return false;
            }
        }
    }
}
