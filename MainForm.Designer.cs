namespace KioServ
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.goToStartPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToDocumentRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.apacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startStopApacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationFileApacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsApacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startStopMySqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationFileMySqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsMySqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phpMyAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postgreSqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startStopPgSqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationFilePgSqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsPgSqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phpPgAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pgAdminIIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationFilePhpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phpInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.startAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerRefreshStatus = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonStopApache = new System.Windows.Forms.Button();
            this.linkLabelApacheConfig = new System.Windows.Forms.LinkLabel();
            this.linkLabelApacheLogs = new System.Windows.Forms.LinkLabel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.groupBoxApache = new System.Windows.Forms.GroupBox();
            this.buttonStartApache = new System.Windows.Forms.Button();
            this.linkLabelPMA = new System.Windows.Forms.LinkLabel();
            this.buttonStartMySql = new System.Windows.Forms.Button();
            this.linkLabelMySqlConfig = new System.Windows.Forms.LinkLabel();
            this.buttonStopMySql = new System.Windows.Forms.Button();
            this.linkLabelMySqlLogs = new System.Windows.Forms.LinkLabel();
            this.groupBoxMySql = new System.Windows.Forms.GroupBox();
            this.linkLabelPhpInfo = new System.Windows.Forms.LinkLabel();
            this.linkLabelPhpConfig = new System.Windows.Forms.LinkLabel();
            this.labelPHPVer = new System.Windows.Forms.Label();
            this.comboBoxPhpVersion = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonExtensions = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonStartPgSql = new System.Windows.Forms.Button();
            this.buttonStopPgSql = new System.Windows.Forms.Button();
            this.groupBoxPgSql = new System.Windows.Forms.GroupBox();
            this.linkLabelPgSqlLogs = new System.Windows.Forms.LinkLabel();
            this.linkLabelPgSqlConfig = new System.Windows.Forms.LinkLabel();
            this.linkLabelPgAdmin = new System.Windows.Forms.LinkLabel();
            this.linkLabelPGA = new System.Windows.Forms.LinkLabel();
            this.linkLabelDocumentRoot = new System.Windows.Forms.LinkLabel();
            this.linkLabelLocalhost = new System.Windows.Forms.LinkLabel();
            this.trayMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxApache.SuspendLayout();
            this.groupBoxMySql.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxPgSql.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "KioServ\nApache: Running\nMySQL: Running";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDown);
            // 
            // trayMenu
            // 
            this.trayMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.toolStripSeparator2,
            this.goToStartPageToolStripMenuItem,
            this.goToDocumentRootToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator3,
            this.apacheToolStripMenuItem,
            this.mySqlToolStripMenuItem,
            this.postgreSqlToolStripMenuItem,
            this.phpToolStripMenuItem,
            this.toolStripSeparator6,
            this.startAllToolStripMenuItem,
            this.stopAllToolStripMenuItem,
            this.restartAllToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitTrayMenuItem});
            this.trayMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.trayMenu.Name = "contextMenuStrip1";
            this.trayMenu.Size = new System.Drawing.Size(177, 290);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Image = global::KioServ.Properties.Resources.application_double;
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.restoreToolStripMenuItem.Text = "Hide main window";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.retoreToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // goToStartPageToolStripMenuItem
            // 
            this.goToStartPageToolStripMenuItem.Image = global::KioServ.Properties.Resources.page_world;
            this.goToStartPageToolStripMenuItem.Name = "goToStartPageToolStripMenuItem";
            this.goToStartPageToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.goToStartPageToolStripMenuItem.Text = "Localhost";
            this.goToStartPageToolStripMenuItem.Click += new System.EventHandler(this.goToStartPageToolStripMenuItem_Click);
            // 
            // goToDocumentRootToolStripMenuItem
            // 
            this.goToDocumentRootToolStripMenuItem.Image = global::KioServ.Properties.Resources.folder;
            this.goToDocumentRootToolStripMenuItem.Name = "goToDocumentRootToolStripMenuItem";
            this.goToDocumentRootToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.goToDocumentRootToolStripMenuItem.Text = "Document root";
            this.goToDocumentRootToolStripMenuItem.Click += new System.EventHandler(this.goToDocumentRootToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::KioServ.Properties.Resources.cog;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(173, 6);
            // 
            // apacheToolStripMenuItem
            // 
            this.apacheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startStopApacheToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.configurationFileApacheToolStripMenuItem,
            this.logsApacheToolStripMenuItem});
            this.apacheToolStripMenuItem.Image = global::KioServ.Properties.Resources.apache;
            this.apacheToolStripMenuItem.Name = "apacheToolStripMenuItem";
            this.apacheToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.apacheToolStripMenuItem.Text = "Apache";
            // 
            // startStopApacheToolStripMenuItem
            // 
            this.startStopApacheToolStripMenuItem.Image = global::KioServ.Properties.Resources.resultset_next;
            this.startStopApacheToolStripMenuItem.Name = "startStopApacheToolStripMenuItem";
            this.startStopApacheToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.startStopApacheToolStripMenuItem.Text = "Start";
            this.startStopApacheToolStripMenuItem.Click += new System.EventHandler(this.startStopApacheToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Image = global::KioServ.Properties.Resources.arrow_refresh;
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            // 
            // configurationFileApacheToolStripMenuItem
            // 
            this.configurationFileApacheToolStripMenuItem.Image = global::KioServ.Properties.Resources.page_white_gear;
            this.configurationFileApacheToolStripMenuItem.Name = "configurationFileApacheToolStripMenuItem";
            this.configurationFileApacheToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.configurationFileApacheToolStripMenuItem.Text = "Configuration file";
            this.configurationFileApacheToolStripMenuItem.Click += new System.EventHandler(this.configurationFileApacheToolStripMenuItem_Click);
            // 
            // logsApacheToolStripMenuItem
            // 
            this.logsApacheToolStripMenuItem.Image = global::KioServ.Properties.Resources.page_white_text;
            this.logsApacheToolStripMenuItem.Name = "logsApacheToolStripMenuItem";
            this.logsApacheToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.logsApacheToolStripMenuItem.Text = "Logs";
            this.logsApacheToolStripMenuItem.Click += new System.EventHandler(this.logsApacheToolStripMenuItem_Click);
            // 
            // mySqlToolStripMenuItem
            // 
            this.mySqlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startStopMySqlToolStripMenuItem,
            this.restartToolStripMenuItem1,
            this.configurationFileMySqlToolStripMenuItem,
            this.logsMySqlToolStripMenuItem,
            this.phpMyAdminToolStripMenuItem});
            this.mySqlToolStripMenuItem.Image = global::KioServ.Properties.Resources.mysql;
            this.mySqlToolStripMenuItem.Name = "mySqlToolStripMenuItem";
            this.mySqlToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.mySqlToolStripMenuItem.Text = "MySQL";
            // 
            // startStopMySqlToolStripMenuItem
            // 
            this.startStopMySqlToolStripMenuItem.Image = global::KioServ.Properties.Resources.resultset_next;
            this.startStopMySqlToolStripMenuItem.Name = "startStopMySqlToolStripMenuItem";
            this.startStopMySqlToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.startStopMySqlToolStripMenuItem.Text = "Start";
            this.startStopMySqlToolStripMenuItem.Click += new System.EventHandler(this.startStopMySqlToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem1
            // 
            this.restartToolStripMenuItem1.Image = global::KioServ.Properties.Resources.arrow_refresh;
            this.restartToolStripMenuItem1.Name = "restartToolStripMenuItem1";
            this.restartToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.restartToolStripMenuItem1.Text = "Restart";
            // 
            // configurationFileMySqlToolStripMenuItem
            // 
            this.configurationFileMySqlToolStripMenuItem.Image = global::KioServ.Properties.Resources.page_white_gear;
            this.configurationFileMySqlToolStripMenuItem.Name = "configurationFileMySqlToolStripMenuItem";
            this.configurationFileMySqlToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.configurationFileMySqlToolStripMenuItem.Text = "Configuration file";
            this.configurationFileMySqlToolStripMenuItem.Click += new System.EventHandler(this.configurationFileMySqlToolStripMenuItem_Click);
            // 
            // logsMySqlToolStripMenuItem
            // 
            this.logsMySqlToolStripMenuItem.Image = global::KioServ.Properties.Resources.page_white_text;
            this.logsMySqlToolStripMenuItem.Name = "logsMySqlToolStripMenuItem";
            this.logsMySqlToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.logsMySqlToolStripMenuItem.Text = "Logs";
            this.logsMySqlToolStripMenuItem.Click += new System.EventHandler(this.logsMySqlToolStripMenuItem_Click);
            // 
            // phpMyAdminToolStripMenuItem
            // 
            this.phpMyAdminToolStripMenuItem.Image = global::KioServ.Properties.Resources.pma;
            this.phpMyAdminToolStripMenuItem.Name = "phpMyAdminToolStripMenuItem";
            this.phpMyAdminToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.phpMyAdminToolStripMenuItem.Text = "phpMyAdmin";
            this.phpMyAdminToolStripMenuItem.Click += new System.EventHandler(this.phpMyAdminToolStripMenuItem_Click);
            // 
            // postgreSqlToolStripMenuItem
            // 
            this.postgreSqlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startStopPgSqlToolStripMenuItem,
            this.restartToolStripMenuItem2,
            this.configurationFilePgSqlToolStripMenuItem,
            this.logsPgSqlToolStripMenuItem,
            this.phpPgAdminToolStripMenuItem,
            this.pgAdminIIIToolStripMenuItem});
            this.postgreSqlToolStripMenuItem.Image = global::KioServ.Properties.Resources.pgsql;
            this.postgreSqlToolStripMenuItem.Name = "postgreSqlToolStripMenuItem";
            this.postgreSqlToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.postgreSqlToolStripMenuItem.Text = "PostgreSQL";
            // 
            // startStopPgSqlToolStripMenuItem
            // 
            this.startStopPgSqlToolStripMenuItem.Image = global::KioServ.Properties.Resources.resultset_next;
            this.startStopPgSqlToolStripMenuItem.Name = "startStopPgSqlToolStripMenuItem";
            this.startStopPgSqlToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.startStopPgSqlToolStripMenuItem.Text = "Start";
            this.startStopPgSqlToolStripMenuItem.Click += new System.EventHandler(this.startStopPgSqlToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem2
            // 
            this.restartToolStripMenuItem2.Image = global::KioServ.Properties.Resources.arrow_refresh;
            this.restartToolStripMenuItem2.Name = "restartToolStripMenuItem2";
            this.restartToolStripMenuItem2.Size = new System.Drawing.Size(167, 22);
            this.restartToolStripMenuItem2.Text = "Restart";
            // 
            // configurationFilePgSqlToolStripMenuItem
            // 
            this.configurationFilePgSqlToolStripMenuItem.Image = global::KioServ.Properties.Resources.page_white_gear;
            this.configurationFilePgSqlToolStripMenuItem.Name = "configurationFilePgSqlToolStripMenuItem";
            this.configurationFilePgSqlToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.configurationFilePgSqlToolStripMenuItem.Text = "Configuration file";
            this.configurationFilePgSqlToolStripMenuItem.Click += new System.EventHandler(this.configurationFilePgSqlToolStripMenuItem_Click);
            // 
            // logsPgSqlToolStripMenuItem
            // 
            this.logsPgSqlToolStripMenuItem.Image = global::KioServ.Properties.Resources.page_white_text;
            this.logsPgSqlToolStripMenuItem.Name = "logsPgSqlToolStripMenuItem";
            this.logsPgSqlToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.logsPgSqlToolStripMenuItem.Text = "Logs";
            this.logsPgSqlToolStripMenuItem.Click += new System.EventHandler(this.logsPgSqlToolStripMenuItem_Click);
            // 
            // phpPgAdminToolStripMenuItem
            // 
            this.phpPgAdminToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phpPgAdminToolStripMenuItem.Image")));
            this.phpPgAdminToolStripMenuItem.Name = "phpPgAdminToolStripMenuItem";
            this.phpPgAdminToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.phpPgAdminToolStripMenuItem.Text = "phpPgAdmin";
            this.phpPgAdminToolStripMenuItem.Click += new System.EventHandler(this.phpPgAdminToolStripMenuItem_Click);
            // 
            // pgAdminIIIToolStripMenuItem
            // 
            this.pgAdminIIIToolStripMenuItem.Image = global::KioServ.Properties.Resources.application;
            this.pgAdminIIIToolStripMenuItem.Name = "pgAdminIIIToolStripMenuItem";
            this.pgAdminIIIToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pgAdminIIIToolStripMenuItem.Text = "pgAdmin III";
            this.pgAdminIIIToolStripMenuItem.Click += new System.EventHandler(this.pgAdminIIIToolStripMenuItem_Click);
            // 
            // phpToolStripMenuItem
            // 
            this.phpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.extensionsToolStripMenuItem,
            this.configurationFilePhpToolStripMenuItem,
            this.phpInfoToolStripMenuItem});
            this.phpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phpToolStripMenuItem.Image")));
            this.phpToolStripMenuItem.Name = "phpToolStripMenuItem";
            this.phpToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.phpToolStripMenuItem.Text = "PHP";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // extensionsToolStripMenuItem
            // 
            this.extensionsToolStripMenuItem.Image = global::KioServ.Properties.Resources.extensions;
            this.extensionsToolStripMenuItem.Name = "extensionsToolStripMenuItem";
            this.extensionsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.extensionsToolStripMenuItem.Text = "Extensions";
            // 
            // configurationFilePhpToolStripMenuItem
            // 
            this.configurationFilePhpToolStripMenuItem.Image = global::KioServ.Properties.Resources.page_white_gear;
            this.configurationFilePhpToolStripMenuItem.Name = "configurationFilePhpToolStripMenuItem";
            this.configurationFilePhpToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.configurationFilePhpToolStripMenuItem.Text = "Configuration file";
            this.configurationFilePhpToolStripMenuItem.Click += new System.EventHandler(this.configurationFilePhpToolStripMenuItem_Click);
            // 
            // phpInfoToolStripMenuItem
            // 
            this.phpInfoToolStripMenuItem.Image = global::KioServ.Properties.Resources.page_world;
            this.phpInfoToolStripMenuItem.Name = "phpInfoToolStripMenuItem";
            this.phpInfoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.phpInfoToolStripMenuItem.Text = "PHP Info";
            this.phpInfoToolStripMenuItem.Click += new System.EventHandler(this.phpInfoToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(173, 6);
            // 
            // startAllToolStripMenuItem
            // 
            this.startAllToolStripMenuItem.Image = global::KioServ.Properties.Resources.resultset_next;
            this.startAllToolStripMenuItem.Name = "startAllToolStripMenuItem";
            this.startAllToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.startAllToolStripMenuItem.Text = "Start all services";
            this.startAllToolStripMenuItem.Click += new System.EventHandler(this.startAllToolStripMenuItem_Click);
            // 
            // stopAllToolStripMenuItem
            // 
            this.stopAllToolStripMenuItem.Image = global::KioServ.Properties.Resources.stop;
            this.stopAllToolStripMenuItem.Name = "stopAllToolStripMenuItem";
            this.stopAllToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.stopAllToolStripMenuItem.Text = "Stop all services";
            this.stopAllToolStripMenuItem.Click += new System.EventHandler(this.stopAllToolStripMenuItem_Click);
            // 
            // restartAllToolStripMenuItem
            // 
            this.restartAllToolStripMenuItem.Image = global::KioServ.Properties.Resources.arrow_refresh;
            this.restartAllToolStripMenuItem.Name = "restartAllToolStripMenuItem";
            this.restartAllToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.restartAllToolStripMenuItem.Text = "Restart all services";
            this.restartAllToolStripMenuItem.Click += new System.EventHandler(this.restartAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(173, 6);
            // 
            // exitTrayMenuItem
            // 
            this.exitTrayMenuItem.Image = global::KioServ.Properties.Resources.cross;
            this.exitTrayMenuItem.Name = "exitTrayMenuItem";
            this.exitTrayMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.exitTrayMenuItem.Size = new System.Drawing.Size(176, 20);
            this.exitTrayMenuItem.Text = "Exit";
            this.exitTrayMenuItem.Click += new System.EventHandler(this.exitTrayMenuItem_Click);
            // 
            // timerRefreshStatus
            // 
            this.timerRefreshStatus.Enabled = true;
            this.timerRefreshStatus.Interval = 500;
            this.timerRefreshStatus.Tick += new System.EventHandler(this.timerRefreshStatus_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLink,
            this.toolStripSeparator7,
            this.toolStripStatusLabel1,
            this.toolStripSeparator1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(551, 23);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelLink
            // 
            this.toolStripStatusLabelLink.IsLink = true;
            this.toolStripStatusLabelLink.Margin = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.toolStripStatusLabelLink.Name = "toolStripStatusLabelLink";
            this.toolStripStatusLabelLink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabelLink.Size = new System.Drawing.Size(80, 18);
            this.toolStripStatusLabelLink.Text = "serv.kiofol.com";
            this.toolStripStatusLabelLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelLink.Click += new System.EventHandler(this.toolStripStatusLabelLink_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 18);
            this.toolStripStatusLabel1.Text = "kiofol.com";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabelLink_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(369, 18);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "Rafa³ Enden  –  2011";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonStopApache
            // 
            this.buttonStopApache.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStopApache.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonStopApache.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStopApache.Location = new System.Drawing.Point(154, 26);
            this.buttonStopApache.Name = "buttonStopApache";
            this.buttonStopApache.Size = new System.Drawing.Size(133, 30);
            this.buttonStopApache.TabIndex = 3;
            this.buttonStopApache.Text = "Stop";
            this.buttonStopApache.UseVisualStyleBackColor = true;
            this.buttonStopApache.Click += new System.EventHandler(this.buttonStopApache_Click);
            // 
            // linkLabelApacheConfig
            // 
            this.linkLabelApacheConfig.AutoSize = true;
            this.linkLabelApacheConfig.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelApacheConfig.LinkColor = System.Drawing.Color.Black;
            this.linkLabelApacheConfig.Location = new System.Drawing.Point(13, 66);
            this.linkLabelApacheConfig.Name = "linkLabelApacheConfig";
            this.linkLabelApacheConfig.Size = new System.Drawing.Size(103, 16);
            this.linkLabelApacheConfig.TabIndex = 5;
            this.linkLabelApacheConfig.TabStop = true;
            this.linkLabelApacheConfig.Text = "Configuration file";
            this.linkLabelApacheConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelApacheConfig_LinkClicked);
            // 
            // linkLabelApacheLogs
            // 
            this.linkLabelApacheLogs.AutoSize = true;
            this.linkLabelApacheLogs.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelApacheLogs.LinkColor = System.Drawing.Color.Black;
            this.linkLabelApacheLogs.Location = new System.Drawing.Point(152, 66);
            this.linkLabelApacheLogs.Name = "linkLabelApacheLogs";
            this.linkLabelApacheLogs.Size = new System.Drawing.Size(64, 16);
            this.linkLabelApacheLogs.TabIndex = 3;
            this.linkLabelApacheLogs.TabStop = true;
            this.linkLabelApacheLogs.Text = "Error logs";
            this.linkLabelApacheLogs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelApacheLogs_LinkClicked);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(39, 416);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(113, 23);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // groupBoxApache
            // 
            this.groupBoxApache.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxApache.Controls.Add(this.linkLabelApacheLogs);
            this.groupBoxApache.Controls.Add(this.linkLabelApacheConfig);
            this.groupBoxApache.Controls.Add(this.buttonStartApache);
            this.groupBoxApache.Controls.Add(this.buttonStopApache);
            this.groupBoxApache.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBoxApache.Location = new System.Drawing.Point(12, 67);
            this.groupBoxApache.Name = "groupBoxApache";
            this.groupBoxApache.Padding = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.groupBoxApache.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxApache.Size = new System.Drawing.Size(527, 97);
            this.groupBoxApache.TabIndex = 2;
            this.groupBoxApache.TabStop = false;
            this.groupBoxApache.Text = "Apache";
            // 
            // buttonStartApache
            // 
            this.buttonStartApache.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStartApache.ForeColor = System.Drawing.Color.Green;
            this.buttonStartApache.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStartApache.Location = new System.Drawing.Point(15, 26);
            this.buttonStartApache.Name = "buttonStartApache";
            this.buttonStartApache.Size = new System.Drawing.Size(133, 30);
            this.buttonStartApache.TabIndex = 1;
            this.buttonStartApache.Text = "Start";
            this.buttonStartApache.UseVisualStyleBackColor = true;
            this.buttonStartApache.Click += new System.EventHandler(this.buttonStartApache_Click);
            // 
            // linkLabelPMA
            // 
            this.linkLabelPMA.AutoSize = true;
            this.linkLabelPMA.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelPMA.LinkColor = System.Drawing.Color.Black;
            this.linkLabelPMA.Location = new System.Drawing.Point(117, 66);
            this.linkLabelPMA.Name = "linkLabelPMA";
            this.linkLabelPMA.Size = new System.Drawing.Size(84, 16);
            this.linkLabelPMA.TabIndex = 5;
            this.linkLabelPMA.TabStop = true;
            this.linkLabelPMA.Text = "phpMyAdmin";
            this.linkLabelPMA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPMA_LinkClicked);
            // 
            // buttonStartMySql
            // 
            this.buttonStartMySql.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStartMySql.ForeColor = System.Drawing.Color.Green;
            this.buttonStartMySql.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStartMySql.Location = new System.Drawing.Point(15, 26);
            this.buttonStartMySql.Name = "buttonStartMySql";
            this.buttonStartMySql.Size = new System.Drawing.Size(96, 25);
            this.buttonStartMySql.TabIndex = 1;
            this.buttonStartMySql.Text = "Start";
            this.buttonStartMySql.UseVisualStyleBackColor = true;
            this.buttonStartMySql.Click += new System.EventHandler(this.buttonStartMySql_Click);
            // 
            // linkLabelMySqlConfig
            // 
            this.linkLabelMySqlConfig.AutoSize = true;
            this.linkLabelMySqlConfig.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelMySqlConfig.LinkColor = System.Drawing.Color.Black;
            this.linkLabelMySqlConfig.Location = new System.Drawing.Point(117, 26);
            this.linkLabelMySqlConfig.Name = "linkLabelMySqlConfig";
            this.linkLabelMySqlConfig.Size = new System.Drawing.Size(103, 16);
            this.linkLabelMySqlConfig.TabIndex = 5;
            this.linkLabelMySqlConfig.TabStop = true;
            this.linkLabelMySqlConfig.Text = "Configuration file";
            this.linkLabelMySqlConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMySqlConfig_LinkClicked);
            // 
            // buttonStopMySql
            // 
            this.buttonStopMySql.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonStopMySql.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonStopMySql.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStopMySql.Location = new System.Drawing.Point(15, 57);
            this.buttonStopMySql.Name = "buttonStopMySql";
            this.buttonStopMySql.Size = new System.Drawing.Size(96, 25);
            this.buttonStopMySql.TabIndex = 3;
            this.buttonStopMySql.Text = "Stop";
            this.buttonStopMySql.UseVisualStyleBackColor = true;
            this.buttonStopMySql.Click += new System.EventHandler(this.buttonStopMySql_Click);
            // 
            // linkLabelMySqlLogs
            // 
            this.linkLabelMySqlLogs.AutoSize = true;
            this.linkLabelMySqlLogs.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelMySqlLogs.LinkColor = System.Drawing.Color.Black;
            this.linkLabelMySqlLogs.Location = new System.Drawing.Point(117, 46);
            this.linkLabelMySqlLogs.Name = "linkLabelMySqlLogs";
            this.linkLabelMySqlLogs.Size = new System.Drawing.Size(36, 16);
            this.linkLabelMySqlLogs.TabIndex = 3;
            this.linkLabelMySqlLogs.TabStop = true;
            this.linkLabelMySqlLogs.Text = "Logs";
            this.linkLabelMySqlLogs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMySqlLogs_LinkClicked);
            // 
            // groupBoxMySql
            // 
            this.groupBoxMySql.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMySql.Controls.Add(this.linkLabelMySqlLogs);
            this.groupBoxMySql.Controls.Add(this.buttonStopMySql);
            this.groupBoxMySql.Controls.Add(this.linkLabelMySqlConfig);
            this.groupBoxMySql.Controls.Add(this.buttonStartMySql);
            this.groupBoxMySql.Controls.Add(this.linkLabelPMA);
            this.groupBoxMySql.Location = new System.Drawing.Point(12, 174);
            this.groupBoxMySql.Name = "groupBoxMySql";
            this.groupBoxMySql.Padding = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.groupBoxMySql.Size = new System.Drawing.Size(256, 117);
            this.groupBoxMySql.TabIndex = 2;
            this.groupBoxMySql.TabStop = false;
            this.groupBoxMySql.Text = "MySQL";
            // 
            // linkLabelPhpInfo
            // 
            this.linkLabelPhpInfo.AutoSize = true;
            this.linkLabelPhpInfo.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelPhpInfo.LinkColor = System.Drawing.Color.Black;
            this.linkLabelPhpInfo.Location = new System.Drawing.Point(150, 66);
            this.linkLabelPhpInfo.Name = "linkLabelPhpInfo";
            this.linkLabelPhpInfo.Size = new System.Drawing.Size(59, 16);
            this.linkLabelPhpInfo.TabIndex = 5;
            this.linkLabelPhpInfo.TabStop = true;
            this.linkLabelPhpInfo.Text = "PHP Info";
            this.linkLabelPhpInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPhpInfo_LinkClicked);
            // 
            // linkLabelPhpConfig
            // 
            this.linkLabelPhpConfig.AutoSize = true;
            this.linkLabelPhpConfig.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelPhpConfig.LinkColor = System.Drawing.Color.Black;
            this.linkLabelPhpConfig.Location = new System.Drawing.Point(13, 66);
            this.linkLabelPhpConfig.Name = "linkLabelPhpConfig";
            this.linkLabelPhpConfig.Size = new System.Drawing.Size(103, 16);
            this.linkLabelPhpConfig.TabIndex = 5;
            this.linkLabelPhpConfig.TabStop = true;
            this.linkLabelPhpConfig.Text = "Configuration file";
            this.linkLabelPhpConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPhpConfig_LinkClicked);
            // 
            // labelPHPVer
            // 
            this.labelPHPVer.AutoSize = true;
            this.labelPHPVer.Location = new System.Drawing.Point(13, 28);
            this.labelPHPVer.Name = "labelPHPVer";
            this.labelPHPVer.Size = new System.Drawing.Size(67, 13);
            this.labelPHPVer.TabIndex = 0;
            this.labelPHPVer.Text = "PHP Version";
            // 
            // comboBoxPhpVersion
            // 
            this.comboBoxPhpVersion.AccessibleDescription = "Disable translation";
            this.comboBoxPhpVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPhpVersion.FormattingEnabled = true;
            this.comboBoxPhpVersion.Location = new System.Drawing.Point(87, 25);
            this.comboBoxPhpVersion.Name = "comboBoxPhpVersion";
            this.comboBoxPhpVersion.Size = new System.Drawing.Size(208, 21);
            this.comboBoxPhpVersion.TabIndex = 1;
            this.comboBoxPhpVersion.SelectedIndexChanged += new System.EventHandler(this.comboBoxPhpVersion_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.comboBoxPhpVersion);
            this.groupBox2.Controls.Add(this.labelPHPVer);
            this.groupBox2.Controls.Add(this.linkLabelPhpConfig);
            this.groupBox2.Controls.Add(this.linkLabelPhpInfo);
            this.groupBox2.Controls.Add(this.buttonExtensions);
            this.groupBox2.Location = new System.Drawing.Point(12, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 15, 15, 15);
            this.groupBox2.Size = new System.Drawing.Size(527, 97);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PHP";
            // 
            // buttonExtensions
            // 
            this.buttonExtensions.Location = new System.Drawing.Point(301, 23);
            this.buttonExtensions.Name = "buttonExtensions";
            this.buttonExtensions.Size = new System.Drawing.Size(118, 23);
            this.buttonExtensions.TabIndex = 6;
            this.buttonExtensions.Text = "Extensions";
            this.buttonExtensions.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(301, 416);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(113, 23);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.AccessibleDescription = "";
            this.buttonHide.Location = new System.Drawing.Point(420, 416);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(113, 23);
            this.buttonHide.TabIndex = 6;
            this.buttonHide.Text = "Hide";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // buttonStartPgSql
            // 
            this.buttonStartPgSql.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonStartPgSql.ForeColor = System.Drawing.Color.Green;
            this.buttonStartPgSql.Location = new System.Drawing.Point(15, 26);
            this.buttonStartPgSql.Name = "buttonStartPgSql";
            this.buttonStartPgSql.Size = new System.Drawing.Size(96, 25);
            this.buttonStartPgSql.TabIndex = 7;
            this.buttonStartPgSql.Text = "Start";
            this.buttonStartPgSql.UseVisualStyleBackColor = true;
            this.buttonStartPgSql.Click += new System.EventHandler(this.buttonStartPgSql_Click);
            // 
            // buttonStopPgSql
            // 
            this.buttonStopPgSql.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonStopPgSql.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonStopPgSql.Location = new System.Drawing.Point(15, 57);
            this.buttonStopPgSql.Name = "buttonStopPgSql";
            this.buttonStopPgSql.Size = new System.Drawing.Size(96, 25);
            this.buttonStopPgSql.TabIndex = 7;
            this.buttonStopPgSql.Text = "Stop";
            this.buttonStopPgSql.UseVisualStyleBackColor = true;
            this.buttonStopPgSql.Click += new System.EventHandler(this.buttonStopPgSql_Click);
            // 
            // groupBoxPgSql
            // 
            this.groupBoxPgSql.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPgSql.Controls.Add(this.linkLabelPgSqlLogs);
            this.groupBoxPgSql.Controls.Add(this.buttonStopPgSql);
            this.groupBoxPgSql.Controls.Add(this.buttonStartPgSql);
            this.groupBoxPgSql.Controls.Add(this.linkLabelPgSqlConfig);
            this.groupBoxPgSql.Controls.Add(this.linkLabelPgAdmin);
            this.groupBoxPgSql.Controls.Add(this.linkLabelPGA);
            this.groupBoxPgSql.Location = new System.Drawing.Point(282, 174);
            this.groupBoxPgSql.Name = "groupBoxPgSql";
            this.groupBoxPgSql.Size = new System.Drawing.Size(257, 117);
            this.groupBoxPgSql.TabIndex = 8;
            this.groupBoxPgSql.TabStop = false;
            this.groupBoxPgSql.Text = "PostgreSQL";
            // 
            // linkLabelPgSqlLogs
            // 
            this.linkLabelPgSqlLogs.AutoSize = true;
            this.linkLabelPgSqlLogs.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelPgSqlLogs.LinkColor = System.Drawing.Color.Black;
            this.linkLabelPgSqlLogs.Location = new System.Drawing.Point(117, 46);
            this.linkLabelPgSqlLogs.Name = "linkLabelPgSqlLogs";
            this.linkLabelPgSqlLogs.Size = new System.Drawing.Size(36, 16);
            this.linkLabelPgSqlLogs.TabIndex = 3;
            this.linkLabelPgSqlLogs.TabStop = true;
            this.linkLabelPgSqlLogs.Text = "Logs";
            this.linkLabelPgSqlLogs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPgSqlLogs_LinkClicked);
            // 
            // linkLabelPgSqlConfig
            // 
            this.linkLabelPgSqlConfig.AutoSize = true;
            this.linkLabelPgSqlConfig.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelPgSqlConfig.LinkColor = System.Drawing.Color.Black;
            this.linkLabelPgSqlConfig.Location = new System.Drawing.Point(117, 26);
            this.linkLabelPgSqlConfig.Name = "linkLabelPgSqlConfig";
            this.linkLabelPgSqlConfig.Size = new System.Drawing.Size(103, 16);
            this.linkLabelPgSqlConfig.TabIndex = 5;
            this.linkLabelPgSqlConfig.TabStop = true;
            this.linkLabelPgSqlConfig.Text = "Configuration file";
            this.linkLabelPgSqlConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPgSqlConfig_LinkClicked);
            // 
            // linkLabelPgAdmin
            // 
            this.linkLabelPgAdmin.AutoSize = true;
            this.linkLabelPgAdmin.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelPgAdmin.LinkColor = System.Drawing.Color.Black;
            this.linkLabelPgAdmin.Location = new System.Drawing.Point(117, 86);
            this.linkLabelPgAdmin.Name = "linkLabelPgAdmin";
            this.linkLabelPgAdmin.Size = new System.Drawing.Size(72, 16);
            this.linkLabelPgAdmin.TabIndex = 5;
            this.linkLabelPgAdmin.TabStop = true;
            this.linkLabelPgAdmin.Text = "pgAdmin III";
            this.linkLabelPgAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPgAdmin_LinkClicked);
            // 
            // linkLabelPGA
            // 
            this.linkLabelPGA.AutoSize = true;
            this.linkLabelPGA.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelPGA.LinkColor = System.Drawing.Color.Black;
            this.linkLabelPGA.Location = new System.Drawing.Point(117, 66);
            this.linkLabelPGA.Name = "linkLabelPGA";
            this.linkLabelPGA.Size = new System.Drawing.Size(82, 16);
            this.linkLabelPGA.TabIndex = 5;
            this.linkLabelPGA.TabStop = true;
            this.linkLabelPGA.Text = "phpPgAdmin";
            this.linkLabelPGA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPGA_LinkClicked);
            // 
            // linkLabelDocumentRoot
            // 
            this.linkLabelDocumentRoot.AutoSize = true;
            this.linkLabelDocumentRoot.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelDocumentRoot.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelDocumentRoot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelDocumentRoot.LinkColor = System.Drawing.Color.Black;
            this.linkLabelDocumentRoot.Location = new System.Drawing.Point(33, 34);
            this.linkLabelDocumentRoot.Name = "linkLabelDocumentRoot";
            this.linkLabelDocumentRoot.Size = new System.Drawing.Size(161, 16);
            this.linkLabelDocumentRoot.TabIndex = 5;
            this.linkLabelDocumentRoot.TabStop = true;
            this.linkLabelDocumentRoot.Text = "Open document root folder";
            this.linkLabelDocumentRoot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDocumentRoot_LinkClicked);
            // 
            // linkLabelLocalhost
            // 
            this.linkLabelLocalhost.AutoSize = true;
            this.linkLabelLocalhost.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelLocalhost.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelLocalhost.LinkColor = System.Drawing.Color.Black;
            this.linkLabelLocalhost.Location = new System.Drawing.Point(33, 16);
            this.linkLabelLocalhost.Name = "linkLabelLocalhost";
            this.linkLabelLocalhost.Size = new System.Drawing.Size(158, 16);
            this.linkLabelLocalhost.TabIndex = 5;
            this.linkLabelLocalhost.TabStop = true;
            this.linkLabelLocalhost.Text = "Open localhost in browser";
            this.linkLabelLocalhost.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLocalhost_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 478);
            this.Controls.Add(this.groupBoxPgSql);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxApache);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxMySql);
            this.Controls.Add(this.linkLabelDocumentRoot);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.linkLabelLocalhost);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSettings);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KioServ";
            this.Load += new System.EventHandler(this.MainWindow_Resize);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.trayMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxApache.ResumeLayout(false);
            this.groupBoxApache.PerformLayout();
            this.groupBoxMySql.ResumeLayout(false);
            this.groupBoxMySql.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxPgSql.ResumeLayout(false);
            this.groupBoxPgSql.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ToolStripMenuItem exitTrayMenuItem;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.Timer timerRefreshStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLink;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabelLocalhost;
        private System.Windows.Forms.LinkLabel linkLabelDocumentRoot;
        private System.Windows.Forms.Button buttonStartApache;
        private System.Windows.Forms.Button buttonStopApache;
        private System.Windows.Forms.LinkLabel linkLabelApacheConfig;
        private System.Windows.Forms.LinkLabel linkLabelApacheLogs;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.GroupBox groupBoxApache;
        private System.Windows.Forms.LinkLabel linkLabelPMA;
        private System.Windows.Forms.Button buttonStartMySql;
        private System.Windows.Forms.LinkLabel linkLabelMySqlConfig;
        private System.Windows.Forms.Button buttonStopMySql;
        private System.Windows.Forms.LinkLabel linkLabelMySqlLogs;
        private System.Windows.Forms.GroupBox groupBoxMySql;
        private System.Windows.Forms.LinkLabel linkLabelPhpInfo;
        private System.Windows.Forms.LinkLabel linkLabelPhpConfig;
        private System.Windows.Forms.Label labelPHPVer;
        private System.Windows.Forms.ComboBox comboBoxPhpVersion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Button buttonExtensions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.Button buttonStartPgSql;
        private System.Windows.Forms.Button buttonStopPgSql;
        private System.Windows.Forms.GroupBox groupBoxPgSql;
        private System.Windows.Forms.LinkLabel linkLabelPgSqlLogs;
        private System.Windows.Forms.LinkLabel linkLabelPgSqlConfig;
        private System.Windows.Forms.LinkLabel linkLabelPGA;
        private System.Windows.Forms.LinkLabel linkLabelPgAdmin;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem apacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postgreSqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mySqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startStopApacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationFileApacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsApacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startStopMySqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationFileMySqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsMySqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phpMyAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startStopPgSqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationFilePgSqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsPgSqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phpPgAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pgAdminIIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationFilePhpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phpInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem goToStartPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToDocumentRootToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem startAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem2;
    }
}

