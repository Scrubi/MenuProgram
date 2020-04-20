using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;
using MenuMaster.Models;
using System.Threading;
using System.Threading.Tasks;


namespace MenuMaster.ViewModels
{
    public class ShellViewModel : Conductor<Object>
    {
        private MenuManager menuManager;

        public ShellViewModel()
        {
            menuManager = new MenuManager();
            menuManager.FillDishesWithDemoData();
            menuManager.FillCategoriesWithDemoData();
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        
        public void LoadDishWindow()
        {
            DishViewModel dishViewModel = new DishViewModel(this.menuManager.dishes.FirstOrDefault(), menuManager);
            ActivateItemAsync(dishViewModel, System.Threading.CancellationToken.None);
        }

        public void LoadCategoryWindow()
        {
            MenuCategoryViewModel menuCategoryViewModel = new MenuCategoryViewModel(this.menuManager.categories.FirstOrDefault(), menuManager);
            ActivateItemAsync(menuCategoryViewModel, System.Threading.CancellationToken.None);
        }


    }
}
