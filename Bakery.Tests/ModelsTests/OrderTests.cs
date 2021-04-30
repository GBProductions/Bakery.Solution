using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Order.Tests 
{
    [TestClass]
    public class OrderMethodTests
    {
        [TestMethod]
        public void OrderIs_TwoPlusFiveisSeven_True()
        {
            Assert.AreEqual(7, OrderPrice.OrderIs(2, 5));
        }
    }
}