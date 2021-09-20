using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;


namespace CodingProblems_tests
{
    [TestClass]
    public class DoubleExample1_tests
    {
        [TestMethod]
        public void Check_isDouble_ReturnsTrue()
        {
            var sut = new CodingProblems.DoubleExample1();
            // var input = new int[] { 10, 2, 5, 3 };
            // var input = new int[] { 7, 1, 14, 11 };
            var input = new int[] { 3, 1, 7, 11 };
            var expect = false;

            var actual = sut.Check(input);

            Assert.AreEqual(expect, actual);
        }
    }
}
