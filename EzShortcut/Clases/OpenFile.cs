using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzShortcut.Clases
{
    internal class OpenFile
    {
        public static void OpenFiles(string Route)
        {
            try
            {
                Process.Start(new ProcessStartInfo(Route) { UseShellExecute = true });
            }
            catch
            {
                Debug.Write("Error");
            }

        }
        public static void ExecuteScript(string script)
        {
            var wt = new ProcessStartInfo
            {
                FileName = "wt.exe",
                LoadUserProfile = true,
                UseShellExecute = true,
                Arguments = script
            };
            Process.Start(wt);
        }
        public static void ExecuteWithElevatedPermissions(string arguments)
        {
            var process = new ProcessStartInfo
            {
                FileName = arguments,
                LoadUserProfile = true,
                UseShellExecute = true,
                Verb = "runas",
            };
            Process.Start(process);
        }
    }
}
