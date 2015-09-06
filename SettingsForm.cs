using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Text.RegularExpressions;

using System.Diagnostics;

namespace KioServ
{
    public partial class SettingsForm : Form
    {
        private Form mainForm;

        public SettingsForm(Form mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            try
            {
                Kio.Translate(this);

                // Get languages
                DirectoryInfo di = new DirectoryInfo("lang");
                FileInfo[] rgFiles = di.GetFiles("*.ini");
                foreach (FileInfo fi in rgFiles)
                {
                    comboBoxLang.Items.Add(fi.Name.Substring(0, fi.Name.Length - 4));
                }

                string docRoot = !Settings.Apache.DocumentRoot.StartsWith(Kio.Path + "/") && Settings.Apache.DocumentRoot[1] == ':'
                    ? Settings.Apache.DocumentRoot
                    : Kio.Path + "/" + Settings.Apache.DocumentRoot;

                textBoxDocumentRoot.Text = docRoot.Replace('/', '\\');
                folderBrowserDialogDocumentRoot.SelectedPath = textBoxDocumentRoot.Text;

                textBoxApachePort.Text = Settings.Apache.Port;
                textBoxMySqlPort.Text = Settings.MySql.Port;
                textBoxPgSqlPort.Text = Settings.PostgreSql.Port;

                comboBoxLang.Text = Settings.App.Lang;

                checkBoxHideAtStartup.Checked = Settings.App.HideAtStartup;

                object[] items = new object[comboBoxLButtonTray.Items.Count];
                comboBoxLButtonTray.Items.CopyTo(items, 0);

                comboBoxMButtonTray.Items.AddRange(items);
                comboBoxRButtonTray.Items.AddRange(items);

                comboBoxLButtonTray.SelectedIndex = Settings.App.LMouseButton;
                comboBoxMButtonTray.SelectedIndex = Settings.App.MMouseButton;
                comboBoxRButtonTray.SelectedIndex = Settings.App.RMouseButton;

                textBoxLButtonPath.Text = Settings.App.LMouseButtonPath;
                textBoxMButtonPath.Text = Settings.App.MMouseButtonPath;
                textBoxRButtonPath.Text = Settings.App.RMouseButtonPath;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Kio.Translate("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDocumentRoot_Click(object sender, EventArgs e)
        {
            folderBrowserDialogDocumentRoot.ShowDialog();

            if (folderBrowserDialogDocumentRoot.SelectedPath != "")
            {
                textBoxDocumentRoot.Text = folderBrowserDialogDocumentRoot.SelectedPath;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string portPattern = @"^\d{1,5}$";

            if (!Regex.IsMatch(textBoxApachePort.Text, portPattern))
            {
                MessageBox.Show(Kio.Translate("Apache port is incorrect."), Kio.Translate("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(textBoxMySqlPort.Text, portPattern))
            {
                MessageBox.Show(Kio.Translate("MySQL port is incorrect."), Kio.Translate("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Directory.Exists(textBoxDocumentRoot.Text))
            {
                MessageBox.Show(Kio.Translate("Document root directory does'n exists."), Kio.Translate("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBoxLang.SelectedItem.ToString() != Settings.App.Lang)
                {
                    MessageBox.Show(Kio.Translate("Language will be updated after you restart KioServ."), Kio.Translate("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Apache settings
                Settings.Ini.Set("apache", "documentRoot", textBoxDocumentRoot.Text.Replace('\\', '/').Replace(Kio.Path + "/", ""));
                Settings.Ini.Set("apache", "port", textBoxApachePort.Text);

                // MySQL settings 
                Settings.Ini.Set("mysql", "port", textBoxMySqlPort.Text);

                // KioServ settings
                Settings.Ini.Set("app", "hideAtStartup", checkBoxHideAtStartup.Checked ? "1" : "0");
                Settings.Ini.Set("app", "lang", comboBoxLang.Text);

                Settings.Ini.Set("app", "lMouseButton", comboBoxLButtonTray.SelectedIndex.ToString());
                Settings.Ini.Set("app", "rMouseButton", comboBoxRButtonTray.SelectedIndex.ToString());
                Settings.Ini.Set("app", "mMouseButton", comboBoxMButtonTray.SelectedIndex.ToString());
                
                Settings.Ini.Set("app", "lMouseButtonPath", textBoxLButtonPath.Text);
                Settings.Ini.Set("app", "rMouseButtonPath", textBoxRButtonPath.Text);
                Settings.Ini.Set("app", "mMouseButtonPath", textBoxMButtonPath.Text);
                

                Settings.Ini.SaveToFile();

                Settings.Apache.UpdateConfigFile();
                Settings.MySql.UpdateConfigFile();
                Settings.Php.UpdateConfigFile();

                // Restarting Apache and MySQL
                Apache.Restart();
                MySql.Restart();
                PostgreSql.Restart();

                //Kio.ChangeLang(comboBoxLang.SelectedItem.ToString());
                //Kio.Translate(this);
                //Kio.Translate(mainForm);

                Close();
            }
        }

        private void comboBoxLButtonTray_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLButtonTray.SelectedIndex == 11)
            {
                panelLButtonTray.Enabled = true;
            }
            else
            {
                panelLButtonTray.Enabled = false;
            }
        }

        private void comboBoxRButtonTray_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRButtonTray.SelectedIndex == 11)
            {
                panelRButtonTray.Enabled = true;
            }
            else
            {
                panelRButtonTray.Enabled = false;
            }
        }

        private void comboBoxMButtonTray_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMButtonTray.SelectedIndex == 11)
            {
                panelMButtonTray.Enabled = true;
            }
            else
            {
                panelMButtonTray.Enabled = false;
            }
        }

        private void labelSettingsPath_Click(object sender, EventArgs e)
        {
            Process.Start("settings/kioserv.ini");
        }
     }
}
