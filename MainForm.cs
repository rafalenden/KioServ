using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;
using TestCSharp;


namespace KioServ
{
    
    public partial class MainForm : Form
    {
        SettingsForm settingsForm;

        const int NO_ACTION = 0;
        const int RESTORE_MAIN_WINDOW = 1;
        const int OPEN_CONTEXT_MENU = 2;
        const int OPEN_SETTINGS_WINDOW = 3;
        const int START_ALL = 4;
        const int STOP_ALL = 5;

        public MainForm()
        {
            InitializeComponent();

            try
            {
                if (Settings.App.LocationX > 0 && Settings.App.LocationX < Screen.PrimaryScreen.Bounds.Width
                    && Settings.App.LocationY > 0 && Settings.App.LocationX < Screen.PrimaryScreen.Bounds.Height)
                {
                    Location = new Point(Settings.App.LocationX, Settings.App.LocationY);
                }

                if (Settings.App.HideAtStartup)
                {
                    HideMainWindow();
                }

                Kio.Translate(this);

                Settings.Apache.UpdateConfigFile();
                Settings.MySql.UpdateConfigFile();
                Settings.PostgreSql.UpdateConfigFile();
                Settings.Php.UpdateConfigFile();

                DirectoryInfo di = new DirectoryInfo("php");
                DirectoryInfo[] phpVersions = di.GetDirectories();

                for (int i = 0; i < phpVersions.Length; i++ )
                {
                    if (File.Exists("php/" + phpVersions[i] + "/apache2_2.dll"))
                    {
                        comboBoxPhpVersion.Items.Add(phpVersions[i].Name);
                        versionToolStripMenuItem.DropDownItems.Add(phpVersions[i].Name);
                        versionToolStripMenuItem.DropDownItems[i].Click += new System.EventHandler(this.versionToolStripMenuItem_Click);

                        if (Settings.Php.Version == versionToolStripMenuItem.DropDownItems[i].Text)
                        {
                            ToolStripMenuItem item = (ToolStripMenuItem)versionToolStripMenuItem.DropDownItems[i];
                            item.Checked = true;
                        }
                    }
                }

                comboBoxPhpVersion.Text = Settings.Php.Version;

                if (Settings.Apache.Started)
                {
                    Apache.Start();
                }

                if (Settings.MySql.Started)
                {
                    MySql.Start();
                }

                if (Settings.PostgreSql.Started)
                {
                    PostgreSql.Start();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Kio.Translate("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetWorkingSet(750000, 300000);
        }

        private void openSettingsWindow()
        {
            settingsForm = new SettingsForm(this);

            int x = this.Location.X + (this.Size.Width - settingsForm.Size.Width) / 2;
            int y = this.Location.Y + (this.Size.Height - settingsForm.Size.Height) / 2;

            settingsForm.Location = new Point(x, y);
            settingsForm.ShowDialog();
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            comboBoxPhpVersion.Text = clickedItem.Text;
            //changePhpVersion(clickedItem.Text);
        }

        private void ShowMainWindow()
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
            //ShowInTaskbar = true;
        }

        private void HideMainWindow()
        {
            Hide();
            WindowState = FormWindowState.Minimized;
            SetWorkingSet(750000, 300000);
            //ShowInTaskbar = false;
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                HideMainWindow();
            }
        }

        private void timerRefreshStatus_Tick(object sender, EventArgs e)
        {
            // Apache is running
            if (Apache.IsStarted())
            {
                buttonStopApache.Enabled = true;
                buttonStartApache.Enabled = false;

                groupBoxApache.Text = "Apache (" + Kio.Translate("Running") + ")";

                trayIcon.Text = "Apache: " + Kio.Translate("Running");
            }
            // Apache is stopped
            else
            {
                buttonStopApache.Enabled = false;
                buttonStartApache.Enabled = true;

                groupBoxApache.Text = "Apache (" + Kio.Translate("Stopped") + ")";

                trayIcon.Text = "Apache: " + Kio.Translate("Stopped");
            }

            // MySQL is running
            if (MySql.IsStarted())
            {
                buttonStopMySql.Enabled = true;
                buttonStartMySql.Enabled = false;

                groupBoxMySql.Text = "MySQL (" + Kio.Translate("Running") + ")";

                trayIcon.Text += "\r\nMySQL: " + Kio.Translate("Running");
            }
            // MySQL is stopped
            else
            {
                buttonStopMySql.Enabled = false;
                buttonStartMySql.Enabled = true;

                groupBoxMySql.Text = "MySQL (" + Kio.Translate("Stopped") + ")";

                trayIcon.Text += "\r\nMySQL: " + Kio.Translate("Stopped");
            }

            // PostgreSQL is running
            if (PostgreSql.IsStarted())
            {
                buttonStopPgSql.Enabled = true;
                buttonStartPgSql.Enabled = false;

                groupBoxPgSql.Text = "PostgreSQL (" + Kio.Translate("Running") + ")";

                trayIcon.Text += "\r\nPgSQL: " + Kio.Translate("Running");
            }
            // PostgreSQL is stopped
            else
            {
                buttonStopPgSql.Enabled = false;
                buttonStartPgSql.Enabled = true;

                groupBoxPgSql.Text = "PostgreSQL (" + Kio.Translate("Stopped") + ")";

                trayIcon.Text += "\r\nPgSQL: " + Kio.Translate("Stopped");
            }
        }

        private void toolStripStatusLabelLink_Click(object sender, EventArgs e)
        {
            Process.Start("http://serv.kiofol.com");
        }

        private void comboBoxPhpVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            changePhpVersion(comboBoxPhpVersion.Text);
        }

        private void changePhpVersion(string version)
        {
            Settings.Ini.Set("php", "version", version);
            Settings.Ini.SaveToFile();

            //toolStripStatusLabelPhp.Text = "PHP: " + FileVersionInfo.GetVersionInfo(@"php\" + Settings.Php.Version + @"\apache2_2.dll").ProductVersion;

            Settings.Apache.UpdateConfigFile();
            Settings.Php.UpdateConfigFile();

            // Restarting Apache and MySQL
            Apache.Restart(); // Przy uruchomieniu od razu restartuje
        }

        #region Link labels

        private void linkLabelApacheConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("settings/httpd.conf");
        }

        private void linkLabelApacheLogs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("apache/logs/error.log");
        }

        private void linkLabelMySqlConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("settings/my.ini");
        }

        private void linkLabelMySqlLogs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mysql/data/log.txt");
        }

        private void linkLabelLocalhost_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://localhost:" + Settings.Apache.Port);
        }

        private void linkLabelDocumentRoot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Settings.Apache.DocumentRoot);
        }

        private void linkLabelPMA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://localhost:" + Settings.Apache.Port + "/phpmyadmin");
        }

        private void linkLabelPhpInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://localhost:" + Settings.Apache.Port + "/phpinfo");
        }

        private void linkLabelPhpConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("settings/php.ini");
        }

        private void linkLabelPgSqlConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("settings/postgresql.conf");
        }

        private void linkLabelPgSqlLogs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("pgsql/data/pg_log/postgresql.log");
        }

        private void linkLabelPGA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // User: postgres
            // Pass: postgres
            Process.Start("http://localhost:" + Settings.Apache.Port + "/phppgadmin");
        }

        private void linkLabelPgAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("pgsql/bin/pgAdmin3.exe");
        }

        #endregion

        #region Buttons

        private void buttonStartApache_Click(object sender, EventArgs e)
        {
            Apache.Start();
            Settings.Apache.Started = true;
        }

        private void buttonStopApache_Click(object sender, EventArgs e)
        {
            Apache.Stop();
            Settings.Apache.Started = false;
        }

        private void buttonStartMySql_Click(object sender, EventArgs e)
        {
            MySql.Start();
            Settings.MySql.Started = true;
        }

        private void buttonStopMySql_Click(object sender, EventArgs e)
        {
            MySql.Stop();
            Settings.MySql.Started = false;
        }

        private void buttonStartPgSql_Click(object sender, EventArgs e)
        {
            PostgreSql.Start();
            Settings.PostgreSql.Started = true;
        }

        private void buttonStopPgSql_Click(object sender, EventArgs e)
        {
            PostgreSql.Stop();
            Settings.PostgreSql.Started = false;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            openSettingsWindow();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            HideMainWindow();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Tray icon
 
        private void doAction(int action, string path)
        {
            switch (action)
            {
                // Show/Hide main window
                case 1:
                    if (WindowState == FormWindowState.Minimized)
                    {
                        ShowMainWindow();
                    }
                    else
                    {
                        if (FindWindowLib.IsTopWindow(this.Handle) == true)
                        {
                            HideMainWindow();
                        }
                        else
                        {
                            Activate();
                        }
                    }
                    break;
                // Show tray icon context menu
                case 2:
                    showTrayMenu();
                    break;
                // Open settings window
                case 3:
                    openSettingsWindow();
                    break;
                // Start all
                case 4:
                    Apache.Start();
                    MySql.Start();
                    PostgreSql.Start();
                    break;
                // Stop all
                case 5:
                    Apache.Stop();
                    MySql.Stop();
                    PostgreSql.Stop();
                    break;
                // Restart all
                case 6:
                    Apache.Restart();
                    MySql.Restart();
                    PostgreSql.Restart();
                    break;
                // Open localhost in browser
                case 7:
                    Process.Start("http://localhost:" + Settings.Apache.Port);
                    break;
                // Open root directory
                case 8:
                    Process.Start(Settings.Apache.DocumentRoot);
                    break;
                // Go to phpMyAdmin
                case 9:
                    Process.Start("http://localhost:" + Settings.Apache.Port + "/phpmyadmin");
                    break;
                // Go to phpPgAdmin
                case 10:
                    Process.Start("http://localhost:" + Settings.Apache.Port + "/phppgadmin");
                    break;
                // Open file, directory or url
                case 11:
                    try
                    {
                        Process.Start(path);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, Kio.Translate("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                // Exit KioServ
                case 12:
                    Close();
                    break;
             }
        }

        private void trayIcon_MouseDown(object sender, MouseEventArgs e)
        {
            // Left button
            if (e.Button == MouseButtons.Left)
            {
                doAction(Settings.App.LMouseButton, Settings.App.LMouseButtonPath);
            }
            // Right button 
            else if (e.Button == MouseButtons.Right)
            {
                doAction(Settings.App.RMouseButton, Settings.App.RMouseButtonPath);
            }
            // Middle button
            else if (e.Button == MouseButtons.Middle)
            {
                doAction(Settings.App.MMouseButton, Settings.App.MMouseButtonPath);
            }
        }

        private void showTrayMenu()
        {
            trayIcon.ContextMenuStrip = trayMenu;

            if (Apache.IsStarted())
            {
                startStopApacheToolStripMenuItem.Text = "Stop";
                startStopApacheToolStripMenuItem.Image = global::KioServ.Properties.Resources.stop;
            }
            else
            {
                startStopApacheToolStripMenuItem.Text = "Start";
                startStopApacheToolStripMenuItem.Image = global::KioServ.Properties.Resources.resultset_next;
            }

            if (MySql.IsStarted())
            {
                startStopMySqlToolStripMenuItem.Text = "Stop";
                startStopMySqlToolStripMenuItem.Image = global::KioServ.Properties.Resources.stop;
            }
            else
            {
                startStopMySqlToolStripMenuItem.Text = "Start";
                startStopMySqlToolStripMenuItem.Image = global::KioServ.Properties.Resources.resultset_next;
            }

            if (PostgreSql.IsStarted())
            {
                startStopPgSqlToolStripMenuItem.Text = "Stop";
                startStopPgSqlToolStripMenuItem.Image = global::KioServ.Properties.Resources.stop;
            }
            else
            {
                startStopPgSqlToolStripMenuItem.Text = "Start";
                startStopPgSqlToolStripMenuItem.Image = global::KioServ.Properties.Resources.resultset_next;
            }

            if (WindowState == FormWindowState.Minimized)
            {
                restoreToolStripMenuItem.Text = ("Show main window");
            }
            else
            {
                restoreToolStripMenuItem.Text = ("Hide main window");
            }

            startAllToolStripMenuItem.Enabled = Apache.IsStarted() && MySql.IsStarted() && PostgreSql.IsStarted() ? false : true;
            stopAllToolStripMenuItem.Enabled = !Apache.IsStarted() && !MySql.IsStarted() && !PostgreSql.IsStarted() ? false : true;

            DirectoryInfo di = new DirectoryInfo("php");
            DirectoryInfo[] phpVersions = di.GetDirectories();

            for (int i = 0; i < phpVersions.Length; i++)
            {
                if (File.Exists("php/" + phpVersions[i] + "/apache2_2.dll"))
                {
                    ToolStripMenuItem item = (ToolStripMenuItem)versionToolStripMenuItem.DropDownItems[i];

                    if (Settings.Php.Version == versionToolStripMenuItem.DropDownItems[i].Text)
                    {
                        item.Checked = true;
                    }
                    else
                    {
                        item.Checked = false;
                    }
                }
            }

            Kio.Translate(apacheToolStripMenuItem);
            Kio.Translate(mySqlToolStripMenuItem);
            Kio.Translate(postgreSqlToolStripMenuItem);
            Kio.Translate(phpToolStripMenuItem);

            Kio.Translate(trayMenu);
        }

        #endregion

        #region ToolStripMenu items

        private void retoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowMainWindow();
            }
            else
            {
                HideMainWindow();
            }
        }

        /*************************************/

        private void goToStartPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://localhost:" + Settings.Apache.Port);
        }

        private void goToDocumentRootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Settings.Apache.DocumentRoot);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openSettingsWindow();
        }

        /*************************************/

        private void startStopApacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Apache.IsStarted())
            {
                Apache.Stop();
            }
            else
            {
                Apache.Start();
            }

            Settings.Apache.Started = !Apache.IsStarted();
        }

        private void configurationFileApacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("settings/httpd.conf");
        }

        private void logsApacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("apache/logs/error.log");
        }

        private void startStopMySqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MySql.IsStarted())
            {
                MySql.Stop();
            }
            else
            {
                MySql.Start();
            }

            Settings.MySql.Started = !MySql.IsStarted();
        }

        private void configurationFileMySqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("settings/my.ini");
        }

        private void logsMySqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("mysql/data/log.txt");
        }

        private void phpMyAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://localhost:" + Settings.Apache.Port + "/phpmyadmin");
        }

        private void startStopPgSqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PostgreSql.IsStarted())
            {
                PostgreSql.Stop();
            }
            else
            {
                PostgreSql.Start();
            }

            Settings.PostgreSql.Started = !PostgreSql.IsStarted();
        }

        private void configurationFilePgSqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("settings/postgresql.conf");
        }

        private void logsPgSqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("pgsql/data/pg_log/postgresql.log");
        }

        private void phpPgAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://localhost:" + Settings.Apache.Port + "/phppgadmin");
        }

        private void pgAdminIIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://localhost:" + Settings.Apache.Port + "/phpmyadmin");
        }

        private void configurationFilePhpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("settings/php.ini");
        }

        private void phpInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://localhost:" + Settings.Apache.Port + "/phpinfo");
        }

        /*************************************/

        private void startAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apache.Start();
            MySql.Start();
            PostgreSql.Start();

            Settings.Apache.Started = true;
            Settings.MySql.Started = true;
            Settings.PostgreSql.Started = true;
        }

        private void stopAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apache.Stop();
            MySql.Stop();
            PostgreSql.Stop();

            Settings.Apache.Started = false;
            Settings.MySql.Started = false;
            Settings.PostgreSql.Started = false;
        }

        private void restartAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apache.Restart();
            MySql.Restart();
            PostgreSql.Restart();
        }

        /*************************************/

        private void exitTrayMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Apache.Stop();
            MySql.Stop();
            PostgreSql.Stop();

            Settings.Ini.Set("app", "locationX", Location.X.ToString());
            Settings.Ini.Set("app", "locationY", Location.Y.ToString());
            Settings.Ini.SaveToFile();
        }

        public static void SetWorkingSet(int lnMaxSize, int lnMinSize)
        {
            System.Diagnostics.Process loProcess = System.Diagnostics.Process.GetCurrentProcess();
            loProcess.MaxWorkingSet = (IntPtr)lnMaxSize;
            loProcess.MinWorkingSet = (IntPtr)lnMinSize;
            //long lnValue = loProcess.WorkingSet; // see what the actual value
        }

    }
}