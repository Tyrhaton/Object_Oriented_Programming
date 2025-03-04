using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._5
{
    internal class IntContent : Content
    {
        public int Data;

        public IntContent(int data)
        {
            this.Data = data;
        }
        public override void Print()
        {
            Console.Write("[+] Int: " + Data);
        } 
    }
}
