using System;
using Just_Search;
using NUnit.Framework;

namespace Just_Search_UnitTest {
    [TestFixture]
    public class AddressTest {
        private string[] htmlStrings = TestCase.HtmlStrings;
        private string[] numberStrings = TestCase.NumberStrings;
        private string[] alphabeticalStrings = TestCase.AlphabeticalStrings;

        [Test, TestCaseSource("htmlStrings")]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStreetCharactersAreValid(string value) {
            new Address { Street = value };
        }
        [Test, TestCaseSource("htmlStrings")]
        [ExpectedException(typeof(ArgumentException))]
        public void TestHouseNumberCharactersAreValid(string value) {
            new Address { Street = value };
        }
        [TestCaseSource("numberStrings")]
        [Test, TestCaseSource("htmlStrings")]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCityCharactersAreValid(string value) {
            new Address { Street = value };
        }
        [TestCaseSource("htmlStrings")]
        [Test, TestCaseSource("alphabeticalStrings")]
        [ExpectedException(typeof(ArgumentException))]
        public void TestZipCodeCharactersAreValid(string value) {
            new Address { Street = value };
        }
    }
}
