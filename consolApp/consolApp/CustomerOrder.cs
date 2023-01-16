using System;
using System.Collections.Generic;
using System.Text;

namespace consolApp
{
   
    class CustomerOrder
    {
        public List<MenuItem> menuItems;
        public CustomerOrder()
        {
            menuItems = new List<MenuItem>();
        }

        public void AddItem(MenuItem item)
        {
            menuItems.Add(item);
        }

        public void RemoveItem(MenuItem item)
        {
            menuItems.Remove(item);
        }

        public void RemoveItem(int itemIndex)
        {
            menuItems.RemoveAt(itemIndex);
        }
        public void ClearList()
        {
            menuItems.Clear();
        }

        public double GetPriceOfOrder()
        {
            double price = 0;
            menuItems.ForEach(item => price += item.ItemPrice);
            return price;
        }

        public void showOrderList()
        {
            if (menuItems.Count>1)
            {
                int index = 0;
                double sum = 0;
                Console.WriteLine("Customer order:");
                foreach (var item in menuItems)
                {
                    Console.WriteLine(index++ + "\t" + item.ItemName + "\t" + item.ItemPrice);
                    sum += item.ItemPrice;
                }
                Console.WriteLine("Sum ---> " + sum + "\n\n");
            }
            else
            {
                Console.WriteLine("Order is empty\n\n");
            }
        }
        

        
    }
}
