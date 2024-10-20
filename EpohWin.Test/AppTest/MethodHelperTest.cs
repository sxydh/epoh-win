using EpohWin.App;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EpohWin.Test.AppTest
{
    [TestClass]
    public class MethodHelperTest
    {
        [TestMethod]
        public void TestGetMethodId()
        {
            MethodHelper.GetMethodId("say-hello", out _);
        }
    }
}