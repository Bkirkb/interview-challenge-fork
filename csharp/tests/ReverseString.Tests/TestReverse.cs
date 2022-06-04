using NUnit.Framework;

namespace CodingChallenge.ReversingString.Tests
{
    [TestFixture]
    public class ReversingStringTests
    {
        //Possible test cases - string, empty/null string. function is always expecting a string - could change function to expect an object, so that incorrect inputs are parsed correctly.
        [Test]
        public void TestReversingString()
        {
            string input = "this should be reversed";
            string expctedResult = "desrever eb dluohs siht";
            string result = StringUtilities.Reverse(input);
            Assert.AreEqual(result, expctedResult);
        }
        [Test]
        public void TestReversingStringNull()
        {
            string input = null;
            var expectedResult = "String is null or empty";
            string result = StringUtilities.Reverse(input);
            Assert.AreEqual(result, expectedResult);
        }
        [Test]
        public void TestReversingStringOne()
        {
            string input = "e";
            string expectedResult = "e";
            string result = StringUtilities.Reverse(input);
            Assert.AreEqual(result, expectedResult);
        }
    }
}
