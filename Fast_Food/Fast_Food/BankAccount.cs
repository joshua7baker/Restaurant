using System;
using System.Collections.Generic;
using System.Text;

namespace Fast_Food
{
    class BankAccount
    {
        public decimal Balance //Bank balance
        {
            get
            {
                decimal balance = 0; //Temp balance to return
                foreach (var item in allTransactions) //Check all transactions 
                {
                    balance += item.transactionTotal; //add to balance the transaction total
                }
                return balance;
                
            }
        }

        public List<Transaction> allTransactions = new List<Transaction>(); //List to contain all transactions created


        public void UpdateDailyTransactions()
        {

        }


        
    }
}
