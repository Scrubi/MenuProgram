using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MenuMaster.Models
{
    public class MenuManager
    {
        private List<Dish> _dishes = new List<Dish>();
        private List<Category> _categories = new List<Category>();
        public List<Dish> dishes
        {
            get { return _dishes; }
            set { _dishes = value; }
        }

        public List<Category> categories
        {
            get { return _categories; }
            set { _categories = value; }
        }
        public void FillDishesWithDemoData()
        {
           
            dishes.Add(new Dish("Makkara", "Herkullinen Kyrsä", 6.50));
            dishes.Add(new Dish("Peruna", "Suomalainen Peruna", 3.00));
        }

        public void FillCategoriesWithDemoData() 
        {
            categories.Add(new Category("Liharuokala X"));
        }

      
    }
}
