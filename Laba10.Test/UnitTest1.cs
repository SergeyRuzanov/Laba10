using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba10;
using System.Collections.Generic;

namespace Laba10.Test
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void Working_Test()
        {
            var actual = (new Working("Ivan", "Betev", Gender.Male, Category.Beginner)).ToString();

            var expected = "Betev Ivan; Male; Specialty: Working; Category: Beginner";

            Assert.AreEqual(expected, actual);
        }

    }
}
