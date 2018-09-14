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
            initString = "ClassBegin";
        }

        [OneTimeTearDown]
        public void TearDwnMethod()
        {
            initString = "ClassEnd";
        }

        public virtual void Method1() { }
    }
}
