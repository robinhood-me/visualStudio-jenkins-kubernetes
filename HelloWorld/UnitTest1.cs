using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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