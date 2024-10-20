using EpohWin.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EpohWin.Test.LibTest
{
    [TestClass]
    public class DirectoryHelperTest
    {
        [TestMethod]
        public void TestCurrent()
        {
            var current = DirectoryHelper.Current();
            Assert.IsNotNull(current);
        }
    }
}