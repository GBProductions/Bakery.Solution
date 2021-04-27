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

        [TestMethod]
        public void PastryIs_ThreePastryCostsFive_Int()
        {
            Assert.AreEqual(5, PastryPrice.PastryIs(3));
        }

        [TestMethod]
        public void PastryIs_OnePastryCostsTwo_Int()
        {
            Assert.AreEqual(2, PastryPrice.PastryIs(1));
        }
    }
}