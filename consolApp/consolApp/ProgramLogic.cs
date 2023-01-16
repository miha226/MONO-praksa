using System;
using System.Collections.Generic;
using System.Text;

namespace consolApp
{
    class ProgramLogic
    {
        private Menu menu;
        private Employee employee;
        private Customer customer;
        private CustomerOrder customerOrder;


        public ProgramLogic(Menu menu, Employee employee, Customer customer)
        {
            this.menu = menu;
            this.employee = employee;
            this.customer = customer;
            customerOrder = new CustomerOrder();
        }

        public void HelpCommand()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("help - to get all commands");
            Console.WriteLine("startOrdering");
            Console.WriteLine("clearOrder - to clear orders");
            Console.WriteLine("buy - clears customer orders and subtracts price from customer balance");
            Console.WriteLine("showMenu - show all menu items");
            Console.WriteLine("showOrder - shows order list");
            Console.WriteLine("balance - shows customer balance");
            Console.WriteLine("finish - finishes interaction\n");
        }



        public void ShowMenuCommand() { menu.ShowMenu(); }
        public void ClearOrderCommand() { customerOrder.ClearList(); }
        public void BuyCommand() {
            double balance = customer.GetBalance();
            double price = customerOrder.GetPriceOfOrder();
            if (price <= 0) Console.WriteLine("Order list is empty");
            else if (price > balance) { Console.WriteLine("Customer does not have sufficient balance"); }
            else
            {
                Console.WriteLine("Customer bought items");
                customer.SpendBalance(price);
                customerOrder.ClearList();
            }
        }
        public void StartOrderingCommand()
        {
            Console.WriteLine("Type drink if you want to start ordering drinks,\ntype meal to start ordering meals");
            Console.WriteLine("When you are done with ordering drink or meal type done, if you want to stop ordering type finish");
            string input;
            do
            {
               input = Console.ReadLine();
                if (input == "drink")
                {
                    OrderDrink();
                }
                else if(input == "meal")
                {
                    OrderMeal();
                }

            } while (input != "finish");
        }

        public void OrderDrink()
        {
            string input;
            int numberOfDrinksOnMenu = menu.GetLastIndexOfDrinks();
            Drink selectedDrink;
            Console.WriteLine("You can type number of drink from the menu or name of drink");
            while (true)
            {
                input = Console.ReadLine();
                if (input == "done") break;
                else if (int.TryParse(input, out int drinkNumber))
                {
                    if (numberOfDrinksOnMenu >= drinkNumber) { 
                    selectedDrink = menu.GetDrink(drinkNumber);
                    customerOrder.AddItem(selectedDrink);
                    Console.WriteLine("You added " + selectedDrink.ItemName + " on your order");
                    }
                    else {
                        Console.WriteLine("Drink under this number does not exist");
                    }
                }
                else if (menu.MenuContainsDrink(input))
                {
                    selectedDrink = menu.GetDrink(input);
                    customerOrder.AddItem(selectedDrink);
                    Console.WriteLine("You added " + selectedDrink.ItemName + " on your order");
                }
            }
            Console.WriteLine("Do you want to order something else, if not type finish\n");
        }

        public void ShowBalance() { Console.WriteLine(customer.GetBalance()); }

        public void OrderMeal()
        {
            string input;
            Meal selectedMeal;
            int numberOfMealsOnMenu = menu.GetLastIndexOfMeals();
            Console.WriteLine("You can type number of meal from the menu or name of meal");
            while (true)
            {
                input = Console.ReadLine();
                if (input == "done") break;
                else if (int.TryParse(input, out int mealNumber))
                {
                    if (numberOfMealsOnMenu >= mealNumber)
                    {
                        selectedMeal = menu.GetMeal(mealNumber);
                        customerOrder.AddItem(selectedMeal);
                        Console.WriteLine("You added " + selectedMeal.ItemName + " on your order");
                    }
                    else
                    {
                        Console.WriteLine("Meal under this number does not exist");
                    }
                }
                else if (menu.MenuContainsMeal(input))
                {
                    selectedMeal = menu.GetMeal(input);
                    customerOrder.AddItem(selectedMeal);
                    Console.WriteLine("You added " + selectedMeal.ItemName + " on your order");
                }
            }
            Console.WriteLine("Do you want to order something else, if not type finish\n");
        }
        public void ShowOrder()
        {
            customerOrder.showOrderList();
        }


        public void Interaction()
        {
            string input;
            HelpCommand();
            employee.Greeting();
            while (true)
            {
                input = Console.ReadLine();


                if (input == "finish") break;
                else if (input == "help") HelpCommand();
                else if (input == "clearOrder") ClearOrderCommand();
                else if (input == "startOrdering") StartOrderingCommand();
                else if (input == "showMenu") ShowMenuCommand();
                else if (input == "showOrder") ShowOrder();
                else if (input == "balance") ShowBalance();
                else if (input == "buy") BuyCommand();
            }
        }


    }
}
