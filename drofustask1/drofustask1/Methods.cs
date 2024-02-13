using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drofustask1
{
    public class Methods
    {
        private static int _currentCredit;

        public static void ListAllProducts()
        {
            foreach (var product in ProductList.products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}kr");
            }
        }

        public static void InsertMoney(string[] parts)
        {
            if (parts.Length > 1 && int.TryParse(parts[1], out int money))
            {
                _currentCredit += money;
                Console.WriteLine($"Current credit is {_currentCredit}kr");
            }
            else
            {
                Console.WriteLine("Invalid insert syntax. Use: insert <amount>");
            }
        }

        public static void RecallMoney()
        {
            Console.WriteLine($"Giving out {_currentCredit}kr");
            _currentCredit = 0;
        }

        public static void OrderProduct(string[] parts)
        {
            if (parts.Length > 1)
            {
                string productName = parts[1];
                var product = ProductList.products.FirstOrDefault(p => p.Name.ToLower() == productName.ToLower());

                if (product != null)
                {
                    if (_currentCredit >= product.Price)
                    {
                        _currentCredit -= product.Price;
                        Console.WriteLine($"Giving out {product.Name}. Giving back change of {_currentCredit}kr");
                        _currentCredit = 0; // Reset credit after giving change
                    }
                    else
                    {
                        int needed = product.Price - _currentCredit;
                        Console.WriteLine($"Not enough credit, need {needed}kr more");
                    }
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid order syntax. Use: order <productName>");
            }
        }


    }
}
