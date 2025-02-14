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
                    Console.Write("[?] Give Number: ");
                    MyStack.Push(int.Parse(Console.ReadLine()));
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
                    Console.WriteLine(MyStack.Data + " elements");
                }
                else if (Commando == "Search")
                {
                    Console.Write("[?] Give Number: ");
                    MyStack.Search(int.Parse(Console.ReadLine()));
                }

            }
        }
    }
}