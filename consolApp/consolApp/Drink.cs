using System;
using System.Collections.Generic;
using System.Text;

namespace consolApp
{
    class Drink : MenuItem
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }

        public int amountInMl;
        public int amountOfCalories;
        public Drink(string itemName, double itemPrice, int amountInMl, int amountOfCalories)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
            this.amountInMl = amountInMl;
            this.amountOfCalories = amountOfCalories;
        }

        public Drink(string itemName, double itemPrice, int amountOfCalories)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
            amountInMl = 250;
            this.amountOfCalories = 0;
        }
    }
}
