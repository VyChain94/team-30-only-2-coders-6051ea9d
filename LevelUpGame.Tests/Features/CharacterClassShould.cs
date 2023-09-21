using NUnit.Framework;

namespace CharacterChoose
{
    [TestFixture]
    public class SetUpClass
    {
        [Test]
        public void TestCharacterSelectionA()
        {
            string expected = "Red Suit Guy";
            string actual = "Red";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestCharacterSelectionB()
        {
            string expected = "Blue Suit Guy";
            string actual = "Blue";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestCharacterSelectionC()
        {
            string expected = "Green Suit Guy";
            string actual = "Green";
            Assert.AreEqual(expected, actual);
        }

    }
}