using System;
using System.Collections.Generic;
using System.Text;

namespace Fast_Food
{
    public class CustomerNames
    {
        static public List<string> customerNames = new List<string>
        {
            "Anna",
            "Jimbo",
            "Tony",
            "Jon",
            "Jane",
            "Robert Paulson",
            "Maxine",
            "Rosa",
            "Jerry"
        };

        public string AssignName() //Called from Customer class constructor when new customer class is created
        {
            string customerName; //Customer name that will be returned
            var randomName = new Random(); //Random var to get random ref from list 
            int index = randomName.Next(customerNames.Count); //Get random index number through random variable within customerNames list

            customerName = customerNames[index]; //Set customer name to string found in customerNames via index defined

            return customerName;
        }
    }
}
