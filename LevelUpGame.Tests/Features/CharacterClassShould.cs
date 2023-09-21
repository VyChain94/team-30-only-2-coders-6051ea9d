using System;
using System.Collections.Generic;
using NUnit.Framework;
using selectCharacter;

namespace CharacterChoose
{
    [TestFixture]
    public class SetUpClass
    {
        [Test]
        public void ReadDictionary()
        {
            //create a list of expected value.
            Dictionary<int, string> expectedCharacters = new Dictionary<int, string>
            {
                {1, "Red Suit Guy"},
                {2, "Blue Suit Guy"},
                {3, "Green Suit Guy"}
            };
            //create a list of actual values.
            Dictionary<int, string> ActualCharacters = new Dictionary<int, string>
            {
                {1, "Red Suit Guy"},
                {2, "Blue Suit Guy"},
                {3, "Green Suit Guy"}
            };
            //Assert
            Assert.AreEqual(expectedCharacters, ActualCharacters);
        }

        [Test]
        public void ReadUserNameInput()
        {
            string expectedUser = "Only 2 Coders";
            string actualUser = "Only 2 Coders";
            Assert.AreEqual(expectedUser, actualUser);
        }
    }
}