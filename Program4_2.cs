using System;
using System.Collections.Generic;
namespace Polymorphism
{
    public class Employee
    {
        // modify virtual method to return a string
        public virtual string CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = 40 * wage;
            string result = String.Format("This ANGRY EMPLOYEE worked {0} hrs. " + 
                              "Paid for 40 hrs at $ {1}" +
                              "/hr = ${2}", weeklyHours, wage, salary);
            Console.WriteLine("\n" + result + " \n");
            Console.WriteLine("---------------------------------------------\n");
            // returning the result of the string so we can unit test it
            return result;
        }
    }
    public class Contractor : Employee
    {
        // has to return a string like in overrided virtual method
        public override string CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = weeklyHours * wage;
            string result = String.Format("This HAPPY CONTRACTOR worked {0} hrs. " + 
                              "Paid for {0} hrs at $ {1}" +
                              "/hr = ${2} ", weeklyHours, wage, salary);
            Console.WriteLine("\n" + result + " \n");
            Console.WriteLine("---------------------------------------------\n");
            return result;
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            const int hours = 55, wage = 70;
            List<Employee> employees = GetEmployees();
            foreach (var e in employees)
            {
                e.CalculateWeeklySalary(hours, wage);
            }
        }
        private static List<Employee> GetEmployees()
        {
            var someEmployee = new Employee();
            var someContractor = new Contractor();
            var everyone = new List<Employee> { someEmployee, someContractor };
            return everyone;
        }
    }
}
