using System;

namespace EmployeeWageComputation
{
    public interface IComputeEmpWage
    {
        public void CalculateWage(string company, int empWagePerHr, int workDaysInMonth, int totalWorkHrForMonth);
    }
}