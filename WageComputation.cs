using System;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        
        const int EMP_WAGE_PER_HR = 20, FULL_DAY = 8, PART_TIME = 4, F_DAY= 1, H_DAY = 0 , WORK_DAY_IN_MONTH =20, TOTAL_WORK_HR_FOR_MONTH = 100;

        Random random = new Random();

        int empHr = 0, totalEmpHr= 0, totalWorkingDays = 0;

        public void CalculateWage()
        {
            while (totalEmpHr <= TOTAL_WORK_HR_FOR_MONTH && totalWorkingDays < WORK_DAY_IN_MONTH )
            {
                totalWorkingDays++;

            
                int empCheck1 = random.Next(0, 3);
            
                switch (empCheck1)
                {
                    case F_DAY: 
                        Console.WriteLine("Employee is Present..");
                        this.empHr += FULL_DAY;
                        break;

                    case H_DAY: 
                        Console.WriteLine("Employee is Present..");
                        this.empHr += PART_TIME;
                        break;

                    default:
                        Console.WriteLine("Employee is absent..");
                        this.empHr += 0;
                        break;
                }
                totalEmpHr +=empHr;
                System.Console.WriteLine("Total Working Days Of EMP: "+totalWorkingDays+"\n Working Hrs :"+totalEmpHr);
            }

            int totalEmpWageForMonth = totalEmpHr * WORK_DAY_IN_MONTH;
            System.Console.WriteLine("Monthly Wage for Employee is :"+totalEmpWageForMonth);    
        }    
    }
    
}