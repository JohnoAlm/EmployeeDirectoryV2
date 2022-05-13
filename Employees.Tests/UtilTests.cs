using Employee.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Tests
{
    [TestClass]
    public class UtilTests
    {
        private Mock<IUI> ui;

        [TestInitialize]
        public void Init()
        {
             ui = new Mock<IUI>();
        }

        [TestMethod]
        public void AskForString_ShouldReturnString()
        {
            const string expected = "Kalle";
            var mockUI = new MockUI();
            MockUI.SetInput = expected;

            var actual = Util.AskForString("", mockUI);

            Assert.AreEqual(expected, actual);

        } 
        
        [TestMethod]
        public void AskForString_ShouldReturnString2()
        {
            const string expected = "Kalle";
            ui.Setup(u => u.GetInput()).Returns(expected);

            var actual = Util.AskForString("", ui.Object);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [DataRow("5")]
        [DataRow("10")]
        [DataRow("15")]
        public void AskForInt(string value)
        {
            ui.Setup(u => u.GetInput()).Returns(value);
            var actual = Util.AskForUInt("", ui.Object);

            Assert.AreEqual(uint.Parse(value), actual);
        }
    }
}
