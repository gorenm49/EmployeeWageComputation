using System;

namespace EmployeeWageComputation
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage computation program!!!");

            WageComputation wageComputation = new WageComputation();

            wageComputation.employeeAttendence();
        }
    }
}