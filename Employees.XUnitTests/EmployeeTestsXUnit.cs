using EmployeeDirectory;
using Xunit;

namespace Employees.XUnitTests
{
    public class EmployeeTestsXUnit
    {
        const int juniorSalary = 10000;
        const int seniorSalary = 50000;
        const string name = "Kalle";

        [Fact]
        public void SalaryLevel_Get_ShouldReturn_SalaryLevelSenior()
        {
            var sut = new EmployeeDirectory.Employee(name, seniorSalary);
            Assert.Equal(SalaryLevel.Senior, sut.SalaryLevel);
        }
        
        [Fact]
        public void SalaryLevel_Get_ShouldReturn_SalaryLevelJunior()
        {
            var sut = new EmployeeDirectory.Employee(name, juniorSalary);
            Assert.Equal(SalaryLevel.Junior, sut.SalaryLevel);
        } 
        
        [Theory]
        [InlineData(juniorSalary)]
        [InlineData(24999)]
        public void SalaryLevel_Get_ShouldReturn_SalaryLevelJunior2(uint salary)
        {
            var sut = new EmployeeDirectory.Employee(name, salary);
            Assert.Equal(SalaryLevel.Junior, sut.SalaryLevel);
        }
    }
}