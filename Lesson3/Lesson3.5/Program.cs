namespace Lesson3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[!] Hello, World!");
            Queue MyStack = new Queue();

            String Commando = "";
            while (Commando != "Stop")
            {
                Console.Write("[?] Give Command: ");
                Commando = Console.ReadLine();
                
                if (Commando == "Print")
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
                        Console.Write("[?] Give Value: ");
                        MyStack.Search(Console.ReadLine());

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("[-] " + e.Message);
                    }
                    catch (SystemException e)
                    {
                        Console.WriteLine("[-] " + e.Message);
                    }
                    finally
                    {
                        Console.WriteLine("[+] Continue...");
                    }
                }
                else if (Commando == "PrintDate")
                {
                    DateTime now = DateTime.Now;
                    MyStack.Print(now);
                }
                else if (Commando == "EnQueue")
                {
                    Console.Write("[?] Give a value for the queue: ");
                    MyStack.EnQueue(Console.ReadLine());
                }
                else if (Commando == "DeQueue")
                {
                    QueueElement last = MyStack.DeQueue();
                    if(last != null)
                    {
                        last.Print();
                    }
                    else
                    {
                        Console.WriteLine("[-] Queue is empty");
                    }
                }
                else
                {
                    Console.WriteLine("[-] Invalid Command");
                }

            }
        }
    }
}