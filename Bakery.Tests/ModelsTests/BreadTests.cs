using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bread.Models;

namespace Bread.Tests 
{
    [TestClass]
    public class BreadMethodTests
    {
        [TestMethod]
        public void BreadIs_TwoBreadCostsTen_Int()
        {
            Assert.AreEqual(10, BreadPrice.BreadIs(2));
        }

        [TestMethod]
        public void BreadIs_ThreeBreadCostsTen_Int()
        {
            Assert.AreEqual(10, BreadPrice.BreadIs(3));
        }
    }
}