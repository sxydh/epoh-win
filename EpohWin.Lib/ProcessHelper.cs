using System.Diagnostics;

namespace EpohWin.Lib
{
    public class ProcessHelper
    {
        public static void Kill(string _)
        {
            try
            {
                Process.GetCurrentProcess().Kill();
            }
            catch
            {
                // ignored
            }
        }

        public static string GetMethodIdMap()
        {
            return $"lib/process-kill={typeof(ProcessHelper).FullName}#Kill";
        }
    }
}