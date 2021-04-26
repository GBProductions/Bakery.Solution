using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bread.Models;

namespace Bread.Tests 
{
    [TestClass]
    public class BreadMethodTests
    {
        [TestMethod]
        public void BreadIs_OneBreadCostsFive_Int()
        {
            Assert.AreEqual(0, BreadPrice.BreadIs(1));
        }
    }
}