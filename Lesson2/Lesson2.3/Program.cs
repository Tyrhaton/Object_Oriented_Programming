namespace Lesson2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[!] Hello, World!");
            Stack MyStack = new Stack();

            String Commando = "";
            while (Commando != "Stop")
            {
                Console.Write("[?] Give Command: ");
                Commando = Console.ReadLine();
                if (Commando == "Push")
                {
                    try
                    {
                        Console.Write("[?] Give Number: ");
                        MyStack.Push(int.Parse(Console.ReadLine()));
                    }
                    catch
                    {
                        Console.WriteLine("[-] Invalid Input: Only Numbers should be put in.");
                    }
                }
                else if (Commando == "Pop")
                {
                    Console.WriteLine(MyStack.Pop());
                }
                else if (Commando == "Print")
                {
                    MyStack.Print();
                }
                else if (Commando == "ReversePrint")
                {
                    MyStack.ReversePrint();
                }
                else if (Commando == "Amount")
                {
                    Console.WriteLine(MyStack.Data + " element(s)");
                }
                else if (Commando == "Search")
                {
                    try
                    {
                        Console.Write("[?] Give Number: ");
                        MyStack.Search(int.Parse(Console.ReadLine()));

                    }
                    catch
                    {
                        Console.WriteLine("[-] Invalid Input: Only Numbers should be put in.");
                    }
                }
                else if (Commando == "PrintDate")
                {
                    DateTime now = DateTime.Now;
                    MyStack.Print(now);
                }
                else
                {
                    Console.WriteLine("[-] Invalid Command");
                }

            }
        }
    }
}