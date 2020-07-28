using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World", HelloWorld.Program.SimpleTestMethod("Hello", "World"));
        }
    }
}
