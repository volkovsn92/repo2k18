using NUnit.Framework;
using NUnitTesting_1._0;
using System;

namespace NUnitTesting_1_0
{
    [TestFixture]
    public class UnitTest1 : BaseTest
    {
        [OneTimeSetUp]
        public void InitMethod2()
        {
            initString = "ClassBegin2";

        }
        [OneTimeTearDown]
        public void TearDwnMethod2()
        {
            initString = "ClassEnd2";
            throw new Exception();

        }

        [SetUp]
        public void TestInit()
        {
            initString = "testStarted";
        }
        [TearDown]
        public void TestClean()
        {
            initString = "testFinished";

        }
        [Test, Order(1)]
        public void TestMethod1()
        {
            initString = "method1Started";
            var stupido = Method2<Stupido1>();
            //stupido.
        }

        [Test, Order(3)]
        public void TestMethod2()
        {
            initString = "method2Started";
        }

        public override sealed void Method1()
        {
            int x =  1;
            x++;
        }

        public static Interface1 Method2<T>() where T : Interface1, new()
        {
            Interface1 int1 = new T();
            return int1;
        }

        public UnitTest2 Method<T>()
        {
            return new UnitTest2();
        }
    }
}
