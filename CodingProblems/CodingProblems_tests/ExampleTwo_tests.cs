using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems_tests
{
    [TestClass]
    public class ExampleTwo_tests
    {
        [TestMethod]
        public void Return_SimpleString()
        {
            var input = "h";

            var actual = input;

            Assert.AreEqual(input, actual);

        }
    }
}
