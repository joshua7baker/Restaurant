using System;
using System.Collections.Generic;
using System.Text;

namespace Fast_Food
{
    class Till
    {
        public string tillNumber;

        private decimal balance;

        Menu menu = new Menu(); //Reference to menu to get prices
        public decimal ProcessOrder(string product)
        {
            decimal productPrice = menu.FetchProductInfo(product); //Fetch price from menu
            //Console.WriteLine($"Price for {product} is {productPrice}"); //Display product price

            return productPrice;

        }

    }
}
