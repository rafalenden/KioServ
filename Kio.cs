using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using System.Windows.Forms;
using System.IO;

namespace KioServ
{
    class Kio
    {
        public static string Path = Application.StartupPath.Replace(@"\", "/");
        //public static IniParser SettingsFile = new IniParser(@"settings\kioserv.ini");
        public static IniParser LangFile = new IniParser(@"lang\" + Settings.Ini.Get("app", "lang") + ".ini");

        public static string PhpVersion = "5";


        public static void ChangeLang(string lang)
        {
            LangFile = new IniParser(@"lang\" + lang + ".ini");
        }

        public static void KillProcess(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);

            foreach (Process process in processes)
            {
                process.Kill();
            }
        }

        public static void StartProcess(string fileName)
        {
            Process p = new Process();
            p.StartInfo.FileName = fileName;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
        }

        public static void StartProcess(string fileName, string arguments)
        {
            Process p = new Process();
            p.StartInfo.FileName = fileName;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
        }

        public static string Translate(string text)
        {
            string t = LangFile.GetSetting(text);
            return t == null ? text : t;
        }

        public static void Translate(Form form)
        {
            form.Text = Translate(form.Text);

            foreach (Control c in form.Controls)
            {
                Translate(c);
            }
        }

        public static void Translate(Control ctrl)
        {
            if (ctrl.AccessibleDescription == "Disable translation")
            {
                return;
            }

            switch (ctrl.GetType().Name)
            {
                case "Label":
                case "Button":
                case "CheckBox":
                case "LinkLabel":
                    ctrl.Text = Translate(ctrl.Text);
                    break;
                case "GroupBox":
                    ctrl.Text = Translate(ctrl.Text);

                    foreach (Control c2 in ctrl.Controls)
                    {
                        Translate(c2);
                    }
                    break;
                case "ComboBox":
                    ComboBox cb = (ComboBox)ctrl;
                    int sel = cb.SelectedIndex;

                    object[] items = new object[cb.Items.Count];
                    cb.Items.CopyTo(items, 0);
                    cb.Items.Clear();

                    foreach (object item in items)
                    {
                        cb.Items.Add(Kio.Translate(item.ToString()));
                    }

                    cb.SelectedIndex = sel;
                    break;
            }
        }

        public static void Translate(ContextMenuStrip menu)
        {
            foreach (ToolStripItem item in menu.Items)
            {
                Translate(item);
            }
        }

        public static void Translate(ToolStripItem item)
        {
            item.Text = Translate(item.Text);
        }

        public static void Translate(ToolStripMenuItem item)
        {
            foreach (ToolStripItem item2 in item.DropDown.Items)
            {
                Translate(item2);
            }
        }
    }
}
