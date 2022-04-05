using System;
using System.Collections.Generic;
using System.Text;

namespace Fast_Food
{
    public class Menu
    {
        public List<string> listOfProducts = new List<string>(); //Product List to generate

        List<string> listOfFood = new List<string> //Food List
        {

            "Beef Burger",
            "Chicken Burger",
            "Nuggets",
            "Fries"
        };
        List<string> listOfDrinks = new List<string> //Drinks List
        {
            "Cola",
            "Fanta"
        };

        List<string> morningSpecificProducts = new List<string> //Morning specific products
        {
            "Hash Brown",
            "Sausauge Burger"
        };

        List<string> afternoonSpecificProducts = new List<string> //Afternoon specific products
        {
            "Lunch Special"
        };


        public void CreateProductList() //Add products from other lists to create master product list
        {

            listOfProducts.AddRange(listOfDrinks); //Add Drinks menu to product list
            listOfProducts.AddRange(listOfFood); //Add food menu to product list

            bool isMorning = CheckTime(); //Set isMorning based on CheckTime functionality

            if (isMorning == true)
            {
                listOfProducts.AddRange(morningSpecificProducts); //Add morning items to list

                foreach (var item in afternoonSpecificProducts)
                {
                    listOfProducts.Remove(item); //Remove afternoon items from list
                }


            }
            else if (isMorning == false)
            {
                listOfProducts.AddRange(afternoonSpecificProducts); //Add afternoon items to list

                foreach (var item in listOfProducts)
                {
                    Console.WriteLine(item);
                }

                foreach (var item in morningSpecificProducts)
                {
                    listOfProducts.Remove(item); //Remove morning items from product list
                }
            }
            
        }

        //Function to check and return a bool is it is morning (before 12 after 6) and false if it is afternoon (after 12 before 6)
        bool CheckTime()
        {
            string timeString = DateTime.Now.ToShortTimeString(); //Set string as current time value
            string timeSubString = timeString.Substring(0, 2); //Get first two characters of time string (hour)
            int time = Int32.Parse(timeSubString); //Parse substring into int variable to use in comparison

            Console.WriteLine(time);

            if (time > 6 && time < 12) //If time is after 6am but not after 12pm
            {
                Console.WriteLine("its morning time");
                return true;
            }

            else if (time > 12 || time < 6) //If time is after 12pm and not before 6am
            {
                return false;
            }

            return false; //Not sure how to return as a nullable bool at the moment, but this needs to be updated 
        }

        //Fetch product info, currently hardcoded to return values on a per string value basis, should be updated to work more smoothly later on to find 
        //product information not using if statements
        public decimal FetchProductInfo(string productName)
        {
            if (productName == "Beef Burger")
            {
                return 4.00M;
            }
            else if (productName == "Chicken Burger")
            {
                return 3.50M;
            }
            else if (productName == "Nuggets")
            {
                return 2.00M;
            }
            else if (productName == "Fries")
            {
                return 1.50M;
            }
            else if (productName == "Cola")
            {
                return 1.99M;
            }
            else if (productName == "Fanta")
            {
                return 1.99M;
            }
            else if (productName == "Lunch Special")
            {
                return 2.50M;
            }
            else if (productName == "Sausage Burger")
            {
                return 1.80M;
            }
            else if (productName == "Hash Brown")
            {
                return 1.50M;
            }
            else
            {
                throw new ArgumentNullException("Issue with prices");
            }
        }


    }
}
