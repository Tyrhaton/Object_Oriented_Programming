namespace Lesson3._3
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
                        Console.Write("[?] Give Value: ");
                        MyStack.Push(Console.ReadLine());
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
                else if (Commando == "Pop")
                {
                    StackElement element = MyStack.Pop();
                    if(element != null)
                    {
                        Console.WriteLine("[+] Element Data: ");
                        element.Print();
                    }
                    else
                    {
                        Console.WriteLine("[-] Stack is Empty");
                    }
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
                else
                {
                    Console.WriteLine("[-] Invalid Command");
                }

            }
        }
    }
}