using System;
using System.IO;
using Just_Search;
using NUnit.Framework;

namespace Just_Search_UnitTest {
    [TestFixture]
    public class RestaurantFactoryTest {
        [Test]
        public void TestCreateRestaurant() {
            var html = Properties.Resources.JustEatUnitTest;

            var res = new RestaurantFactory().CreateRestaurant(html);
            Assert.AreEqual(res.Name, "Deep Pan Pizza Express");

            Assert.AreEqual(res.Address.Street, "");
            Assert.AreEqual(res.Address.City, "");
            Assert.AreEqual(res.Address.HouseNumber, "");
            Assert.AreEqual(res.Address.ZipCode, "");

            Assert.AreEqual(res.Delivery.DeliveryCost, "");
            Assert.AreEqual(res.Delivery.MinimumPrice, "");

            Assert.AreEqual(res.Description, "");
            Assert.AreEqual(res.FoodTypes, new[] { "", "" });
            Assert.AreEqual(res.OpeningHours, "");
        }
    }
}
