using System;
using System.Windows.Forms;

namespace crunchyroll_dl_gui
{
    public partial class MainForm : Form
    {
        string Command;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            // Load Authentications settings
            email.Text = Properties.Settings.Default.Email;
            password.Text = Properties.Settings.Default.Password;
            unblock.Checked = Properties.Settings.Default.Unblock;
            quality.Text = Properties.Settings.Default.Resolution;
            language.Text = Properties.Settings.Default.Language;
            dontAutoselectQuality.Checked = Properties.Settings.Default.DontAutoselectQuality;
            useAccount.Checked = Properties.Settings.Default.UseAccount;

            // Load DOwnload settings
            quality.Text = Properties.Settings.Default.Quality;
            language.Text = Properties.Settings.Default.Language;
            dontAutoselectQuality.Checked = Properties.Settings.Default.DontAutoselectQuality;
            ignoreDubs.Checked = Properties.Settings.Default.IgnoreDubs;
            debug.Checked = Properties.Settings.Default.Debug;
            downloadAll.Checked = Properties.Settings.Default.DownloadAll;
            episodesRange.Text = Properties.Settings.Default.EpisodesRange;
            Episodes.Checked = Properties.Settings.Default.Episodes;
            fileName.Text = Properties.Settings.Default.FileName;
            useDefaultName.Checked = Properties.Settings.Default.UseDefaultName;

            // prepare command
            GenerateCommandLine();
        }

        private void SaveAuthentication(object sender, EventArgs e)
        {
            Properties.Settings.Default.Email = email.Text;
            Properties.Settings.Default.Password = password.Text;
            Properties.Settings.Default.Unblock = unblock.Checked;
            Properties.Settings.Default.UseAccount = useAccount.Checked;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void GenerateCommandLine()
        {

            Command = "";
                      
            // Check if user selected to use an account
            if(useAccount.Checked)
            {
                // set email
                Command += "--username " + email.Text + " ";
                // set password
                Command += "--password " + password.Text + " ";
            }

            // Check if user selected to unblock
            if(unblock.Checked)
            {
                // use Crunchyroll unblock feature
                Command +=  "--unblocked ";
            }

            // set language
            Command += "--language " + language.Text + " ";

            // set quality
            Command += "--quality " + quality.Text + " ";

            // Check if "Don't automatically select quality" is checked
            if (dontAutoselectQuality.Checked)
            {
                // Use "Don't automatically select quality" feature
                Command += "--dont-autoselect-quality ";
            }

            // Check if "Dowload all" is checked
            if (downloadAll.Checked)
            {
                // Use "Dowload all" feature
                Command += "--download-all ";
            }

            // Check if "Ignore dubs" is checked
            if (ignoreDubs.Checked)
            {
                Command += "--ignore-dubs ";
            }

            // Check if Episodes is enabled
            if(Episodes.Checked)
            {
                Command += "--episodes " + episodesRange.Text + " ";
            }

            // Check if "useDefault" is NOT checked
            if(useDefaultName.Checked == false)
            {
                Command += "--output \"" + fileName.Text + "\" ";
            }

            // Check if debug is enabled
            if(debug.Checked)
            {
                Command += "--debug ";
            }

            // set the URL
            Command += "--input " + inputURL.Text;

            CommandLine.Text = "crunchyroll-dl " + Command;
        }


        private void Showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if(Showpassword.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void Episodes_CheckedChanged(object sender, EventArgs e)
        {
            if(Episodes.Checked)
            {
                episodesRange.Enabled = true;
            }
            else
            {
                episodesRange.Enabled = false;
            }
            GenerateCommandLine();
        }

        private void UseDefault_CheckedChanged(object sender, EventArgs e)
        {
            if(useDefaultName.Checked)
            {
                fileName.Enabled = false;
            }
            else
            {
                fileName.Enabled = true;
            }
            GenerateCommandLine();
        }

        private void GenerateCommandLineLoader(object sender, EventArgs e)
        {
            GenerateCommandLine();
        }

        private void SaveDownloadSettings(object sender, EventArgs e)
        {
            Properties.Settings.Default.Quality = quality.Text;
            Properties.Settings.Default.Language = language.Text;
            Properties.Settings.Default.DontAutoselectQuality = dontAutoselectQuality.Checked;
            Properties.Settings.Default.IgnoreDubs = ignoreDubs.Checked;
            Properties.Settings.Default.Debug = debug.Checked;
            Properties.Settings.Default.DownloadAll = downloadAll.Checked;
            Properties.Settings.Default.EpisodesRange = episodesRange.Text;
            Properties.Settings.Default.Episodes = Episodes.Checked;
            Properties.Settings.Default.FileName = fileName.Text;
            Properties.Settings.Default.UseDefaultName = useDefaultName.Checked;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void ExeecuteCommand(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("crunchyroll-dl", Command);
        }
    }
}
