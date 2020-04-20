using System;
using System.Collections.Generic;
using System.Text;
using MenuMaster.Models;
using Caliburn.Micro;

namespace MenuMaster.ViewModels
{
    public class DishViewModel : Caliburn.Micro.Screen
    {
        public DishViewModel()
        {

        }

        public DishViewModel(Dish dish, MenuManager menuManager)
        {
            SelectedMenuManager = menuManager;
            SelectedDish = dish;
            SelectedDishes = new BindableCollection<Dish>(menuManager.dishes);
        }

        private MenuManager _selectedMenuManager;

        public MenuManager SelectedMenuManager
        {
            get { return _selectedMenuManager; }
            set 
            { 
                _selectedMenuManager = value;
               
            }
        }

        private Dish _selectedDish;

        public Dish SelectedDish
        {
            get { return _selectedDish; }
            set
            {
                _selectedDish = value;
                NotifyOfPropertyChange("selectedDish");
               
            }
        }

        private BindableCollection<Dish> _selectedDishes;

        public BindableCollection<Dish> SelectedDishes 
        { 
            get { return _selectedDishes; }

            set
            {
                _selectedDishes = value;
            }
        }
    }
}
