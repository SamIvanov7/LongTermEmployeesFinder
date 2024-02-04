using System;
using System.Collections.Generic;
using System.Linq;

namespace SolarPowerEngineering
{
    public static class EmployeeCollection
    {
        public static IEnumerable<Employee> FindLongTermEmployees(IEnumerable<Employee> employees)
        {
            return employees.Where(e => (DateTime.Now - e.DateOfEmployment).TotalDays > 5 * 365.25);
        }
    }
}
