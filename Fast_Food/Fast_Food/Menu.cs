using System;
using System.Collections.Generic;
using System.Text;

namespace Fast_Food
{
    public class Menu
    {
        //Create product for as many products on the list
        List<string> Products = new List<string> { "Burger", "Cola" }; //Product List to generate

        public void CreateProducts() //Create all instances of each product class
        {
            foreach (var item in Products) //Generate a product class for each product string in "Products" List
            {
                if (item == "Burger")  //Burger
                {
                    var burger = new Product("Burger", 3.50M); 
                    Console.WriteLine($"Product {burger.ProductName} generated, at price {burger.ProductPrice}.");
                }
                else if (item == "Cola") //Cola
                {
                    var cola = new Product("Cola", 1.70M);  
                    Console.WriteLine($"Product {cola.ProductName} generated, at price {cola.ProductPrice}.");
                }

            }
        }


    }
}
