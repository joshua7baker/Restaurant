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

        public Customer(Menu menu) //Construct customer
        {
            //Customer Name
            CustomerNames customerNames = new CustomerNames(); //Create reference to CustomerNames class
            customerName = customerNames.AssignName(); //Assign customer name from list of customer names in the names class

            //Customer Order Amount
            var randomAmount = new Random(); //Random var to use for getting random number
            int orderAmount = randomAmount.Next(1, 5); //Find random number within parameters currently hardcoded
            itemOrderAmount = orderAmount; //Set amount of items customer will order

            //Customer Order Contents
            ItemsToOrder(itemOrderAmount, menu);

            //Console.WriteLine($"{customerName} will be ordering {itemOrderAmount} products from the menu today.");
        }


        //Function to set items they are purchasing
        void ItemsToOrder(int amount, Menu menu)
        {
            //Menu menu = new Menu(); //Creat reference to menu class
            List<string> listOfProducts = menu.listOfProducts; //create duplicate list to use as ref for product list inside function

            int maxListRange = listOfProducts.Count; //max range to use for Random.Next function finding product

            int orderEvaluated = 0; //Int to use to loop through orders in while loop

            while (orderEvaluated < amount) //While loop assigning a product from listOfProducts per product in the customer order
            {
                orderEvaluated++;

                var randomOrder = new Random(); //Create random object for random int
                int index = randomOrder.Next(0, listOfProducts.Count); //Randomly select element from listOfProduct

                orderList.Add(listOfProducts[index]); // Add product from list of products to customer unique orderList 
            }

            orderList.Sort(); //Sort order list alphabetically

            //foreach (var item in orderList) //Foreach printing out what they are ordering
            //{
            //    Console.WriteLine($"{customerName} has arrived and they are ordering {item}");
            //}

        }
    }
}
