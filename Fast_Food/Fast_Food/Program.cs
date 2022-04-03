using System;
using System.Collections.Generic;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int numberOfCustomers = 1; // Number of customers to be generated

            CustomerNames customerName = new CustomerNames();

            //Assign product values
            var Menu = new Menu(); //Create menu

            //Create number of customer classes equivalent to N of customer var
            for (int i = 0; i < numberOfCustomers; i++)
            {
                var Customer = new Customer();
            }


            //var productList = new List<Product> {}; // Product List
            // Add products to product list
            
            //Number of customers

            //Create tills

            //Create menu ()

            //Create products based off of menu () 

            //Create defined amount of customers ()
                //Customer name and product amount
                //Function to assign items being bought

            //Foreach customer send them to a till
                //Perform transaction at each till
                //Once all customers are served exit out

            //Tally up all til balances and print the daily profit





        }
    }
}
