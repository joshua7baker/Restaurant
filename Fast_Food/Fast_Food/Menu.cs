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
            "Burger",
        };
        List<string> listOfDrinks = new List<string> //Drinks List
        {
            "Cola", 
            "Fanta",

        };

        public void CreateProductList() //Add products from other lists to create master product list
        {
            listOfProducts.AddRange(listOfDrinks); //Add Drinks menu to product list
            listOfProducts.AddRange(listOfFood); //Add food menu to product list

            foreach (var item in listOfProducts) //Print out the product list
            {
                //Console.WriteLine(item);
            }
        }

        void FetchProductInfo(string name, decimal price)
        {

        }


    }
}
