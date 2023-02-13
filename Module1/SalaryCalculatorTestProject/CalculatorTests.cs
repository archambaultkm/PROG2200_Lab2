using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace SalaryCalculatorTestProject
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal annualSalary = sc.GetAnnualSalary(50);

            // Assert   
            Assert.AreEqual(-104000, annualSalary);
        }
        
        [TestMethod]
        public void NegativeAnnualSalaryTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();
            // Act
            try
            {
                decimal annualSalary = sc.GetAnnualSalary(50);

                //Assert  
                Assert.Fail("invalid code, exception expected");
            }
            catch (InvalidOperationException e)
            {
                Assert.AreEqual("Yearly salary must be greater than zero", e.Message);
            }
        }

        [TestMethod]
        public void HourlyWageTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal hourlyWage = sc.GetHourlyWage(52000);

            // Assert   
            Assert.AreEqual(-25, hourlyWage);
        }
        
        [TestMethod]
        public void NegativeHourlyWageTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();
            // Act
            try
            {
                decimal annualSalary = sc.GetAnnualSalary(50);

                //Assert  
                Assert.Fail("invalid code, exception expected");
            }
            catch (InvalidOperationException e)
            {
                Assert.AreEqual("Hourly wage must be greater than zero", e.Message);
            }
        }

    }
}
