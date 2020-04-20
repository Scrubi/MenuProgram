using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;

namespace MenuMaster.Models
{
    public class Dish
    {
        public string DishName { get; set; }
        public string DishDescription { get; set; }

        public double Price { get; set; }
        
        public Dish()
        {

        }
        public Dish(string name, string description, double price)
        {
            this.DishName = name;
            this.DishDescription = description;
            this.Price = price;
        }


      

    }
}
