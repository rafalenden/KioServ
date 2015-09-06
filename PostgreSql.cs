using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using System.Threading;

namespace KioServ
{
    class PostgreSql
    {
        private static Process p = new Process();

        public static void Start()
        {
            Thread t = new Thread(new ThreadStart(start));
            t.Start();
        }

        private static void start()
        {
            p.StartInfo.FileName = @"pgsql/bin/pg_ctl.exe";
            p.StartInfo.Arguments = "-D \"pgsql/data\" start";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
        }

        public static void Stop()
        {
            if (IsStarted())
            {
                p.StartInfo.FileName = @"pgsql/bin/pg_ctl.exe";
                p.StartInfo.Arguments = "-D \"pgsql/data\" stop";
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.Start();
            }
        }

        public static bool IsStarted()
        {
            return Process.GetProcessesByName("postgres").Length > 0;
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
