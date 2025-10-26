using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab_4;

namespace UnitTest
{
    [TestClass]
    public sealed class ProgrammerClassTest
    {
        private const double Tolerance = 0.01;

        [TestMethod]
        public void Programmer_Senior_CalculateBonus_ReturnsCorrectAmount()
        {
            // Arrange
            Programmer seniorDev = new Programmer("Developer", 5, 120000.00, "Senior");

            // Act
            double bonus = seniorDev.CalculateBonus();

            // Assert
            Assert.AreEqual(2000.00, bonus, Tolerance);
        }

        [TestMethod]
        public void Programmer_Junior_CalculateBonus_ReturnsCorrectAmount()
        {
            // Arrange
            Programmer juniorDev = new Programmer("Developer", 1, 60000.00, "Junior");

            // Act
            double bonus = juniorDev.CalculateBonus();

            // Assert
            Assert.AreEqual(1000.00, bonus, Tolerance);
        }

        [TestMethod]
        public void Programmer_Senior_CalcMonthSalary_IsCorrect()
        {
            // Arrange
            // Annual Salary: 120,000.00
            // Monthly Base: 10,000.00
            // Bonus: 2,000.00
            // Expected Total: 12,000.00
            Programmer seniorDev = new Programmer("Developer", 5, 120000.00, "Senior");

            // Act
            double monthlySalary = seniorDev.CalcMonthSalary();

            // Assert
            Assert.AreEqual(12000.00, monthlySalary, Tolerance);
        }

        [TestMethod]
        public void Programmer_GetProjectsList_ReturnsExpectedArray()
        {
            // Arrange
            Programmer programmer = new Programmer("Developer", 3, 90000.00, "Mid");
            string[] expectedProjects = { "CRM System", "Mobile App", "API Service" };

            // Act
            string[] actualProjects = programmer.GetProjectsList();

            // Assert
            CollectionAssert.AreEqual(expectedProjects, actualProjects);
        }
        [TestMethod]
        public void Programmer_Implements_IProjectAssignable()
        {
            // Arrange
            Programmer programmer = new Programmer("Developer", 3, 90000.00, "Mid");

            // Assert: Перевіряємо, чи клас реалізує інтерфейс IProjectAssignable
            Assert.IsInstanceOfType<IProjectAssignable>(programmer);
        }

        [TestMethod]
        public void Programmer_Implements_ILevelable()
        {
            // Arrange
            Programmer programmer = new Programmer("Developer", 3, 90000.00, "Mid");

            // Assert: Перевіряємо, чи клас реалізує інтерфейс ILevelable та чи правильно повертається властивість
            Assert.IsInstanceOfType<ILevelable>(programmer);
            ILevelable levelable = (ILevelable)programmer;
            Assert.AreEqual("Mid", levelable.Level);
        }
    }
}
