using EpohWin.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EpohWin.Test.LibTest
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void TestSayHello()
        {
            var ret = HelloWorld.SayHello("Jack");
            Assert.IsTrue(ret == "Hello Jack");
        }
    }
}