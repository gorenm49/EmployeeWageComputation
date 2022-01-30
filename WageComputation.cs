using System;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        
        const int EMP_PRESENT = 0, EMP_ABSENT = 1, EMP_WAGE_PER_HR = 20, FULL_DAY = 8; 

        Random random = new Random();

        
        public void employeeAttendence()
        {
            int empCheck = random.Next(0, 2);
            

            if (empCheck == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present..");
                int dailyWage = EMP_WAGE_PER_HR * FULL_DAY;
                Console.WriteLine("Daily Wage is :"+dailyWage);
            }
            if (empCheck == EMP_ABSENT)
            {
                Console.WriteLine("Employee is Absent..");
            }
        }
    }
    
}