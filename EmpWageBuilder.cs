using System;

namespace EmployeeWageComputation
{
    public class EmpWageBuilder
    {
        const int FULL_DAY = 8, PART_TIME = 4,F_DAY= 1, H_DAY = 0;

        private int countOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilder()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyWage(string company, int empWagePerHr, int workDaysInMonth, int totalWorkHrForMonth)
        {
            companyEmpWageArray[this.countOfCompany] = new CompanyEmpWage(company, empWagePerHr, workDaysInMonth, totalWorkHrForMonth);
            countOfCompany++;
        }

        public void CalculateWage()
        {
            for (int i = 0; i < countOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.CalculateWage(this.companyEmpWageArray[i]));
                System.Console.WriteLine(this.companyEmpWageArray[i].dislpay());
            }
        }

        private void CalculateWage(CompanyEmpWage c1)
        {

            int empHr = 0, totalEmpHr= 0, totalWorkingDays = 0;

            while (totalEmpHr <= c1.totalWorkHrForMonth && totalWorkingDays <= c1.workDaysInMonth )
            {
                totalWorkingDays++;

                Random random = new Random();
                int empCheck1 = random.Next(0, 3);
            
                switch (empCheck1)
                {
                    case F_DAY: 
                        Console.WriteLine("Employee is Present..");
                        this.empHr += this.FULL_DAY;
                        break;

                    case H_DAY: 
                        Console.WriteLine("Employee is Present..");
                        this.empHr += this.PART_TIME;
                        break;

                    default:
                        Console.WriteLine("Employee is absent..");
                        this.empHr += 0;
                        break;
                }
                totalEmpHr +=empHr;
                System.Console.WriteLine("Total Working Days Of EMP: "+this.totalWorkingDays+"\n Working Hrs in month is :"+this.empHr);
            }

            return totalEmpHr * c1.workDaysInMonth;
            
        }

    }
}