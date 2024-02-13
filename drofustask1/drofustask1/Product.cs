using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drofustask1
{
    public class Product(string name, int price)
    {
        public string Name { get; set; } = name;
        public int Price { get; set; } = price;
    }
}
