namespace Lesson1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Stack MyStack = new Stack();

            String Commando = "";
            while (Commando != "Stop")
            {
                Console.Write("Geef commando: ");
                Commando = Console.ReadLine();
                if (Commando == "Push")
                {
                    Console.Write("Geef getal: ");
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
                else if (Commando == "Aantal")
                {
                    Console.WriteLine(MyStack.Data + " element(en)");
                }

            }
        }
    }
}