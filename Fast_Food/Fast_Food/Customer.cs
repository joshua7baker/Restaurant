using System;
using System.Collections.Generic;
using System.Text;

namespace Fast_Food
{
    public class Customer
    {
        public string customerName { get; set; } //Customer name
        public int itemOrderAmount { get; set; } //Amount of items being ordered

        public Customer(string name, int orderAmount) //Construct customer
        {
            customerName = name;
            itemOrderAmount = orderAmount;
            Console.WriteLine($"{customerName} will be ordering {itemOrderAmount} products from the menu today.");
        }

        //Function to set items they are purchasing
    }
}
