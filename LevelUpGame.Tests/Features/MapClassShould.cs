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

        [Test]
        public void ConfirmNo()
        {
            //Create a question that recieves an input of y or n
            string expectedConfirmationOption = "n";
            string actualConfirmationOption = "y";
            Assert.AreNotEqual(expectedConfirmationOption, actualConfirmationOption);
        }

        [Test]
        public void GridSize()
        {
            int xAxis = 9;
            int yAxis = 9;
            string experctedGridSize = ($"{xAxis} x {yAxis}");
            string actualGridSize = ($"{xAxis} x {yAxis}");
            Assert.AreEqual(experctedGridSize, actualGridSize);
        }
    }
}
