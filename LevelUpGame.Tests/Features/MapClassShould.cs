using System;
using NUnit.Framework;

namespace mapInitialize
{
    public class Map
    {
        [Test]
        public void ConfirmYes()
        {
            //Create a question that recieves an input of y or n
            string expectedConfirmationOption = "y";
            string actualConfirmationOption = "n";
            Assert.AreNotEqual(expectedConfirmationOption, actualConfirmationOption);
        }

        public void ConfirmNo()
        {
            //Create a question that recieves an input of y or n
            string expectedConfirmationOption = "n";
            string actualConfirmationOption = "y";
            Assert.AreNotEqual(expectedConfirmationOption, actualConfirmationOption);
        }

    }
}
