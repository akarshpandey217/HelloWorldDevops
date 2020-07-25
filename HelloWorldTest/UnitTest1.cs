using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace HelloWorldTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World!";
        [TestMethod]
        public void InitialTestMethod()
        {
            string result = HelloWorld.Program.SimpleTestMethod("Hello", "World!");
            Assert.AreEqual(Expected, result);
        }
    }
}
