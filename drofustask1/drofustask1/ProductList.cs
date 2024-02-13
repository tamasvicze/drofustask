using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drofustask1
{
    public static class ProductList
    {
        public static List<Product> Products { get; set; } = new()
        {
            new Product("Snickers", 10),
            new Product("Twix", 20),
            new Product("Mars", 30),
            new Product("Cola", 10),
            new Product("Fanta", 20),
            new Product("Solo", 30),
            new Product("Smash", 10),
            new Product("Pringles", 20),
            new Product("TicTac", 25),
            new Product("Bounty", 20)
            // Add more products as needed
        };
    }
}
