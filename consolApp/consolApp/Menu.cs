using System;
using System.Collections.Generic;
using System.Text;

namespace consolApp
{
    class Menu
    {
        private List<Drink> drinks;
        private List<Meal> meals;

        public Menu()
        {
            drinks = new List<Drink> {
            new Drink("Fanta", 2.8, 150,200),
            new Drink("Water", 0.5, 300, 0),
            new Drink("Cola", 2.5, 500, 170),
            new Drink("Pepsi", 2.5, 500, 170),
            new Drink("Sprite", 2.5, 500, 170)
            };

            meals = new List<Meal> {
            new Meal("Burger", 3.2, 600),
            new Meal("Salad", 2.1, 200)
            };
        }

        public Menu(List<Drink> drinks, List<Meal> meals)
        {
            this.drinks = drinks;
            this.meals = meals;
        }
        public int GetLastIndexOfDrinks() { return drinks.Count-1; }
        public int GetLastIndexOfMeals() { return meals.Count-1; }

        public Drink GetDrink(int index)
        {
            return drinks[index];
        }
        public Drink GetDrink(string nameOfDrink)
        {
           return drinks.Find(drink => drink.ItemName == nameOfDrink);
        }
        public bool MenuContainsDrink(string nameOfDrink)
        {
            if (drinks.Find(drink => drink.ItemName == nameOfDrink) != null) return true;
            else return false;
        }

        public Meal GetMeal(int index)
        {
            
                return meals[index];
           
        }
        public Meal GetMeal(string nameOfMeal)
        {
            return meals.Find(meal => meal.ItemName == nameOfMeal);
        }
        public bool MenuContainsMeal(string nameOfMeal)
        {
            if (meals.Find(meal => meal.ItemName == nameOfMeal) != null) return true;
            else return false;
        }


        public void AddDrinkOnMenu(Drink drink) { drinks.Add(drink); }
        public void AddMealOnMenu(Meal meal) { meals.Add(meal); }

        public void RemoveDrinkFromMenu(Drink drink) { drinks.Remove(drink); }
        public void RemoveDrinkFromMenu(int drinkIndex) { drinks.RemoveAt(drinkIndex); }


        public void RemoveMealFromMenu(Meal meal) { meals.Remove(meal); }
        public void RemoveMealFromMenu(int mealIndex) { meals.RemoveAt(mealIndex);  }

        public void ShowMenu()
        {
            int index = 0;
            Console.WriteLine("Drinks: ");
            Console.WriteLine("Index\tName:\t\tPrice:");
            drinks.ForEach(drink => Console.WriteLine(index++ +"\t" + drink.ItemName + "\t\t" + drink.ItemPrice));
            Console.WriteLine("\nMeals: ");
            Console.WriteLine("Index\tName:\t\tPrice:");
            index = 0;
            meals.ForEach(meal => Console.WriteLine(index++ + "\t" + meal.ItemName + "\t\t" + meal.ItemPrice));
        }


    }
}
