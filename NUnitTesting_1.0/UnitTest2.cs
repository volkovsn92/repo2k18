using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting_1._0
{
    [TestFixture]
    public class UnitTest2 : BaseTest
    {
        [OneTimeSetUp]
        public void InitMethod3()
        {
            initString = "newClassSetUp";
        }
        [OneTimeTearDown]
        public void TearDwnMethod3()
        {
            initString = "newClassTearDown";
        }

        [SetUp]
        public void TestInit3()
        {
            initString = "testStarted";
        }

        [Test, Order(2)]
        public void TestMethod3()
        {
            initString = "method3Started";
        }
    }
}
