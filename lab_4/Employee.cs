using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public abstract class Employee
    {
        protected string Position { get; set; }
        protected int Experience { get; set; }
        protected double AnnualSalary { get; set; }

        public Employee(string role, int experience, double salary)
        {
            this.Position = role;
            this.Experience = experience;
            this.AnnualSalary = salary;
        }


        public abstract double CalcMonthSalary();
        public abstract string[] GetProjectsList();
    }
}
