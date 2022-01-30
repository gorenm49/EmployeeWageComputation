using System;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        
        const int EMP_PRESENT = 0, EMP_ABSENT = 1, EMP_WAGE_PER_HR = 20, FULL_DAY = 8, PART_TIME = 4, F_DAY= 1, H_DAY = 0;

        Random random = new Random();

        int empHr = 0, totalEmpWage = 0;

        int empCheck = random.Next(0, 3);

        public void employeeAttendence()
        {

            if (this.empCheck == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present..");
                int dailyWage = EMP_WAGE_PER_HR * FULL_DAY;
                Console.WriteLine("Daily Wage is :"+dailyWage);
            }
            if (this.empCheck == EMP_ABSENT)
            {
                Console.WriteLine("Employee is Absent..");
            }
        }

        public void CalculateWage()
        {
            
            switch (empCheck)
            {
                case FULL_DAY: 
                    this.empHr += FULL_DAY;
                    break;
                case PART_TIME: 
                    this.empHr += PART_TIME;
                    break;
                default:
                    Console.WriteLine("Employee is absent..");
                    this.empHr += 0;
                    break;
            }

            this.totalEmpWage = empHr * EMP_WAGE_PER_HR;
            Console.WriteLine(this.totalEmpWage);
        }    
    }
    
}