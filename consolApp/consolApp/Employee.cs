using System;
using System.Collections.Generic;
using System.Text;

namespace consolApp
{
    class Employee : Person
    {

        public Employee(string name, int age) : base(name, age) { }

        public string Greeting()
        {
            return "Hello my name is " + name + " how can I help you"; 
        }
    }
}
