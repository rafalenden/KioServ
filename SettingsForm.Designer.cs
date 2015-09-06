namespace KioServ
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDocumentRoot = new System.Windows.Forms.Button();
            this.textBoxDocumentRoot = new System.Windows.Forms.TextBox();
            this.checkBoxHideAtStartup = new System.Windows.Forms.CheckBox();
            this.labelDocRoot = new System.Windows.Forms.Label();
            this.labelLang = new System.Windows.Forms.Label();
            this.comboBoxLButtonTray = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialogDocumentRoot = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.textBoxMySqlPort = new System.Windows.Forms.TextBox();
            this.textBoxApachePort = new System.Windows.Forms.TextBox();
            this.comboBoxLang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelMButtonTray = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMButtonPath = new System.Windows.Forms.TextBox();
            this.panelRButtonTray = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRButtonPath = new System.Windows.Forms.TextBox();
            this.panelLButtonTray = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLButtonPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRButtonTray = new System.Windows.Forms.ComboBox();
            this.comboBoxMButtonTray = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPgSqlPort = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSettingsPath = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panelMButtonTray.SuspendLayout();
            this.panelRButtonTray.SuspendLayout();
            this.panelLButtonTray.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "MySQL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apache";
            // 
            // buttonDocumentRoot
            // 
            this.buttonDocumentRoot.Location = new System.Drawing.Point(289, 115);
            this.buttonDocumentRoot.Name = "buttonDocumentRoot";
            this.buttonDocumentRoot.Size = new System.Drawing.Size(90, 23);
            this.buttonDocumentRoot.TabIndex = 5;
            this.buttonDocumentRoot.Text = "Browse...";
            this.buttonDocumentRoot.UseVisualStyleBackColor = true;
            this.buttonDocumentRoot.Click += new System.EventHandler(this.buttonDocumentRoot_Click);
            // 
            // textBoxDocumentRoot
            // 
            this.textBoxDocumentRoot.AccessibleDescription = "Disable translation";
            this.textBoxDocumentRoot.Location = new System.Drawing.Point(17, 117);
            this.textBoxDocumentRoot.Name = "textBoxDocumentRoot";
            this.textBoxDocumentRoot.Size = new System.Drawing.Size(266, 20);
            this.textBoxDocumentRoot.TabIndex = 4;
            // 
            // checkBoxHideAtStartup
            // 
            this.checkBoxHideAtStartup.AutoSize = true;
            this.checkBoxHideAtStartup.Location = new System.Drawing.Point(17, 71);
            this.checkBoxHideAtStartup.Name = "checkBoxHideAtStartup";
            this.checkBoxHideAtStartup.Size = new System.Drawing.Size(95, 17);
            this.checkBoxHideAtStartup.TabIndex = 2;
            this.checkBoxHideAtStartup.Text = "Hide at startup";
            this.checkBoxHideAtStartup.UseVisualStyleBackColor = true;
            // 
            // labelDocRoot
            // 
            this.labelDocRoot.AutoSize = true;
            this.labelDocRoot.Location = new System.Drawing.Point(14, 101);
            this.labelDocRoot.Name = "labelDocRoot";
            this.labelDocRoot.Size = new System.Drawing.Size(77, 13);
            this.labelDocRoot.TabIndex = 3;
            this.labelDocRoot.Text = "Document root";
            // 
            // labelLang
            // 
            this.labelLang.AutoSize = true;
            this.labelLang.Location = new System.Drawing.Point(8, 27);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(149, 13);
            this.labelLang.TabIndex = 0;
            this.labelLang.Text = "Left mouse button click action";
            // 
            // comboBoxLButtonTray
            // 
            this.comboBoxLButtonTray.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLButtonTray.FormattingEnabled = true;
            this.comboBoxLButtonTray.Items.AddRange(new object[] {
            "(none)",
            "Show/Hide main window",
            "Show context menu",
            "Open settings window",
            "Start all services",
            "Stop all services",
            "Restart all services",
            "Go to localhost",
            "Go to root directory",
            "Go to phpMyAdmin",
            "Go to phpPgAdmin",
            "Open file, directory, program or url",
            "Exit KioServ"});
            this.comboBoxLButtonTray.Location = new System.Drawing.Point(11, 43);
            this.comboBoxLButtonTray.Name = "comboBoxLButtonTray";
            this.comboBoxLButtonTray.Size = new System.Drawing.Size(201, 21);
            this.comboBoxLButtonTray.TabIndex = 1;
            this.comboBoxLButtonTray.SelectedIndexChanged += new System.EventHandler(this.comboBoxLButtonTray_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(346, 431);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(240, 431);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 23);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelSeparator
            // 
            this.labelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeparator.Location = new System.Drawing.Point(17, 418);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(425, 1);
            this.labelSeparator.TabIndex = 13;
            // 
            // textBoxMySqlPort
            // 
            this.textBoxMySqlPort.AccessibleDescription = "Disable translation";
            this.textBoxMySqlPort.Location = new System.Drawing.Point(199, 25);
            this.textBoxMySqlPort.Name = "textBoxMySqlPort";
            this.textBoxMySqlPort.Size = new System.Drawing.Size(59, 20);
            this.textBoxMySqlPort.TabIndex = 9;
            // 
            // textBoxApachePort
            // 
            this.textBoxApachePort.AccessibleDescription = "Disable translation";
            this.textBoxApachePort.Location = new System.Drawing.Point(63, 25);
            this.textBoxApachePort.Name = "textBoxApachePort";
            this.textBoxApachePort.Size = new System.Drawing.Size(59, 20);
            this.textBoxApachePort.TabIndex = 7;
            // 
            // comboBoxLang
            // 
            this.comboBoxLang.AccessibleDescription = "Disable translation";
            this.comboBoxLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLang.FormattingEnabled = true;
            this.comboBoxLang.Location = new System.Drawing.Point(15, 35);
            this.comboBoxLang.Name = "comboBoxLang";
            this.comboBoxLang.Size = new System.Drawing.Size(181, 21);
            this.comboBoxLang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Language";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelMButtonTray);
            this.groupBox1.Controls.Add(this.panelRButtonTray);
            this.groupBox1.Controls.Add(this.panelLButtonTray);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelLang);
            this.groupBox1.Controls.Add(this.comboBoxRButtonTray);
            this.groupBox1.Controls.Add(this.comboBoxLButtonTray);
            this.groupBox1.Controls.Add(this.comboBoxMButtonTray);
            this.groupBox1.Location = new System.Drawing.Point(12, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 165);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tray icon options";
            // 
            // panelMButtonTray
            // 
            this.panelMButtonTray.Controls.Add(this.label9);
            this.panelMButtonTray.Controls.Add(this.textBoxMButtonPath);
            this.panelMButtonTray.Enabled = false;
            this.panelMButtonTray.Location = new System.Drawing.Point(219, 113);
            this.panelMButtonTray.Name = "panelMButtonTray";
            this.panelMButtonTray.Size = new System.Drawing.Size(209, 37);
            this.panelMButtonTray.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Path to file, directory, program or url";
            // 
            // textBoxMButtonPath
            // 
            this.textBoxMButtonPath.Location = new System.Drawing.Point(3, 16);
            this.textBoxMButtonPath.Name = "textBoxMButtonPath";
            this.textBoxMButtonPath.Size = new System.Drawing.Size(201, 20);
            this.textBoxMButtonPath.TabIndex = 6;
            // 
            // panelRButtonTray
            // 
            this.panelRButtonTray.Controls.Add(this.label8);
            this.panelRButtonTray.Controls.Add(this.textBoxRButtonPath);
            this.panelRButtonTray.Enabled = false;
            this.panelRButtonTray.Location = new System.Drawing.Point(218, 70);
            this.panelRButtonTray.Name = "panelRButtonTray";
            this.panelRButtonTray.Size = new System.Drawing.Size(209, 37);
            this.panelRButtonTray.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Path to file, directory, program or url";
            // 
            // textBoxRButtonPath
            // 
            this.textBoxRButtonPath.Location = new System.Drawing.Point(3, 16);
            this.textBoxRButtonPath.Name = "textBoxRButtonPath";
            this.textBoxRButtonPath.Size = new System.Drawing.Size(201, 20);
            this.textBoxRButtonPath.TabIndex = 6;
            // 
            // panelLButtonTray
            // 
            this.panelLButtonTray.Controls.Add(this.label6);
            this.panelLButtonTray.Controls.Add(this.textBoxLButtonPath);
            this.panelLButtonTray.Enabled = false;
            this.panelLButtonTray.Location = new System.Drawing.Point(218, 27);
            this.panelLButtonTray.Name = "panelLButtonTray";
            this.panelLButtonTray.Size = new System.Drawing.Size(209, 37);
            this.panelLButtonTray.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Path to file, directory, program or url";
            // 
            // textBoxLButtonPath
            // 
            this.textBoxLButtonPath.Location = new System.Drawing.Point(3, 16);
            this.textBoxLButtonPath.Name = "textBoxLButtonPath";
            this.textBoxLButtonPath.Size = new System.Drawing.Size(201, 20);
            this.textBoxLButtonPath.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Middle mouse button click";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Right mouse button click";
            // 
            // comboBoxRButtonTray
            // 
            this.comboBoxRButtonTray.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRButtonTray.FormattingEnabled = true;
            this.comboBoxRButtonTray.Location = new System.Drawing.Point(11, 86);
            this.comboBoxRButtonTray.Name = "comboBoxRButtonTray";
            this.comboBoxRButtonTray.Size = new System.Drawing.Size(201, 21);
            this.comboBoxRButtonTray.TabIndex = 3;
            this.comboBoxRButtonTray.SelectedIndexChanged += new System.EventHandler(this.comboBoxRButtonTray_SelectedIndexChanged);
            // 
            // comboBoxMButtonTray
            // 
            this.comboBoxMButtonTray.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMButtonTray.FormattingEnabled = true;
            this.comboBoxMButtonTray.Location = new System.Drawing.Point(11, 130);
            this.comboBoxMButtonTray.Name = "comboBoxMButtonTray";
            this.comboBoxMButtonTray.Size = new System.Drawing.Size(201, 21);
            this.comboBoxMButtonTray.TabIndex = 5;
            this.comboBoxMButtonTray.SelectedIndexChanged += new System.EventHandler(this.comboBoxMButtonTray_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "PostgreSQL";
            // 
            // textBoxPgSqlPort
            // 
            this.textBoxPgSqlPort.AccessibleDescription = "Disable translation";
            this.textBoxPgSqlPort.Location = new System.Drawing.Point(358, 25);
            this.textBoxPgSqlPort.Name = "textBoxPgSqlPort";
            this.textBoxPgSqlPort.Size = new System.Drawing.Size(59, 20);
            this.textBoxPgSqlPort.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxApachePort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxMySqlPort);
            this.groupBox2.Controls.Add(this.textBoxPgSqlPort);
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 58);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ports";
            // 
            // labelSettingsPath
            // 
            this.labelSettingsPath.AutoSize = true;
            this.labelSettingsPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSettingsPath.Location = new System.Drawing.Point(14, 397);
            this.labelSettingsPath.Name = "labelSettingsPath";
            this.labelSettingsPath.Size = new System.Drawing.Size(221, 13);
            this.labelSettingsPath.TabIndex = 15;
            this.labelSettingsPath.Text = "This settings are stored in: settings/kioserv.ini";
            this.labelSettingsPath.Click += new System.EventHandler(this.labelSettingsPath_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(458, 466);
            this.Controls.Add(this.labelSettingsPath);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelSeparator);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDocumentRoot);
            this.Controls.Add(this.textBoxDocumentRoot);
            this.Controls.Add(this.checkBoxHideAtStartup);
            this.Controls.Add(this.labelDocRoot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelMButtonTray.ResumeLayout(false);
            this.panelMButtonTray.PerformLayout();
            this.panelRButtonTray.ResumeLayout(false);
            this.panelRButtonTray.PerformLayout();
            this.panelLButtonTray.ResumeLayout(false);
            this.panelLButtonTray.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDocumentRoot;
        private System.Windows.Forms.TextBox textBoxDocumentRoot;
        private System.Windows.Forms.CheckBox checkBoxHideAtStartup;
        private System.Windows.Forms.Label labelDocRoot;
        private System.Windows.Forms.Label labelLang;
        private System.Windows.Forms.ComboBox comboBoxLButtonTray;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDocumentRoot;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.TextBox textBoxMySqlPort;
        private System.Windows.Forms.TextBox textBoxApachePort;
        private System.Windows.Forms.ComboBox comboBoxLang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRButtonTray;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMButtonTray;
        private System.Windows.Forms.TextBox textBoxLButtonPath;
        private System.Windows.Forms.Panel panelLButtonTray;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPgSqlPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelMButtonTray;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMButtonPath;
        private System.Windows.Forms.Panel panelRButtonTray;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRButtonPath;
        private System.Windows.Forms.Label labelSettingsPath;

    }
}