using System;

namespace consolApp
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Employee employee = new Employee("Mark", 21);
            Console.Write("Name of customer: ");
            string customerName = Console.ReadLine();
            Console.Write("\nAge of customer: ");
            int customerAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nBalance of customer: ");
            int customerBalance = Convert.ToInt32(Console.ReadLine());
            Customer customer = new Customer(customerName, customerAge, customerBalance);


            ProgramLogic program = new ProgramLogic(menu, employee, customer);
            program.Interaction();
        }

        

        
    }
}
