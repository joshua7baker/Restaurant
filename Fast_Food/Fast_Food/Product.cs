using System;
using System.Collections.Generic;
using System.Text;

namespace Fast_Food
{
    public class Product
    {
        public string Name { get; set; } //Product name to inherit
        public decimal Price { get; set; } //Product price to inherit

        public Product(string name, decimal price) //Constructor which updates product name and price
        {
            Name = name;
            Price = price;
        }
    }
}
