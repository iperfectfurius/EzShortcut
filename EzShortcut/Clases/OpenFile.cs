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
    }
}
