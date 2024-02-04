using System;

namespace SolarPowerEngineering
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfEmployment { get; set; }

        public Employee(string name, string surname, DateTime dateOfBirth, DateTime dateOfEmployment)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            DateOfEmployment = dateOfEmployment;
        }
    }
}
