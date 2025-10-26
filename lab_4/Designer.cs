using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Designer : Employee
    {
        public string Specialization { get; set; }

        public int ProjectHoursWorked { get; set; }

        public Designer(string role, int exp, double salary, string specialization)
            : base(role, exp, salary)
        {
            Specialization = specialization;
            this.ProjectHoursWorked = 0;
        }

        public double CalculateProjectIncome(int hours)
        {
            double hourlyRate = this.AnnualSalary / 2080.0;
            return hourlyRate * hours * 1.5;
        }

        public override double CalcMonthSalary()
        {
            double monthlyBaseSalary = this.AnnualSalary / 12.0;

            double variableIncome = CalculateProjectIncome(this.ProjectHoursWorked);

            return monthlyBaseSalary + variableIncome;
        }


        public override string[] GetProjectsList()
        {
            return new string[] { "Landing Page", "Mobile UI Kit", "Brandbook" };
        }
    }
}

