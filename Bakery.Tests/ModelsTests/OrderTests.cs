using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order.Models;

namespace Order.Tests 
{
    [TestClass]
    public class OrderMethodTests
    {
        [TestMethod]
        public void OrderIs_TwoPlusFiveisSeven_True()
        {
            OrderPrice myPrice = new OrderPrice();
            Assert.AreEqual(true, myPrice.OrderIs(2, 5));
        }
    }
}