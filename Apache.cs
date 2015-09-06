using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using System.Windows.Forms;
using System.Threading;

namespace KioServ
{
    class Apache
    {
        public static double Timeout = 1;
        //private static Process Instance = new Process();
        //private static ProcessStartInfo StartInfo = new ProcessStartInfo(@"apache\bin\kioserv-apache.exe");

        private static string processPath = "apache/bin/KioServ-apache.exe";
        private static string processName = "KioServ-apache";

        public static void Start()
        {
            Thread t = new Thread(new ThreadStart(start));
            t.Start();
        }

        private static void start()
        {
            Kio.StartProcess(processPath);

            //StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //Instance.StartInfo = StartInfo;
            //Instance.Start();
        }

        public static void Stop()
        {
            Kio.KillProcess(processName);

            //p.StartInfo.Arguments = "/C cd \"" + @"D:\Akademia\Uni\Programowanie 3\Projekty\KioServ\KioServ\bin\Debug\apache\bin\" + "kioserv-apache.exe\" -k shutdown";
        }

        public static bool IsWaiting()
        {
            return Process.GetProcessesByName(processName).Length == 1 && Timeout > 0;
        }

        public static bool IsStarted()
        {
            return Process.GetProcessesByName(processName).Length > 0;
        }

        public static void Restart()
        {
            if (IsStarted())
            {
                Stop();
                Start();
            }
        }
    }
}
