using System;
using System.Collections.Generic;

namespace SolarPowerEngineering
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee("Sam", "Ivanov", new DateTime(1985, 1, 15), new DateTime(2010, 2, 20)),
                new Employee("Valera", "Smith", new DateTime(1990, 5, 22), new DateTime(2021, 6, 1)),
                new Employee("Keanu", "Rivz", new DateTime(1988, 3, 12), new DateTime(2015, 7, 15))
            };

            var longTermEmployees = EmployeeCollection.FindLongTermEmployees(employees);

            Console.WriteLine("Employees with more than 5 years of service:");
            foreach (var employee in longTermEmployees)
            {
                Console.WriteLine($"{employee.Name} {employee.Surname}");
            }
        }
    }
}
