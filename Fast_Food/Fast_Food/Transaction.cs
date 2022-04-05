using System;
using System.Collections.Generic;
using System.Text;

namespace Fast_Food
{
    class Transaction
    {
        public decimal transactionTotal = 0;

        List<string> transactionData = new List<string>();
        public Transaction(List<string> productsPurchased, decimal totalPrice, DateTime orderTime)
        {
            Console.WriteLine(orderTime); // Print Transaction Time
            Console.WriteLine($"Total: {totalPrice}"); //Print transaction total

            foreach (var item in productsPurchased)
            {
                Console.WriteLine(item); // Print order details
            }

            Console.WriteLine(); //Blank line to seperate transaction statements

            transactionTotal = totalPrice; //Set transaction total
        }
    }
}
