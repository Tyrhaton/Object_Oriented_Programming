using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._1
{
    internal class BinairyTree
    {
        Node? Root = null;

        public void Add(int number)
        {
            Node node = new Node(number);

            if (Root == null)
            {
                Root = node;
            }
            else
            {
                Root.Add(node);
            }
        }
        public void Print()
        {
            if(Root != null)
            {
                Root.Print(0);
            }
            else
            {
                Console.WriteLine("[-] Tree is empty!");
            }
        }
        public void Delete()
        {
            Root = null;
        }
        public void Search(int number)
        {
            if(Root == null)
            {
                Console.WriteLine("[-] Tree is empty!");
            }
            else
            {
                Root.Search(Root, number);
            }
        }

    }
}
