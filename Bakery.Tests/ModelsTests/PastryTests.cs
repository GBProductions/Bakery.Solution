using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pastry.Models;

namespace Pastry.Tests 
{
    [TestClass]
    public class PastryMethodTests
    {
        [TestMethod]
        public void PastryIs_TwoPastryCostsFour_Int()
        {
            Assert.AreEqual(4, PastryPrice.PastryIs(2));
        }
    }
}