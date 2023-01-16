using System;
using System.Collections.Generic;
using System.Text;

namespace consolApp
{
    abstract class Person
    {
        public string name;
        public int age;
        
        protected Person(string Name, int Age)
        {
            this.name = Name;
            this.age = Age;
        }

    }
}
