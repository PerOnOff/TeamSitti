using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Pood.TeamCitiTest
{
    [TestClass]
    public class TestSuqared
    {
        [TestMethod]
        public void SuquaredReturns4forArgument2()
        {
            Assert.AreEqual(4, MyMeth.Suqared(2));
        }

        [TestMethod]
        public void SuquaredReturns0forArgument0()
        {
            Assert.AreEqual(0, MyMeth.Suqared(0));
        }

        [TestMethod]
        public void SuquaredReturns4forArgumentMinus2()
        {
            Assert.AreEqual(4, MyMeth.Suqared(-2));
        }
    }
}
