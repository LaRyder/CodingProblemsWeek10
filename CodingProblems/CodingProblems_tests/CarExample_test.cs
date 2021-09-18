using System;
using System.Collections.Generic;
using System.Text;
using CodingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CodingProblems_tests
{
    [TestClass]
    public class CarExample_tests
    {
        [TestMethod]
        public void Reverse_SimpleString_ReverseString()
        {
            //Arrange
            var input = "Great race".ToLower();
            var expected = "ecar taerg";
            var sut = new CarExample();

            //Act
            var actual = sut.ReverseString(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
