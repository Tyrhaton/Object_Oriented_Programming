using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._1
{
    internal class StackElement
    {
        public int Data = 0;
        public StackElement Next = null;

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
