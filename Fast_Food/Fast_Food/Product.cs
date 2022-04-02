using System;
using System.Collections.Generic;
using System.Text;

namespace Fast_Food
{
    public class Product
    {
        public string ProductName { get; set; } //Product name to inherit
        public decimal ProductPrice { get; set; } //Product price to inherit

        public Product(string name, decimal price) //Constructor which updates product name and price
        {
            ProductName = name;
            ProductPrice = price;
        }
    }
}
