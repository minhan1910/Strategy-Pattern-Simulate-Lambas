using System;

namespace StrategyPattern
{
    public partial class Program
    {

        static void Main(string[] args)
        {
            var emp = new List<Employee>()
            {
                new Employee { Name = "An", Age = 20 },
                new Employee { Name = "Hung", Age = 30 },
                new Employee { Name = "Pnu", Age = 200 },
            };

            var employeeProcessor = new EmployeeProcessor(emp);

            var empsFilterdGreaterThan10 = employeeProcessor
                                                .GetAllEmployeesFilterBy(new FilterEmployeeAgeGreaterThan10());

            var empsFilterdGreaterThan100 = employeeProcessor
                                                .GetAllEmployeesFilterBy(new FilterEmployeeAgeGreaterThan100());


            Console.WriteLine("The employees have age greater than 10");
            printEmps(empsFilterdGreaterThan10);

            Console.WriteLine("The employees have age greater than 100");
            printEmps(empsFilterdGreaterThan100);
        }

        static void printEmps(List<Employee> employees)
        {
            foreach (var employee in employees) { 
                Console.WriteLine($"{employee.Name} - {employee.Age}");
            }
        }
    }
}