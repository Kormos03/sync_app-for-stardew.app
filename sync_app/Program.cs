using System;
using System.Diagnostics;
using System.Threading;

namespace ProcessMonitorConsoleApp
{
    public class Program
    {
        private static Timer timer;
        private static string processName = "StardewModdingAPI"; // The name of the process to monitor

        static void Main(string[] args)
        {
            Console.WriteLine("Process Monitor Console App started.");
            timer = new Timer(CheckProcess, null, 0, 5000); // Check every 5 seconds ,Check every 10 minutes 600000 in the future
            Console.WriteLine("Press [Enter] to exit...");
            Console.ReadLine(); // Keeps the application running
        }

        private static void CheckProcess(object state)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            if (processes.Length > 0)
            {
                RunScript();
            }
        }

        private static void RunScript()
        {
            // Code to run your script goes here
            // For example, you could start another process
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("test_script.bat");
                startInfo.WindowStyle = ProcessWindowStyle.Hidden; // Optional: Hide the script window
                Process.Start(startInfo);
                Console.WriteLine("Script executed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error running script: {ex.Message}");
            }
        }
    }
}
