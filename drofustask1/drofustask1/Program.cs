using drofustask1.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace drofustask1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the product list and services
            var products = ProductList.Products;

            IProductService productService = new ProductService(products);
            ICreditService creditService = new CreditService();

            // Create and run the vending machine with the services
            VendingMachine vendingMachine = new VendingMachine(productService, creditService);
            vendingMachine.Run();
        }
    }

    class VendingMachine(IProductService productService, ICreditService creditService)
    {
        public void Run()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("\nEnter command (help for commands):");
                var input = Console.ReadLine().ToLower();
                var command = input.Split(' ');

                if (command[0] == "list")
                {
                    productService.ListAllProducts();
                }
                else if (command[0] == "insert")
                {
                    if (command.Length > 1 && int.TryParse(command[1], out var amount))
                    {
                        creditService.InsertMoney(amount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                }
                else if (command[0] == "recall")
                {
                    creditService.RecallMoney();
                }
                else if (command[0] == "order")
                {
                    if (command.Length > 1)
                    {
                        productService.OrderProduct(command[1]);
                    }
                    else
                    {
                        Console.WriteLine("Specify a product name.");
                    }
                }
                else if (command[0] == "exit")
                {
                    keepRunning = false;
                }
                else if (command[0] == "help")
                {
                    Console.WriteLine("Available commands: list, insert <amount>, recall, order <productName>, exit");
                }
                else
                {
                    Console.WriteLine("Unknown command.");
                }
            }
        }
    }
}
