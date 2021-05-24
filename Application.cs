
namespace ProcessKiller
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Management;
    using System.Threading;

    using ProcessKiller.Core;

    internal static class Application
    {
        private static readonly TimeSpan Interval = TimeSpan.FromSeconds(5);

        private static readonly string[] ProcessFileNames =
        {
            "notepad.exe",
        };

        internal static void Main()
        {
            while (true)
            {
                KillProcesses();
                Thread.Sleep(Interval);
            }
        }

        private static void KillProcesses()
        {
            foreach (var processId in EnumerateProcessIds())
            {
                try
                {
                    Process.GetProcessById(processId).Kill();
                }
                catch
                {
                    continue;
                }
            }
        }

        private static IEnumerable<int> EnumerateProcessIds()
        {
            var query = "SELECT ProcessID FROM Win32_Process WHERE " + ProcessFileNames
                .Select(fileName => $@"(ExecutablePath LIKE '%\\{fileName}')").Join(" OR ");

            using (var managementObjectSearcher = new ManagementObjectSearcher(query))
            using (var managementObjectCollection = managementObjectSearcher.Get())
            {
                foreach (var managementBaseObject in managementObjectCollection)
                {
                    yield return Convert.ToInt32(managementBaseObject["ProcessID"]);
                }
            }
        }
    }
}
