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

            List<Customer> listOfCustomers = new List<Customer>(); //List of all customers


            //Assign product values
            var Menu = new Menu(); //Create menu


            //Setup Tills
            Till till = new Till();

            //Create number of customer classes equivalent to N of customer var
            for (int i = 0; i < numberOfCustomers; i++)
            {
                var customer = new Customer(); //Create new customer
                listOfCustomers.Add(customer); //Add new customer to list
            }

            //Process Orders
            processOrders();

            //Function to process each customer order and payment
            void processOrders()
            {
                //int customerBeingProcessed = 0;

                foreach (var customer in listOfCustomers)
                {
                    Console.WriteLine($"{customer.customerName} is ordering ");

                    List<string> orderInfo = new List<string>(); //List to contain order information

                    foreach (var item in customer.orderList)
                    {
                        till.ProcessOrder(item); //Process one order item 
                        string itemDetails = $"{item}"; //Price is not a variable, and only currently fetched from Menu and called from Till???
                        Console.WriteLine(itemDetails);

                        //Console.WriteLine(item); //Print what product is being ordered/processed
                    }

                    //Resume, I was working out how to display order information as a transactional statement as there is no price variable yet
                    Transaction transaction = new Transaction(orderInfo);


                }
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
