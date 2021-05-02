using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests 
{
    [TestClass]
    public class BreadMethodTests
    {
        [TestMethod]
        public void CalculateBread_TwoBreadCostsTen_Int()
        {
            Assert.AreEqual(10, Bread.CalculateBread(5, 2));
        }

        [TestMethod]
        public void CalculateBread_ThreeBreadCostsTen_Int()
        {
            Assert.AreEqual(10, Bread.CalculateBread(5, 3));
        }
    }
}