using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._2
{
    internal class StackElement
    {
        private Content content;
        public StackElement Next = null;
        private DateTime creationDate;

        public StackElement(Content content, StackElement next)
        {
            this.content = content;
            this.Next = next;
            creationDate = DateTime.Now;
        }
        public void Print(DateTime date)
        {
            TimeSpan age = date - creationDate;
            content.Print();
            Console.WriteLine(date + " - " + age.ToString());
            if (Next != null)
            {
                Next.Print(date);
            }
        }

        public void Print()
        {
            content.Print();
            Console.WriteLine();
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
            content.Print();
            Console.WriteLine();
        }

        //public bool Search(int number)
        //{
        //    if (data == number) return true;

        //    if (Next != null)
        //    {
        //        return Next.Search(number);
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
