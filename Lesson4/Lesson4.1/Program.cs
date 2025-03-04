namespace Lesson4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[!] Hello, World!");
            PriorityQueue MyStack = new PriorityQueue();

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
                    string value = Console.ReadLine();    
                    Console.Write("[?] What is its priority? [1-100]: ");
                    string numb = Console.ReadLine();
                    int number = int.Parse(numb != null? numb : "null");
                    MyStack.EnQueue(value != null ? value : "null", number );

                }
                else if (Commando == "Highest")
                {
                    QueueElement el = MyStack.Highest();
                    if(el != null)
                    {
                        el.Print();
                    }
                    else
                    {
                        Console.WriteLine("[-] Queue is empty");
                    }
                }
                else if (Commando == "Lowest")
                {
                    QueueElement el = MyStack.Lowest();
                    if (el != null)
                    {
                        el.Print();
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