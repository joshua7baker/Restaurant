using System;
using System.Collections.Generic;
using System.Text;

namespace Fast_Food
{
    public class Customer
    {
        public string customerName { get; set; } //Customer name
        public int itemOrderAmount { get; set; } //Amount of items being ordered

        public List<string> orderList = new List<string>();

        public Customer() //Construct customer
        {
            //Customer Name
            CustomerNames customerNames = new CustomerNames(); //Create reference to CustomerNames class
            customerName = customerNames.AssignName(); //Assign customer name from list of customer names in the names class

            //Customer Order Amount
            var randomAmount = new Random(); //Random var to use for getting random number
            int orderAmount = randomAmount.Next(1, 5); //Find random number within parameters currently hardcoded
            itemOrderAmount = orderAmount; //Set amount of items customer will order

            //Customer Order Contents


            Console.WriteLine($"{customerName} will be ordering {itemOrderAmount} products from the menu today.");
        }

        //Function to set items they are purchasing
    }
}
