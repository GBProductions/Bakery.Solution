using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bread.Models;

namespace Bread.Tests 
{
    [TestClass]
    public class BreadMethodTests
    {
        [TestMethod]
        public void BreadIs_OneBreadCostsFive_Five()
        {
            BreadPrice testBread = new BreadPrice();
            Assert.AreEqual(true, testBread.BreadIs(1));
        }
    }
}