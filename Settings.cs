using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using KioServ;

namespace Settings
{
    class Apache
    {
        private static bool started;
        public static bool Started
        {
            set
            {
                started = value;
                Ini.Set("apache", "started", started ? "1" : "0");
                Ini.SaveToFile();
            }
            get { return Ini.Get("apache", "started") == "1" ? true : false; }
        }

        private static string documentRoot;
        public static string DocumentRoot
        {
            set { documentRoot = value; }
            get { return Ini.Get("apache", "documentRoot"); }
        }

        private static string port;
        public static string Port
        {
            set { port = value; }
            get { return Ini.Get("apache", "port"); }
        }

        public static void UpdateConfigFile()
        {
            string s = File.ReadAllText(@"settings\httpd.conf");

            string lol = Settings.Apache.DocumentRoot[1] == ':'
                ? DocumentRoot
                : Kio.Path + "/" + DocumentRoot;

            s = s.Replace("{documentRoot}", lol);
            s = s.Replace("{port}", Port);
            s = s.Replace("{path}", Kio.Path);
            s = s.Replace("{phpVersion}", Php.Version);
            File.WriteAllText(@"apache\conf\httpd.conf", s);
        }
    }

    class MySql
    {
        private static bool started;
        public static bool Started
        {
            set
            {
                started = value;
                Ini.Set("mysql", "started", started ? "1" : "0");
                Ini.SaveToFile();
            }
            get { return Ini.Get("mysql", "started") == "1" ? true : false; }
        }

        private static string port;
        public static string Port
        {
            set { port = value; }
            get { return Ini.Get("mysql", "port"); }
        }

        public static void UpdateConfigFile()
        {
            string s = File.ReadAllText(@"settings\my.ini");
            s = s.Replace("{port}", Port);
            File.WriteAllText(@"mysql\my.ini", s);
        }
    }

    class PostgreSql
    {
        private static bool started;
        public static bool Started
        {
            set
            {
                started = value;
                Ini.Set("postgresql", "started", started ? "1" : "0");
                Ini.SaveToFile();
            }
            get { return Ini.Get("postgresql", "started") == "1" ? true : false; }
        }

        private static string port;
        public static string Port
        {
            set { port = value; }
            get { return Ini.Get("postgresql", "port"); }
        }

        public static void UpdateConfigFile()
        {
            string s = File.ReadAllText("pgsql/data/postgresql.conf");
            s = s.Replace("{port}", Port);
            File.WriteAllText("pgsql/data/postgresql.conf", s);
        }
    }

    class Php
    {
        //public static string SafeMode = Ini.Get("php", "safeMode");
        //public static string RegisterGlobals = Ini.Get("php", "registerGlobals");

        private static string version;
        public static string Version
        {
            set { version = value; }
            get { return Ini.Get("php", "version"); }
        }

        public static void UpdateConfigFile()
        {
            string s = File.ReadAllText(@"settings\php.ini");
            s = s.Replace("{phpVersion}", Version);
            s = s.Replace("{path}", Kio.Path);
            s = s.Replace("{mySqlPort}", MySql.Port);
            File.WriteAllText(@"php\" + Settings.Php.Version + @"\php.ini", s);
        }
    }

    class App
    {
        private static bool hideAtStartup;
        public static bool HideAtStartup
        {
            set { hideAtStartup = value; }
            get { return Ini.Get("app", "hideAtStartup") != "1" ? false : true; }
        }

        private static string lang;
        public static string Lang
        {
            set { lang = value; }
            get { return Ini.Get("app", "lang"); }
        }

        private static int lMouseButton;
        public static int LMouseButton
        {
            set { lMouseButton = value; }
            get { return Convert.ToInt16(Ini.Get("app", "lMouseButton")); }
        }

        private static string lMouseButtonPath;
        public static string LMouseButtonPath
        {
            set { lMouseButtonPath = value; }
            get { return Ini.Get("app", "lMouseButtonPath"); }
        }

        private static int rMouseButton;
        public static int RMouseButton
        {
            set { rMouseButton = value; }
            get { return Convert.ToInt16(Ini.Get("app", "rMouseButton")); }
        }

        private static string rMouseButtonPath;
        public static string RMouseButtonPath
        {
            set { rMouseButtonPath = value; }
            get { return Ini.Get("app", "rMouseButtonPath"); }
        }

        private static int mMouseButton;
        public static int MMouseButton
        {
            set { mMouseButton = value; }
            get { return Convert.ToInt16(Ini.Get("app", "mMouseButton")); }
        }

        private static string mMouseButtonPath;
        public static string MMouseButtonPath
        {
            set { mMouseButtonPath = value; }
            get { return Ini.Get("app", "mMouseButtonPath"); }
        }

        private static int locationX;
        public static int LocationX
        {
            set { locationX = value; }
            get { return Convert.ToInt16(Ini.Get("app", "locationX")); }
        }

        private static int locationY;
        public static int LocationY
        {
            set { locationY = value; }
            get { return Convert.ToInt16(Ini.Get("app", "locationY")); }
        }
    }

    class Ini
    {
        public static IniParser File = new IniParser(@"settings\kioserv.ini");

        public static string Get(string sectionName, string settingName)
        {
            return File.GetSetting(sectionName, settingName);
        }

        public static void Set(string sectionName, string settingName, string settingValue)
        {
            File.AddSetting(sectionName, settingName, settingValue);
        }

        public static void SaveToFile()
        {
            File.SaveSettings();
            File = null;
            File = new IniParser(@"settings\kioserv.ini");
        }
        public static void SaveToFile(string newFilePath)
        {
            File.SaveSettings(newFilePath);
            File = null;
            File = new IniParser(@"settings\kioserv.ini");
        }

        public static void ReadAll()
        {

        }
    }
}
