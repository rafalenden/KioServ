using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using System.Windows.Forms;
using System.Threading;

namespace KioServ
{
    class MySql
    {
        private static string processPath = "mysql/bin/KioServ-mysql.exe";
        private static string processName = "KioServ-mysql";

        private static Thread t = new Thread(CriticalStop);

        //public static void Start()
        //{
        //    Process p = new Process();
        //    p.StartInfo.FileName = processPath;
        //    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        //    p.Start();
        //}

        public static void Start()
        {
            Thread t = new Thread(new ThreadStart(start));
            t.Start();
        }

        private static void start()
        {
            Kio.StartProcess(processPath);
        }

        public static void Stop()
        {
            if (IsStarted())
            {
                Process p = new Process();
                p.StartInfo.FileName = "mysql/bin/mysqladmin.exe";
                p.StartInfo.Arguments = "--user=root --password=root shutdown";
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.Start();

                if (t.IsAlive)
                {
                    t.Abort();
                    t = null;
                }

                t = new Thread(CriticalStop);
                t.Start();
            }
        }

        public static void CriticalStop()
        {
            Thread.Sleep(2000);

            if (IsStarted())
            {
                Thread.Sleep(5000);

                if (IsStarted())
                {
                    Kio.KillProcess(processName);

                    MessageBox.Show(
                        Kio.Translate("MySQL login data is incorrect.\r\nDatabase process was killed."),
                        Kio.Translate("Error"),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            t.Abort();
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
