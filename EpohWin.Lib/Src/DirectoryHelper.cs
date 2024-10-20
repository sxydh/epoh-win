using System.IO;

namespace EpohWin.Lib
{
    public class DirectoryHelper
    {
        public static string Current()
        {
            return Directory.GetCurrentDirectory();
        }

        public static string GetMethodIdMap()
        {
            var ret = "";
            ret += $"lib/dir-current={typeof(DirectoryHelper).FullName}#Current";
            return ret;
        }
    }
}