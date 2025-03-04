using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._1
{
    public abstract class Content
    {
        public int Priority;

        public Content(int priority)
        {
            this.Priority = priority;
        }
        private Content() {}
        public abstract void Print();
    }
}
