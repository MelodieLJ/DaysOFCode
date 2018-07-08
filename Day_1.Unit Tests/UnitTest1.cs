using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day_1;

namespace Day_1.Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]   
            public void Sum_TwoIntegers_CanBeAdded()
            {
                //Arrange
                int expected = 5;
                int firstNumber = 4;
                int secondNumber = 1;

                //Act
                int actual = Day_1.Addition.Sum(firstNumber, secondNumber);

                //Assert
                Assert.AreEqual(expected, actual);
            
            }
        [TestMethod]
            public void Sum_TwoDoubles_CanBeAdded()
            {
                double expected = 16.0;
                double firstNumber = 4.0;
                double secondNumber = 12.0;

                double actual = Day_1.Addition.Sum(firstNumber, secondNumber);

                Assert.AreEqual(expected, actual);
            }

        [TestMethod]
            public void Sum_TwoDoubles_IncorrectlyAddedReturnsFalse()
            {
                int expected = 16;
                int firstNumber = 4;
                int secondNumber = 13;

                double actual = Day_1.Addition.Sum(firstNumber, secondNumber);

                Assert.AreNotEqual(expected, actual);
            }

        [TestMethod]
            public void Concat_TwoStrings_CanBeConcated()
            {
                string expected = "Testing concatenation";
                string firstString = "Testing ";
                string secondString = "concatenation";

                string actual = Day_1.Addition.Concat(firstString, secondString);

                Assert.AreEqual(expected, actual);
            }
    }
}
