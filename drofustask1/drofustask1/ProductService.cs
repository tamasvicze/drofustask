using drofustask1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drofustask1
{
    public class ProductService(List<Product> products) : IProductService
    {
        public void ListAllProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }
        }

        public void OrderProduct(string productName)
        {
            var product = products.FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product == null)
            {
                Console.WriteLine("Product not found.");
            }
            else if (CreditService.CurrentCredit >= product.Price)
            {
                CreditService.CurrentCredit -= product.Price;
                Console.WriteLine($"Giving out {product.Name}. Giving back change of {CreditService.CurrentCredit}");
                CreditService.CurrentCredit = 0; // Reset credit after purchase
            }
            else
            {
                int needed = product.Price - CreditService.CurrentCredit;
                Console.WriteLine($"Not enough credit, need {needed} more");
            }
        }
    }
}
