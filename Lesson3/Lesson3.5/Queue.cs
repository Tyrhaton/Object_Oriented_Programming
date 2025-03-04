using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson3._5
{
    internal class Queue
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

        public void EnQueue(string value)
        {
            int result;
            QueueElement newElement;
            if(int.TryParse(value, out result))
            {
                IntContent content = new IntContent(result);
                newElement = new QueueElement(content, Tail);
            }
            else
            {
                StringContent content = new StringContent(value);
                newElement = new QueueElement(content, Tail);
            }

            if(Tail != null)
            {
                Tail.Next = newElement;
            }
            Tail = newElement;
            if (Head == null)
            {
                Head = Tail;
            }
        }

        public QueueElement DeQueue()
        {
            if (Head == null) return null;
            else
            {
                QueueElement First = Head;
                Head = Head.Next;
                if(Head != null)
                {
                    Head.Previous = null;
                }
                return First;
            }
        }
    }
}