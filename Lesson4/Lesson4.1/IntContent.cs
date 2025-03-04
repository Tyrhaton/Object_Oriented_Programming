using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._1
{
    internal class IntContent : Content
    {
        public int Data;

        public IntContent(int data, int priority) : base(priority)
        {
            this.Data = data;
        }
        public override void Print()
        {
            Console.Write("[+] Int: " + Data);
        } 
    }
}
