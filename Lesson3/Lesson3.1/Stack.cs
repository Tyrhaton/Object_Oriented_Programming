using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._1
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

        public void Push(int number)
        {
            Top = new StackElement(number, Top);
            Data++;
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

        public void Search(int number)
        {
            StackElement selected = Top;
            bool includes = Top.Search(number);

            if (includes)
            {
                Console.WriteLine("[+] Element is in stack!");
            }
            else
            {
                Console.WriteLine("[-] Element is not in stack!");
            }
        }
    }
}
