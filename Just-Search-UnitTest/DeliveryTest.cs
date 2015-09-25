using System;
using Just_Search;
using NUnit.Framework;

namespace Just_Search_UnitTest {
    [TestFixture]
    public class DeliveryTest {
        [Test]
        [Microsoft.VisualStudio.TestTools.UnitTesting.ExpectedException(typeof(ArgumentException))]
        public void TestMinimumPriceLessThanZero() {
            new Delivery {MinimumPrice = -1};
        }
        [Test]
        public void TestDeliveryCost()
        {
            var d = new Delivery {DeliveryCost = 5};
            Assert.AreEqual(d.DeliveryCost, 5);
        }
    }
}
