using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pastry.Models;

namespace Pastry.Tests 
{
    [TestClass]
    public class PastryMethodTests
    {
        [TestMethod]
        public void PastryIs_OnePastryCostsTwo_Two()
        {
            PastryPrice testPastry = new PastryPrice();
            Assert.AreEqual(true, testPastry.PastryIs(1));
        }
    }
}