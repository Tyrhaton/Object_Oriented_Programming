using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._1
{
    internal class Node
    {
        public Node? Left { get; set; }
        public Node? Right { get; set; }

        public int Data { get; }

        public Node(int data)
        {
            Left = null;
            Right = null;
            Data = data;
        }

        public void Add(Node newNode)
        {
            if (newNode.Data <= Data)
            {
                // go left
                if (Left == null)
                {
                    Left = newNode;
                }
                else
                {
                    Left.Add(newNode);
                }
            }
            else
            {
                // go right
                if(Right == null)
                {
                    Right = newNode;
                }
                else
                {
                    Right.Add(newNode);
                }
            }
        }

        public void Print(int depth)
        {
            depth++;
            if (Left != null)
            {
                Left.Print(depth);
            }
            for (int i = 0; i < depth; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine(Data);
            if(Right != null)
            {
                Right.Print(depth);
            }
        }
        public void Search(Node node, int number)
        {
            if(number == node.Data)
            {
                Console.WriteLine("[+] Found!");
            }
            else
            {
                if(number < node.Data)
                {
                    if(node.Left == null)
                    {
                        Console.WriteLine("[-] Not Found");
                    }
                    else
                    {
                        Search(node.Left, number);
                    }
                }
                else
                {
                    if(node.Right == null)
                    {
                        Console.WriteLine("[-] Not Found");
                    }
                    else
                    {
                        Search(node.Right, number);
                    }
                }
            }
        }

    }
}
