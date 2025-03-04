using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._1
{
    internal class StringContent : Content
    {
        public string Data;

        public StringContent(string data, int priority) : base(priority)
        {
            this.Data = data;
        }
        public override void Print()
        {
            Console.Write("[+] String: " + Data);
        }
    }
}
