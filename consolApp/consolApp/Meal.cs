using System;
using System.Collections.Generic;
using System.Text;

namespace consolApp
{
    class Meal : MenuItem
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }

        public int AmountOfCalories;
        public Meal(string itemName, double itemPrice, int amountOfCalories)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
            AmountOfCalories = amountOfCalories;
        }
    }
}
