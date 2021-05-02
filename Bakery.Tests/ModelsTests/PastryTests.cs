using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests 
{
    [TestClass]
    public class PastryMethodTests
    {
        [TestMethod]
        public void CalculatePastry_TwoPastryCostsFour_Int()
        {
            Assert.AreEqual(4, Pastry.CalculatePastry(2, 2));
        }

        [TestMethod]
        public void CalculatePastry_ThreePastryCostsFive_Int()
        {
            Assert.AreEqual(5, Pastry.CalculatePastry(2, 3));
        }

        [TestMethod]
        public void CalculatePastry_OnePastryCostsTwo_Int()
        {
            Assert.AreEqual(2, Pastry.CalculatePastry(2, 1));
        }
    }
}