using System;

namespace EmployeeWageComputation
{
    public class EmpWageBuilder : IComputeEmpWage
    {
        
        const int  FULL_DAY = 8, PART_TIME = 4, F_DAY= 1, H_DAY = 0;

        Random random = new Random();

        int empHr = 0, totalEmpHr= 0, totalWorkingDays = 0;

        public void CalculateWage(string company, int empWagePerHr, int workDaysInMonth, int totalWorkHrForMonth)
        {
            while (totalEmpHr <= totalWorkHrForMonth && totalWorkingDays <= workDaysInMonth )
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
                System.Console.WriteLine("Total Working Days Of EMP: "+totalWorkingDays+"\n Working Hrs in month is :"+empHr);
            }

            int totalEmpWageForMonth = totalEmpHr * workDaysInMonth;
            System.Console.WriteLine("The wage by Company "+company+",  for the employee is : "+totalEmpWageForMonth);
        }    
    }
    
}