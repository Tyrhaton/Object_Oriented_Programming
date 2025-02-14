using Lesson2._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._1
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
        public void Push(int getal)
        {
            StackElement newTop = new StackElement();
            newTop.Data = getal;
            newTop.Next = Top;
            Top = newTop;
        }
        public int Pop()
        {
            if (Top != null)
            {
                int number = Top.Data;
                Top = Top.Next;
                return number;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return 0;
            }
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
