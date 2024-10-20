﻿using EpohWin.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace EpohWin.Test.LibTest
{
    [TestClass]
    public class SQLiteHelperTest
    {
        [TestMethod]
        public void TestSelect()
        {
            var req = new SQLiteReq
            {
                Sql = "select #p1 as i, #p2 as s, #p3 as n",
                Args = new object[] { 1, "1", null },
                File = $"{typeof(SQLiteHelperTest).FullName}.sqlite"
            };
            var reqStr = JsonConvert.SerializeObject(req);
            var ret = SQLiteHelper.Execute(reqStr);
            Assert.IsNotNull(ret);
        }
    }
}