using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Models.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Test
            int i = 0;
            i = i + 2;
            var expect = 5;
            var target = new Calculator();
            var actual = target.Add(2, 3);
            Assert.AreEqual(expect, actual);
        }
    }
}
