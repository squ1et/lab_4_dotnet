using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Programmer : Employee
    {
        public string Level { get; set; } 

        public Programmer(string role, int exp, double salary, string level)
            : base(role, exp, salary)
        {
            this.Level = level;
        }

        public double CalculateBonus()
        {
            return this.Level == "Senior" ? 2000.00 : 1000.00;
        }

        public override double CalcMonthSalary()
        {

            double monthlyBaseSalary = this.AnnualSalary / 12.0;

            return monthlyBaseSalary + CalculateBonus();
        }

        public override string[] GetProjectsList()
        {
            return new string[] { "CRM System", "Mobile App", "API Service" };
        }
    }
}

