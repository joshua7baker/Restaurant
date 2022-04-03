using System;
using System.Collections.Generic;
using System.Text;

namespace Fast_Food
{
    class Menu
    {
        public List<string> listOfProducts = new List<string>(); //Product List to generate

        List<string> listOfFood = new List<string> //Food List
        {
            "Beef Burger",
            "Chicken Burger",
        };
        List<string> listOfDrinks = new List<string> //Drinks List
        {
            "Cola",
            "Fanta",
        };

        public Menu() //Class constructor
        {
            CreateProductList();
        }

        public void CreateProductList() //Add products from other lists to create master product list
        {
            listOfProducts.AddRange(listOfDrinks); //Add Drinks menu to product list
            listOfProducts.AddRange(listOfFood); //Add food menu to product list

            foreach (var item in listOfProducts) //Print out the product list
            {
                //Console.WriteLine(item);
            }
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
            else if (productName == "Cola")
            {
                return 1.99M;
            }
            else if (productName == "Fanta")
            {
                return 1.99M;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }


    }
}
