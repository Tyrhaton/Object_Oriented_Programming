using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._4
{
    internal class StringContent : Content
    {
        public string Data;

        public StringContent(string data)
        {
            this.Data = data;
        }
        public override void Print()
        {
            Console.Write("[+] String: " + Data);
        }
    }
}
