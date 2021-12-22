using System;
using System.Collections.Generic;

namespace _01_KomodoCafe.Repository
{
    public class MenuItem
    {
        public MenuItem() { }
       /* public MenuItem(int mealNumber, string mealName, string mealDescription, decimal mealPrice)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            MealPrice = mealPrice;
        }*/
        public MenuItem(int mealNumber, string mealName, string mealDescription, decimal mealPrice, List<string> mealIngredients)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            MealPrice = mealPrice;
            MealIngredients = mealIngredients;
        }
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public decimal MealPrice { get; set; }
        public List<string> MealIngredients { get; set; } = new List<string>();
    }
}

