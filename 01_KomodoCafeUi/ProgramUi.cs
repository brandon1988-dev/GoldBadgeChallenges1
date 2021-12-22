using _01_KomodoCafe.Repository;
using _01_KomodoCafeUi.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafeUi
{
    public class ProgramUi
    {
        private readonly MenuItemRepository _mRepo = new MenuItemRepository();



        public void Run()
        {
            RunApplication();


        }

        private void RunApplication()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine(
                    "Enter the option you'd like to select:\n" +
                    "1. Show all Cafe Menu Items\n" +
                    "2. Find Menu item by item number\n" +
                    "3. Add new Menu Item\n" +
                    "4. Remove Menu item\n" +
                    "5. Exit\n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        GetAllContents();
                        break;
                    case "2":
                        GetMenuItemByMealNumber();
                        break;
                    case "3":
                        AddMenuItem();
                        break;
                    case "4":
                        DeleteExsistingMenuItem();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a number between 1 and 5");
                        WaitForKeyPress();
                        break;
                }

            }
        }

        private void GetMenuItemByMealNumber()
        {
            Console.Clear();
            Console.WriteLine("Please enter an existing menu item by ID");
            int userInputMenuItemID = int.Parse(Console.ReadLine());
            var menuItem = _mRepo.GetMenuItemByMealNumber(userInputMenuItemID);
        }

        private void WaitForKeyPress()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void GetAllContents()
        {
            Console.Clear();
            Console.WriteLine("Menu items available: ");
            List<MenuItem> menuItem = _mRepo.GetAllContents();
            foreach (MenuItem item in menuItem)
            {
                {
                    DisplayContentListItem(item);
                }
                {
                    WaitForKeyPress();
                }
            }

        }

        private void DisplayContentListItem(MenuItem item)
        {
            Console.WriteLine($"{ item.MealName} \n" +
                $"{item.MealNumber}\n" +
                $"{item.MealDescription}\n" +
                $"{item.MealPrice}\n");
            Console.WriteLine("Ingredients: ");
             
            foreach (var ingredient in item.MealIngredients)
            {
                Console.WriteLine(ingredient);
            }
            Console.WriteLine($"======================");
        }


        private void DeleteExsistingMenuItem()
        {
            Console.Clear();
            Console.WriteLine("Please enter an existing menu item by ID");
            int userInputMenuItemID = int.Parse(Console.ReadLine());
            var menuItem = _mRepo.GetMenuItemByMealNumber(userInputMenuItemID);
            if (menuItem != null)
            {
                bool success = _mRepo.DeleteExsistingMenuItem(menuItem);
                if (success)
                {
                    Console.WriteLine("Item is deleted");
                }
                else
                {
                    Console.WriteLine("Item failed to be deleted");
                }
            }
            else
            {
                Console.WriteLine("Menu item does not exist");
            }

            Console.ReadKey();
        }

        private void AddMenuItem()
        {
            Console.Clear();
            MenuItem menu = new MenuItem();
            Console.WriteLine("What is the name of the menu item?");
            menu.MealName = Console.ReadLine();
            Console.WriteLine("Please write a description");
            menu.MealDescription = Console.ReadLine();
            Console.WriteLine("What is the price?");
            menu.MealPrice = Convert.ToDecimal(Console.ReadLine());
            bool hasAllIngredients = false;
            while (hasAllIngredients == false)
            {
                Console.WriteLine("Please add an ingredient");
                string userInput = Console.ReadLine();
                menu.MealIngredients.Add(userInput);
                Console.WriteLine("Do you want to add any more ingredients? Y/N");
                userInput = Console.ReadLine();
                if (userInput == "Y".ToLower())
                {
                    continue;
                }
                else
                {
                    hasAllIngredients = true;
                }
            }
            bool success = _mRepo.AddMenuItem(menu);
            if (success)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Failure");
            }
            Console.ReadKey();
        }
      
      
        }

    }


