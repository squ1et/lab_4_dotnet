using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Designer : Employee, IProjectIncomeCalculable, IProjectAssignable
    {
        public string Specialization { get; set; }
        public int ProjectHoursWorked { get; set; } = 0; 

        public Designer(string role, int exp, double salary, string specialization)
            : base(role, exp, salary)
        {
            Specialization = specialization;
        }

        public double CalculateProjectIncome(int hours) 
        {
            const double AnnualWorkingHours = 2080.0;
            const double ProjectMarkup = 1.5;

            double hourlyBaseRate = AnnualSalary / AnnualWorkingHours;
            return hourlyBaseRate * hours * ProjectMarkup;
        }

        public override double CalcMonthSalary()
        {
            double monthlyBaseSalary = AnnualSalary / 12.0;
            double projectIncome = CalculateProjectIncome(ProjectHoursWorked);
            return monthlyBaseSalary + projectIncome;
        }

        public override string[] GetProjectsList()
        {
            return new string[] { "Landing Page", "Mobile UI Kit", "Brandbook" };
        }
    }
}

