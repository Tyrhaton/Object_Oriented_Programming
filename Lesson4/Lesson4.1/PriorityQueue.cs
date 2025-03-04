using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson4._1
{
    internal class PriorityQueue
    {
        public int data = 0;
        QueueElement Head = null;
        QueueElement Tail = null;
        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public void Print(DateTime date)
        {
            Head.Print(date);
        }
        public void Print()
        {
            Head.Print();
        }

        public void ReversePrint()
        {
            Head.Print();
        }

        public void Search(string value)
        {
            try
            {
                bool includes = Head.Search(value);

                if (includes)
                {
                    Console.WriteLine("[+] Element is in stack!");
                }
                else
                {
                    Console.WriteLine("[-] Element is not in stack!");
                }
            }
            catch
            {
                Console.WriteLine("[-] There are no elements in the stack.");
            }
        }

        public void EnQueue(string value, int priority)
        {
            int result;
            QueueElement newElement;
            if(int.TryParse(value, out result))
            {
                newElement = new QueueElement(result, priority);
            }
            else
            {
                newElement = new QueueElement(value, priority);
            }

            if (Tail == null)
            {
                newElement.Previous = null;
                newElement.Next = null;
                Head = newElement;
                Tail = newElement;
            }
            else
            {
                QueueElement searchedElement = Tail;
                while (searchedElement != Head && searchedElement.Priority() < priority)
                {
                    searchedElement = searchedElement.Previous;
                }

                if (searchedElement == Head && searchedElement.Priority() < priority)
                {
                    newElement.Next = searchedElement;
                    newElement.Previous = searchedElement.Previous;
                    Head = newElement;
                    searchedElement.Previous = newElement;
                }
                else
                {
                    newElement.Next = searchedElement.Next;
                    newElement.Previous = searchedElement;
                    searchedElement.Next = newElement;
                    if(searchedElement == Tail)
                    {
                        Tail = newElement;
                    }

                }
            }
        }
        public QueueElement Highest()
        {
            if (Head == null)
            {
                return null;
            }
            QueueElement firstElement = Head;
            Head = Head.Next;
            if (Head != null)
            {
                Head.Previous = null;
            }
            firstElement.Next = null;
            return firstElement;
        }
        public QueueElement Lowest()
        {
            if (Tail == null)
            {
                return null;
            }
            QueueElement lastElement = Tail;
            Tail = lastElement.Previous;   
            if (Tail != null)
            {
                Tail.Next = null;
            }
            return lastElement;
        }
    }
}