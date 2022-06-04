using NUnit.Framework;

namespace CodingChallenge.ReversingString.Tests
{
    [TestFixture]
    public class ReversingStringTests
    {
        
        [Test]
        // Normal operation, check return type is string, and that the function is working as expected
        public void TestReversingString()
        {
            string input = "this should be reversed";
            string expctedResult = "desrever eb dluohs siht";
            string result = StringUtilities.Reverse(input);
            Assert.IsInstanceOf(typeof(string), result);
            Assert.AreEqual(result, expctedResult);
        }
        [Test]
        // Null check
        public void TestReversingStringNull()
        {
            string input = null;
            var expectedResult = "String is null or empty";
            string result = StringUtilities.Reverse(input);
            Assert.AreEqual(result, expectedResult);
        }
        [Test]
        // Singular string input - technically cannot be reversed, but input is valid
        public void TestReversingStringOne()
        {
            string input = "e";
            string expectedResult = "e";
            string result = StringUtilities.Reverse(input);
            Assert.AreEqual(result, expectedResult);
        }
    }
}
