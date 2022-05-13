using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Employees.Tests
{
    [TestClass]
    public class EmployeesTests
    {
        [TestMethod]
        public void SalaryLevel_Get_ShouldReturn_SalaryLevelJunior()
        {
            //Arrange
            const int juniorSalaryLevel = 10000;
            const string name = "Kalle";
            var sut = new EmployeeDirectory.Employee(name, juniorSalaryLevel);

            //Act
            var actual = sut.SalaryLevel;

            //Assert
            Assert.AreEqual(EmployeeDirectory.SalaryLevel.Junior, actual);
        }
    }
}