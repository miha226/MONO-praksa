using System;
using System.Collections.Generic;
using System.Text;

namespace consolApp
{
    class Customer: Person
    {
        private double balance;

        public Customer(string name, int age, double balance):base(name, age)
        {
            this.balance = balance;
        }

        public void SpendBalance(double amount)
        {
            balance -= amount;
        }
        public double GetBalance() { return balance; }

    }
}
