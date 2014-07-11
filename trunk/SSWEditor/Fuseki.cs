using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SSWEditor
{
    class Fuseki
    {
        public static void Start()
        {
            Stop();
            List<string> arguments = new List<string>();
            arguments.Add("-Xmx1200M");
            arguments.Add("-jar fuseki/fuseki-server.jar");
            arguments.Add("--update");
            arguments.Add("--port=" + MainForm.config.FusekiPort);
            arguments.Add("--pages fuseki/pages");
            arguments.Add("--loc \"" + MainForm.documentRoot + "\"");
            arguments.Add("/ds");

            bool useShellExecute = false;
            if (MainForm.config.ShowFusekiConsole == true) useShellExecute = true;

            var processInfo = new ProcessStartInfo("java.exe", string.Join(" ", arguments))
                                  {
                                      CreateNoWindow = true,
                                      UseShellExecute = useShellExecute
                                  };
            Process proc = Process.Start(processInfo);
            if (proc == null)
            {
                throw new Exception("error during staring fuseki");
            }
        }

        public static void Stop()
        {
            var query =
                "SELECT ProcessId "
                + "FROM Win32_Process "
                + "WHERE Name = 'java.exe' "
                + "AND CommandLine LIKE '%fuseki-server.jar%'";

            List<Process> servers = null;
            using (var results = new ManagementObjectSearcher(query).Get())
                servers = results.Cast<ManagementObject>()
                                 .Select(mo => Process.GetProcessById((int)(uint)mo["ProcessId"]))
                                 .ToList();

            foreach (Process process in servers)
            {
                process.Kill();
            }
        }
    }
}
