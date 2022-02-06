using System;

namespace EmployeeWageComputation
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage computation program!!!");

            EmpWageBuilder wageComputation = new EmpWageBuilder();

            System.Console.WriteLine("Enter Company Count for you want to Calculate Wage:");
            int op = int.Parse(Console.ReadLine());
            string cName;
            int hr, wdays, wHr;

            for (int i = 1; i <= op; i++)
            {
                System.Console.WriteLine("For Company "+i+" Enter Details Company name, Work hour, working days and total working hours");
                cName = Console.ReadLine();
                hr = Convert.ToInt32(Console.ReadLine());
                wdays = Convert.ToInt32(Console.ReadLine());
                wHr = Convert.ToInt32(Console.ReadLine());
                
                wageComputation.CalculateWage(cName, hr, wdays,wHr);

            }

        }
    }
}