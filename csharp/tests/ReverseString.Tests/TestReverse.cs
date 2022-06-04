using NUnit.Framework;

namespace CodingChallenge.ReversingString.Tests
{
    [TestFixture]
    public class ReversingStringTests
    {
        //Possible test cases - string, empty string. function is always expecting a string - could change function to expect an object, so that incorrect inputs are parsed correctly.
        [Test]
        public void TestReversingString()
        {
            string input = "this should be reversed";
            string expctedResult = "desrever eb dluohs siht";
            string result = StringUtilities.Reverse(input);
            Assert.AreEqual(result, expctedResult);
        }
    }
}
