using System;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        
        const int EMP_PRESENT = 0, EMP_ABSENT = 1, EMP_WAGE_PER_HR = 20, FULL_DAY = 8 , PART_TIME = 4; 
        int dayhr= 0, dailyWage=0;

        Random random = new Random();
        
        public void employeeAttendence()
        {

            int empCheck = random.Next(0, 2);

            if (empCheck == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present..");

                if (dayhr == FULL_DAY)
                {
                    dailyWage = EMP_WAGE_PER_HR * FULL_DAY;
                    
                }
                else
                {
                    dailyWage = EMP_WAGE_PER_HR * PART_TIME;
                    
                }
                
                Console.WriteLine("Daily Wage is :"+dailyWage);    
            }
            if (empCheck == EMP_ABSENT)
            {
                Console.WriteLine("Employee is Absent..");
            }
        }
    }
    
}