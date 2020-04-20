using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;
using MenuMaster.Models;

namespace MenuMaster.ViewModels
{
    public class MenuCategoryViewModel : Screen
    {

        public MenuCategoryViewModel(Category category, MenuManager menuManager)
        {
            SelectedMenuManager = menuManager;
            SelectedCategory = category;
            SelectedCategories = new BindableCollection<Category>(menuManager.categories);
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

        private Category _selectedCategory;

        public Category SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;

            }
        }

        private BindableCollection<Category> _selectedCategories;

        public BindableCollection<Category> SelectedCategories
        {
            get { return _selectedCategories; }

            set
            {
                _selectedCategories = value;
            }
        }
    }
}
