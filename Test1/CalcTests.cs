using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestingMsTest1;


namespace Test1
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Sum_ShouldCalcAndReturnSameValue()
        {
            //Arrange 

            int a = 4;
            int b = 4;
            int expected = 8;

            //Act

            int actual = Calcs.Sum(a, b);

            //Assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Multiply_ShoulCalAndReturnSameValue()
        {
            //Arrange
            int a = 6;
            int b = 10;
            int expect = 50;

            //Act

            int actual = Calcs.Multiply(a,b);

            //Assert

            Assert.AreEqual(expect, actual);


        }

    }
}
