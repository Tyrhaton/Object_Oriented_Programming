using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._3
{
    internal class Stack
    {
        public int data = 0;
        StackElement Top = null;
        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public void Push(string data)
        {
            Data++;

            try
            {
                int getal = int.Parse(data);
                IntContent content = new IntContent(getal);
                Top = new StackElement(content, Top);
            }
            catch
            {
                StringContent content = new StringContent(data);
                Top = new StackElement(content, Top);
            }
        }

        public StackElement Pop()
        {
            if (Top != null)
            {
                StackElement element = Top;
                Top = Top.Next;
                Data--;
                return element;
            }
            else
            {
                Console.WriteLine("[-] Stack is empty");
                return null;
            }
        }

        public void Print(DateTime date)
        {
            Top.Print(date);
        }
        public void Print()
        {
            Top.Print();
        }

        public void ReversePrint()
        {
            Top.Print();
        }

        public void Search(string value)
        {
            try
            {
                bool includes = Top.Search(value);

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
    }
}
