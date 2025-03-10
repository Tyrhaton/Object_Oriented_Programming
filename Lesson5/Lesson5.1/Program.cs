namespace Lesson5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            BinairyTree myTree = new BinairyTree();

            String Command = "";
            while (Command != "s")
            {
                try
                {
                    Console.Write("[?] Give command: ");
                    Command = Console.ReadLine();

                    if(Command == "a" || Command == "Add")
                    {
                        Console.Write("[?] Give number: ");
                        myTree.Add(int.Parse(Console.ReadLine()));
                    }
                    if (Command == "s" || Command == "Search")
                    {
                        Console.Write("[?] Give number: ");
                        myTree.Search(int.Parse(Console.ReadLine()));
                    }
                    else if (Command == "p" || Command == "Print")
                    {
                        myTree.Print();
                    }
                    else if (Command == "d" || Command == "Delete")
                    {
                        myTree.Delete();
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}