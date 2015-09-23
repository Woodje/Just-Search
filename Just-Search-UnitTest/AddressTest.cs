using System;
using Just_Search;
using NUnit.Framework;

namespace Just_Search_UnitTest {
    [TestFixture]
    public class AddressTest {
        [Test]
        [TestCase("<")]
        [TestCase(">")]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStreetCharactersAreValid(string value) {
            new Address {Street = value};
        }
    }
}
