using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._5
{
    internal class QueueElement
    {
        private Content content;
        public QueueElement Next = null;
        public QueueElement Previous = null;
        private DateTime creationDate;

        public QueueElement(Content content, QueueElement previous)
        {
            this.content = content;
            this.Previous = previous;
            this.creationDate = DateTime.Now;
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

        public bool Search(string value)
        {
            try
            {
                int number = int.Parse(value);
                if ((content is IntContent))
                {
                    if((content as IntContent).Data == number)
                    {
                        return true;
                    }
                }

                if (Next != null)
                {
                    return Next.Search(value);
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                if ((content is StringContent))
                {
                    if ((content as StringContent).Data == value)
                    {
                        return true;
                    }
                }

                if (Next != null)
                {
                    return Next.Search(value);
                }
                else
                {
                    return false;
                }
            }
        }
        public bool IsLast()
        {
            return Next == null;
        }

        //public QueueElement DeQueue()
        //{
        //    if (Next.IsLast())
        //    {
        //        QueueElement Last = Next;
        //        Next = null;
        //        return Last;
        //    }
        //    else
        //    {
        //        return Next.DeQueue();
        //    }
        //}
    }
}
