using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe.Repository
{
    public class MenuItemRepository
    {
        protected readonly List<MenuItem> _menuDirectory = new();
        private int _count;
       

        //Create
        public bool AddMenuItem(MenuItem menuItem)
        {
            if (menuItem is null)
            {
                return false;
            }
            else
            {
                _count++;
                menuItem.MealNumber = _count;
                _menuDirectory.Add(menuItem);
                return true;
            }
          
        }
        //Read
       public  List<MenuItem> GetAllContents()
        {
            return _menuDirectory;
        }
       public  MenuItem GetMenuItemByMealNumber(int mealNumber)
        {
            foreach (MenuItem menuItem in _menuDirectory)
            {
                if (menuItem.MealNumber == mealNumber)
                {
                    return menuItem;
                }
            }
            return null;
        }
        //Delete
        public bool DeleteExsistingMenuItem(MenuItem existingMenuItem)
        {
            bool deleteResult = _menuDirectory.Remove(existingMenuItem);
            return deleteResult;
        }
    }
}

