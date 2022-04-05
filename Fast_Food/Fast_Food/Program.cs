using System;
using System.Collections.Generic;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            BankAccount bankAccount = new BankAccount(); //Create bank account

            int numberOfCustomers = 10; // Number of customers to be generated

            List<Customer> listOfCustomers = new List<Customer>(); //List of all customers

            var Menu = new Menu(); //Create menu
            Menu.CreateProductList();
            

            //Setup Tills
            Till till = new Till();

            //Create number of customer classes equivalent to N of customer var
            for (int i = 0; i < numberOfCustomers; i++)
            {
                var customer = new Customer(Menu); //Create new customer
                listOfCustomers.Add(customer); //Add new customer to list
            }

            //Process Orders
            processOrders();

            //Perform post day processes
            Console.WriteLine($"Todays Sales: £{bankAccount.Balance}"); //Print out daily total
                


            //Function to process each customer order and payment || Currently this is in the main program, however in future should be moved
            //to the Till class if further functionality is implemented. However if it isn't the till functions should be moved into this one 
            // As otherwise Till is performing unneccessary extra steps
            void processOrders()
            {
                //int customerBeingProcessed = 0;

                foreach (var customer in listOfCustomers)
                {
                    //Console.WriteLine($"{customer.customerName} is ordering ");

                    List<string> orderInfo = new List<string>(); //List to contain order information (filled inside foreach below)
                    decimal orderTotalPrice = 0M; //Order total price to be used as total in transaction

                    foreach (var item in customer.orderList) //Loop through each item in the customer order
                    {
                        decimal itemPrice = till.ProcessOrder(item); //Get item price
                        string itemDetails = $"{item}"; //Price is not a variable, and only currently fetched from Menu and called from Till???
                        string orderItemDetails = $"{item}  {itemPrice}"; // Interpolate product name and price 

                        orderTotalPrice += itemPrice; //Add item price to order total
                        orderInfo.Add(orderItemDetails); //Add order details string to order info list

                        //Console.WriteLine(orderItemDetails); //Print what product is being ordered/processed
                    }

                    string displayTotalPrice = $"Total: {orderTotalPrice}"; //Order total price string
                    DateTime orderTime = DateTime.Now; //Set order time = date/time of order
                    //Console.WriteLine(displayTotalPrice); // Display order total price

                    Transaction transaction = new Transaction(orderInfo, orderTotalPrice, orderTime); //Create new transaction record containing order details
                                                                                                      //of customer,   items purchased + price
                    bankAccount.allTransactions.Add(transaction); //Add transaction into bank account


                }
            }


            //Create products based off of menu () 


            //Foreach customer send them to a till
                //Perform transaction at each till
                //Once all customers are served exit out

            //Tally up all til balances and print the daily profit





        }
    }
}
