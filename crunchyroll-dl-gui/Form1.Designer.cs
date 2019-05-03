namespace crunchyroll_dl_gui
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
            this.Authentication = new System.Windows.Forms.GroupBox();
            this.useAccount = new System.Windows.Forms.CheckBox();
            this.save = new System.Windows.Forms.Button();
            this.Showpassword = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.unblock = new System.Windows.Forms.CheckBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.inputURL = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Episodes = new System.Windows.Forms.CheckBox();
            this.saveDownloadSettings = new System.Windows.Forms.Button();
            this.useDefaultName = new System.Windows.Forms.CheckBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ignoreDubs = new System.Windows.Forms.CheckBox();
            this.downloadAll = new System.Windows.Forms.CheckBox();
            this.debug = new System.Windows.Forms.CheckBox();
            this.episodesRange = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.language = new System.Windows.Forms.ComboBox();
            this.dontAutoselectQuality = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quality = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.CommandLine = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.Authentication.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Authentication
            // 
            this.Authentication.Controls.Add(this.useAccount);
            this.Authentication.Controls.Add(this.save);
            this.Authentication.Controls.Add(this.Showpassword);
            this.Authentication.Controls.Add(this.password);
            this.Authentication.Controls.Add(this.email);
            this.Authentication.Controls.Add(this.unblock);
            this.Authentication.Controls.Add(this.PasswordLabel);
            this.Authentication.Controls.Add(this.EmailLabel);
            this.Authentication.Location = new System.Drawing.Point(533, 12);
            this.Authentication.Name = "Authentication";
            this.Authentication.Size = new System.Drawing.Size(219, 173);
            this.Authentication.TabIndex = 0;
            this.Authentication.TabStop = false;
            this.Authentication.Text = "Authentication";
            // 
            // useAccount
            // 
            this.useAccount.AutoSize = true;
            this.useAccount.Location = new System.Drawing.Point(18, 102);
            this.useAccount.Name = "useAccount";
            this.useAccount.Size = new System.Drawing.Size(147, 17);
            this.useAccount.TabIndex = 8;
            this.useAccount.Text = "Download using account?";
            this.Information.SetToolTip(this.useAccount, "Do you want to use an account to download?\r\nYou can download free shows without a" +
        "n account.\r\nKeep in mind that using an account is prefered, espacially if you do" +
        "wnload premiu\r\nm show.");
            this.useAccount.UseVisualStyleBackColor = true;
            this.useAccount.CheckedChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            this.useAccount.TextChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(6, 125);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(207, 38);
            this.save.TabIndex = 7;
            this.save.Text = "Save authentications settings";
            this.Information.SetToolTip(this.save, "Save authintication data so you don\'t have to enter them each time you open this " +
        "application.");
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.SaveAuthentication);
            // 
            // Showpassword
            // 
            this.Showpassword.AutoSize = true;
            this.Showpassword.Location = new System.Drawing.Point(18, 79);
            this.Showpassword.Name = "Showpassword";
            this.Showpassword.Size = new System.Drawing.Size(106, 17);
            this.Showpassword.TabIndex = 6;
            this.Showpassword.Text = "Show password?";
            this.Information.SetToolTip(this.Showpassword, "Display the password in password field instead of stars.");
            this.Showpassword.UseVisualStyleBackColor = true;
            this.Showpassword.CheckedChanged += new System.EventHandler(this.Showpassword_CheckedChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(78, 53);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(133, 20);
            this.password.TabIndex = 5;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(78, 27);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(133, 20);
            this.email.TabIndex = 4;
            this.email.TextChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            // 
            // unblock
            // 
            this.unblock.AutoSize = true;
            this.unblock.Location = new System.Drawing.Point(130, 79);
            this.unblock.Name = "unblock";
            this.unblock.Size = new System.Drawing.Size(68, 17);
            this.unblock.TabIndex = 3;
            this.unblock.Text = "Unblock?";
            this.Information.SetToolTip(this.unblock, "Use a USA Crunchyroll session");
            this.unblock.UseVisualStyleBackColor = true;
            this.unblock.CheckedChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            this.unblock.TextChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(15, 56);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(57, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password:";
            this.Information.SetToolTip(this.PasswordLabel, "Password");
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(15, 27);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email:";
            this.Information.SetToolTip(this.EmailLabel, "Username or Email");
            // 
            // inputURL
            // 
            this.inputURL.Location = new System.Drawing.Point(82, 24);
            this.inputURL.Name = "inputURL";
            this.inputURL.Size = new System.Drawing.Size(427, 20);
            this.inputURL.TabIndex = 8;
            this.inputURL.TextChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Episodes);
            this.groupBox1.Controls.Add(this.saveDownloadSettings);
            this.groupBox1.Controls.Add(this.useDefaultName);
            this.groupBox1.Controls.Add(this.fileName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ignoreDubs);
            this.groupBox1.Controls.Add(this.downloadAll);
            this.groupBox1.Controls.Add(this.debug);
            this.groupBox1.Controls.Add(this.episodesRange);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.language);
            this.groupBox1.Controls.Add(this.dontAutoselectQuality);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.quality);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputURL);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 206);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download";
            // 
            // Episodes
            // 
            this.Episodes.AutoSize = true;
            this.Episodes.Location = new System.Drawing.Point(413, 114);
            this.Episodes.Name = "Episodes";
            this.Episodes.Size = new System.Drawing.Size(73, 17);
            this.Episodes.TabIndex = 20;
            this.Episodes.Text = "Episodes?";
            this.Information.SetToolTip(this.Episodes, "Enable this to specify episode to download.");
            this.Episodes.UseVisualStyleBackColor = true;
            this.Episodes.CheckedChanged += new System.EventHandler(this.Episodes_CheckedChanged);
            // 
            // saveDownloadSettings
            // 
            this.saveDownloadSettings.Location = new System.Drawing.Point(6, 164);
            this.saveDownloadSettings.Name = "saveDownloadSettings";
            this.saveDownloadSettings.Size = new System.Drawing.Size(503, 36);
            this.saveDownloadSettings.TabIndex = 9;
            this.saveDownloadSettings.Text = "Save download settings";
            this.Information.SetToolTip(this.saveDownloadSettings, "Save download settings to the next time you use this application.");
            this.saveDownloadSettings.UseVisualStyleBackColor = true;
            this.saveDownloadSettings.Click += new System.EventHandler(this.SaveDownloadSettings);
            // 
            // useDefaultName
            // 
            this.useDefaultName.AutoSize = true;
            this.useDefaultName.Location = new System.Drawing.Point(413, 140);
            this.useDefaultName.Name = "useDefaultName";
            this.useDefaultName.Size = new System.Drawing.Size(81, 17);
            this.useDefaultName.TabIndex = 19;
            this.useDefaultName.Text = "Use default";
            this.Information.SetToolTip(this.useDefaultName, "Use the default naming bundled with Crunchyroll-dl.");
            this.useDefaultName.UseVisualStyleBackColor = true;
            this.useDefaultName.CheckedChanged += new System.EventHandler(this.UseDefault_CheckedChanged);
            this.useDefaultName.TextChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(82, 138);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(325, 20);
            this.fileName.TabIndex = 18;
            this.fileName.Text = ":name - :ep [:resolution]";
            this.fileName.TextChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "File name:";
            this.Information.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // ignoreDubs
            // 
            this.ignoreDubs.AutoSize = true;
            this.ignoreDubs.Location = new System.Drawing.Point(211, 83);
            this.ignoreDubs.Name = "ignoreDubs";
            this.ignoreDubs.Size = new System.Drawing.Size(84, 17);
            this.ignoreDubs.TabIndex = 16;
            this.ignoreDubs.Text = "Ignore dubs";
            this.Information.SetToolTip(this.ignoreDubs, "Attempt to ignore dubs.");
            this.ignoreDubs.UseVisualStyleBackColor = true;
            this.ignoreDubs.CheckedChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            this.ignoreDubs.TextChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            // 
            // downloadAll
            // 
            this.downloadAll.AutoSize = true;
            this.downloadAll.Location = new System.Drawing.Point(413, 83);
            this.downloadAll.Name = "downloadAll";
            this.downloadAll.Size = new System.Drawing.Size(86, 17);
            this.downloadAll.TabIndex = 15;
            this.downloadAll.Text = "Download all";
            this.Information.SetToolTip(this.downloadAll, "Download all collections (no dialog).");
            this.downloadAll.UseVisualStyleBackColor = true;
            this.downloadAll.CheckedChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            this.downloadAll.TextChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(413, 57);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(62, 17);
            this.debug.TabIndex = 8;
            this.debug.Text = "Debug?";
            this.Information.SetToolTip(this.debug, "Debug information.");
            this.debug.UseVisualStyleBackColor = true;
            this.debug.CheckedChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            this.debug.TextChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            // 
            // episodesRange
            // 
            this.episodesRange.Enabled = false;
            this.episodesRange.Location = new System.Drawing.Point(82, 112);
            this.episodesRange.Name = "episodesRange";
            this.episodesRange.Size = new System.Drawing.Size(325, 20);
            this.episodesRange.TabIndex = 8;
            this.episodesRange.TextChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Episodes:";
            this.Information.SetToolTip(this.label4, "Episodes range. \r\nYou can select from-to, or you can specifiy episodes by numbers" +
        ".\r\nExample: \r\n1-2,12-15,18-20\r\nor\r\n1,3,5,7");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Language:";
            this.Information.SetToolTip(this.label3, "Subtitle language to download.");
            // 
            // language
            // 
            this.language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.language.FormattingEnabled = true;
            this.language.Items.AddRange(new object[] {
            "arME",
            "deDE",
            "enGB",
            "enUS",
            "esES",
            "esLA",
            "frFR",
            "itIT",
            "ptBR",
            "ptPT",
            "ruRU",
            "none"});
            this.language.Location = new System.Drawing.Point(82, 80);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(110, 21);
            this.language.TabIndex = 12;
            this.Information.SetToolTip(this.language, resources.GetString("language.ToolTip"));
            this.language.SelectedIndexChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            this.language.TextChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            // 
            // dontAutoselectQuality
            // 
            this.dontAutoselectQuality.AutoSize = true;
            this.dontAutoselectQuality.Location = new System.Drawing.Point(211, 57);
            this.dontAutoselectQuality.Name = "dontAutoselectQuality";
            this.dontAutoselectQuality.Size = new System.Drawing.Size(183, 17);
            this.dontAutoselectQuality.TabIndex = 11;
            this.dontAutoselectQuality.Text = "Don\'t automatically select quality";
            this.Information.SetToolTip(this.dontAutoselectQuality, "Don\'t automatically select quality if requested is not available (i.e. if 1080p w" +
        "as specified and is not available, fail).");
            this.dontAutoselectQuality.UseVisualStyleBackColor = true;
            this.dontAutoselectQuality.CheckedChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quality:";
            this.Information.SetToolTip(this.label2, "The quality/resolution to download.");
            // 
            // quality
            // 
            this.quality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quality.FormattingEnabled = true;
            this.quality.Items.AddRange(new object[] {
            "auto",
            "1080p",
            "720p",
            "480p",
            "360p",
            "240"});
            this.quality.Location = new System.Drawing.Point(82, 53);
            this.quality.Name = "quality";
            this.quality.Size = new System.Drawing.Size(110, 21);
            this.quality.TabIndex = 9;
            this.Information.SetToolTip(this.quality, "Default is auto, auto will select the highest resolution available.");
            this.quality.SelectedIndexChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            this.quality.TextChanged += new System.EventHandler(this.GenerateCommandLineLoader);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Url:";
            this.Information.SetToolTip(this.label1, "The episode/series to download.");
            // 
            // Information
            // 
            this.Information.AutomaticDelay = 0;
            this.Information.AutoPopDelay = 30000;
            this.Information.InitialDelay = 500;
            this.Information.IsBalloon = true;
            this.Information.ReshowDelay = 100;
            this.Information.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Information.ToolTipTitle = "Information";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(6, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(728, 36);
            this.button2.TabIndex = 16;
            this.button2.Text = "EXECUTE COMMAND";
            this.Information.SetToolTip(this.button2, "execute the command to crunchyrol-dl.\r\n(it will download to the same directory as" +
        " this application).");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ExeecuteCommand);
            // 
            // CommandLine
            // 
            this.CommandLine.Location = new System.Drawing.Point(6, 19);
            this.CommandLine.Multiline = true;
            this.CommandLine.Name = "CommandLine";
            this.CommandLine.ReadOnly = true;
            this.CommandLine.Size = new System.Drawing.Size(726, 54);
            this.CommandLine.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CommandLine);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(12, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(740, 121);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Command";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(548, 199);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Abu3safeer@GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(663, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Version 1.3.6";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 346);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Authentication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crunchyroll-dl-gui 1.3.6";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Authentication.ResumeLayout(false);
            this.Authentication.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Authentication;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.CheckBox unblock;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.CheckBox Showpassword;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox inputURL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox quality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox dontAutoselectQuality;
        private System.Windows.Forms.ToolTip Information;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox language;
        private System.Windows.Forms.TextBox episodesRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox useAccount;
        private System.Windows.Forms.CheckBox debug;
        private System.Windows.Forms.CheckBox downloadAll;
        private System.Windows.Forms.TextBox CommandLine;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ignoreDubs;
        private System.Windows.Forms.CheckBox useDefaultName;
        private System.Windows.Forms.Button saveDownloadSettings;
        private System.Windows.Forms.CheckBox Episodes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
    }
}

