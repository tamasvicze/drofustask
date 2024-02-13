using System.Security.Cryptography.X509Certificates;

namespace drofustask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachine();
        }

        static void VendingMachine()
        {
            
            Console.WriteLine("Enter command:");

            bool keepRunning = true;
            while (keepRunning)
            {
                string input = Console.ReadLine().ToLower();
                string[] parts = input.Split(' ');

                if (parts[0] == "list")
                {
                    Methods.ListAllProducts();
                }
                else if (parts[0] == "insert")
                {
                    Methods.InsertMoney(parts);
                }
                else if (parts[0] == "recall")
                {
                    Methods.RecallMoney();
                }
                else if (parts[0] == "order")
                {
                    Methods.OrderProduct(parts);
                }
                else if (parts[0] == "exit")
                {
                    keepRunning = false;
                }
                else
                {
                    Console.WriteLine("Unknown command or invalid syntax.");
                }
            }
        }
    }
}
