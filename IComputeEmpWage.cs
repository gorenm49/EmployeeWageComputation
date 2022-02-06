using System;

namespace EmployeeWageComputation
{
    public interface IComputeEmpWage
    {
        public void TotalWage(string company, int empWagePerHr, int workDaysInMonth, int totalWorkHrForMonth);
    }
}