using System;
using System.Collections.Generic;
using System.Text;
using CodingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems_tests
{
    [TestClass]
    public class WellHello_tests
    {
        [TestMethod]
        public void Reverse_SimpleString_ReverseString()
        {
            //Arrange
            var input = "hello";
            var expected = "olleh";
            var sut = new WellHello();

            //Act
            var actual = sut.Reverse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
