﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._3
{
    internal class StackElement
    {
        public int Data = 0;
        public StackElement Next = null;

        public void Print()
        {
            Console.WriteLine(Data);
            if (Next != null)
            {
                Next.Print();
            }
        }
    }
}
