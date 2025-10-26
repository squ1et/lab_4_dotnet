using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab_4;

namespace UnitTest
{
    [TestClass]
    public sealed class DesignerClassTest
    {
        private const double Tolerance = 0.01;

        [TestMethod]
        public void Designer_CalculateProjectIncome_ReturnsCorrectAmount()
        {
            // Arrange
            // Annual Salary: 90,000.00
            // Hours: 100
            // Calculation: (90000.00 / 2080.0) * 100 * 1.5 
            // Expected Income: 6490.3846...
            Designer designer = new Designer("Designer", 3, 90000.00, "UI/UX");

            // Act
            double income = designer.CalculateProjectIncome(100);

            // Assert
            Assert.AreEqual(6490.38, income, Tolerance);
        }

        [TestMethod]
        public void Designer_CalcMonthSalary_IsCorrect_WithProjectHours()
        {
            // Arrange
            // Annual Salary: 90,000.00
            // Monthly Base: 7,500.00
            // Hours: 150
            // Project Income: (90000.00 / 2080.0) * 150 * 1.5 = 9735.58
            // Expected Total: 7,500.00 + 9735.58 = 17235.58
            Designer designer = new Designer("Designer", 3, 90000.00, "UI/UX");
            designer.ProjectHoursWorked = 150;

            // Act
            double monthlySalary = designer.CalcMonthSalary();

            // Assert
            Assert.AreEqual(17235.58, monthlySalary, Tolerance);
        }

        [TestMethod]
        public void Designer_CalcMonthSalary_IsCorrect_NoProjectHours()
        {
            // Arrange
            // Annual Salary: 90,000.00
            // Monthly Base: 7,500.00
            // Hours: 0
            // Project Income: 0.00
            // Expected Total: 7,500.00
            Designer designer = new Designer("Designer", 3, 90000.00, "UI/UX");
            designer.ProjectHoursWorked = 0; // Default, but explicitly set for clarity

            // Act
            double monthlySalary = designer.CalcMonthSalary();

            // Assert
            Assert.AreEqual(7500.00, monthlySalary, Tolerance);
        }

        [TestMethod]
        public void Designer_GetProjectsList_ReturnsExpectedArray()
        {
            // Arrange
            Designer designer = new Designer("Designer", 3, 90000.00, "Graphic");
            string[] expectedProjects = { "Landing Page", "Mobile UI Kit", "Brandbook" };

            // Act
            string[] actualProjects = designer.GetProjectsList();

            // Assert
            CollectionAssert.AreEqual(expectedProjects, actualProjects);
        }
    }
}


