using System;
#if NUNIT
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
using TestInitialize = NUnit.Framework.SetUpAttribute;
using ClassCleanup = NUnit.Framework.TestFixtureTearDownAttribute;
using ClassInitialize = NUnit.Framework.TestFixtureSetUpAttribute;
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif

using NUnitAssert = NUnit.Framework.Assert;
using MsAssert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

using HelloWorld;

// Why won't it push my changes to my github repo?

namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            Assert.AreEqual("Hello World Robin", Program.CreateMessage());
        }
    }
}