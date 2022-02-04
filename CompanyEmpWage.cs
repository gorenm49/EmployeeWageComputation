using System;

namespace EmployeeWageComputation
{
    public class CompanyEmpWage
    {
        public string company;
        int empWagePerHr, workDaysInMonth, totalWorkHrForMonth, totalEmpWage;

        public CompanyEmpWage(string company, int empWagePerHr, int workDaysInMonth, int totalWorkHrForMonth)
        {
            this.company = company;
            this.empWagePerHr = empWagePerHr;
            this.workDaysInMonth = workDaysInMonth;
            this.totalWorkHrForMonth = totalWorkHrForMonth;
       
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string dislpay()
        {
            Console.WriteLine("The wage by Company "+this.company+",  for the employee is : "+this.totalEmpWageForMonth);
        }
        
    }    
    
    
}