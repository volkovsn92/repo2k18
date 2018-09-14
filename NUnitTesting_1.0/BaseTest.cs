using NUnit.Framework;
using System;

namespace NUnitTesting_1._0
{
    [NUnit.Framework.TestFixture]
    public class BaseTest
    {
        public string initString;

        [OneTimeSetUp]
        public void InitMethod()
        {
            initString = "_ClassBegin";
        }

        [OneTimeTearDown]
        public void TearDwnMethod()
        {
            initString = "_ClassEnd";
        }

        public virtual void Method1() { }
    }
}
