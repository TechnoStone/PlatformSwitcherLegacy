using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Principal;

namespace Grand_Theft_Auto_V_Platform_Switcher
{
    public partial class MainWindow : Form
    {
        string _pp = "";
        string _cp = "";
        string _gb = "";
        string _rglVer = "";
        string _steamVer = "";
        string _eglVer = "";

        string _exPath = Environment.CurrentDirectory + "\\Switcher.log";
        string _steamApi64Orig = Environment.CurrentDirectory + "\\steam_api64.dll";
        string _steamApi64Back = Environment.CurrentDirectory + "\\steam_api64.dll.steam";

        string _tmbLaunchError =
            "Current platform in config file is wrong.\nPlease, select needed platform by clicking one of the big buttons above.";

        string _tmbFixSteam = "Relaunch Rockstar Games Launcher\nThen install game to steamapps\\common folder";

        string _tmbFixEpic =
            "Relaunch Rockstar Games Launcher\nThen install game to steamapps\\common folder if you're planning to switch to Steam\nOr to folder above current if you want to switch to RGL only";

        // string _tmbSteamApi64NotFound =
        //     "There are no any steam_api64.dll files detected in the folder. Please consider verifying your game files via Steam";

        string _tmbConfigCorrupted =
            "Unable to read the config. It's probably corrupted or inaccesible, or you have not installed Switcher properly.\nIf you have ran the Switcher directly from archive - unpack archive to game folder (place everything from it next to GTA5.exe), open Switcher from folder, click About - How to use";

        string _oops = "Oops, something went wrong! Or maybe not...";
        string _tmbIdkWhatAreYouTryingToDo = "I don't really know what do you want me to do.";

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Switch()
        {
            lblGameVer.Text = _gb + "\n" + _rglVer + "\n" + _steamVer + "\n" + _eglVer + "\n" + _cp;
            Process.Start("xcopy", "\"Switcher\\" + _cp + "\" /f /y");
            if (_cp == "RGL" || _cp == "EGL")
            {
                if (File.Exists(_steamApi64Orig) == true && File.Exists(_steamApi64Back) == false)
                {
                    try
                    {
                        {
                            File.Move("steam_api64.dll", "steam_api64.dll.steam");
                        }
                    }
                    catch (Exception ex)
                    {
                        using (StreamWriter writer = new StreamWriter(_exPath, true))
                        {
                            if (_pp != "RGL" && _pp != "EGL")
                            {
                                while (ex != null)
                                {
                                    writer.WriteLine(
                                        "-----------------------------------------------------------------------------");
                                    writer.WriteLine("Date : " + DateTime.Now.ToString());
                                    writer.WriteLine("Switching from " + _pp + " to " + _cp);
                                    writer.WriteLine();
                                    writer.WriteLine(ex.GetType().FullName);
                                    writer.WriteLine("Message : " + ex.Message);
                                    writer.WriteLine("StackTrace : " + ex.StackTrace);

                                    ex = ex.InnerException;
                                }
                            }
                        }
                    }
                }
            }
            else if (_cp == "Steam")
            {
                if (File.Exists(_steamApi64Back) == true && File.Exists(_steamApi64Orig) == false)
                {
                    try
                    {
                        File.Move("steam_api64.dll.steam", "steam_api64.dll");
                    }
                    catch (Exception ex)
                    {
                        using (StreamWriter writer = new StreamWriter(_exPath, true))
                        {
                            if (_pp != "Steam")
                            {
                                while (ex != null)
                                {
                                    writer.WriteLine(
                                        "-----------------------------------------------------------------------------");
                                    writer.WriteLine("Date : " + DateTime.Now.ToString());
                                    writer.WriteLine("Switching from " + _pp + " to " + _cp);
                                    writer.WriteLine();
                                    writer.WriteLine(ex.GetType().FullName);
                                    writer.WriteLine("Message : " + ex.Message);
                                    writer.WriteLine("StackTrace : " + ex.StackTrace);

                                    ex = ex.InnerException;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(_tmbIdkWhatAreYouTryingToDo, _oops, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("PreviousPlatform");
            config.AppSettings.Settings.Add("PreviousPlatform", _pp);
            config.AppSettings.Settings.Remove("CurrentPlatform");
            config.AppSettings.Settings.Add("CurrentPlatform", _cp);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            System.Threading.Thread.Sleep(1000);
            CheckVersions();
        }

        public void CheckVersions()
        {
            if (!File.Exists(System.AppDomain.CurrentDomain.FriendlyName + ".config") &&
                !File.Exists(System.AppDomain.CurrentDomain.FriendlyName + ".Config"))
            {
                MessageBox.Show(_tmbConfigCorrupted, _oops, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _pp = ConfigurationManager.AppSettings["PreviousPlatform"];
            _cp = ConfigurationManager.AppSettings["CurrentPlatform"];
            try
            {
                FileVersionInfo currentFolderExe =
                    FileVersionInfo.GetVersionInfo(Environment.CurrentDirectory + "\\GTA5.exe");
                _gb = currentFolderExe.FileVersion;
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(_exPath, true))
                {
                    while (ex != null)
                    {
                        writer.WriteLine(
                            "-----------------------------------------------------------------------------");
                        writer.WriteLine("Date : " + DateTime.Now.ToString());
                        writer.WriteLine();
                        writer.WriteLine(ex.GetType().FullName);
                        writer.WriteLine("Message : " + ex.Message);
                        writer.WriteLine("StackTrace : " + ex.StackTrace);

                        ex = ex.InnerException;
                    }
                }
            }

            try
            {
                FileVersionInfo rglExe =
                    FileVersionInfo.GetVersionInfo(Environment.CurrentDirectory + @"\Switcher\RGL\GTA5.exe");
                _rglVer = rglExe.FileVersion;
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(_exPath, true))
                {
                    while (ex != null)
                    {
                        writer.WriteLine(
                            "-----------------------------------------------------------------------------");
                        writer.WriteLine("Date : " + DateTime.Now.ToString());
                        writer.WriteLine();
                        writer.WriteLine(ex.GetType().FullName);
                        writer.WriteLine("Message : " + ex.Message);
                        writer.WriteLine("StackTrace : " + ex.StackTrace);

                        ex = ex.InnerException;
                    }
                }
            }

            try
            {
                FileVersionInfo steamExe =
                    FileVersionInfo.GetVersionInfo(Environment.CurrentDirectory + @"\Switcher\Steam\GTA5.exe");
                _steamVer = steamExe.FileVersion;
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(_exPath, true))
                {
                    while (ex != null)
                    {
                        writer.WriteLine(
                            "-----------------------------------------------------------------------------");
                        writer.WriteLine("Date : " + DateTime.Now.ToString());
                        writer.WriteLine();
                        writer.WriteLine(ex.GetType().FullName);
                        writer.WriteLine("Message : " + ex.Message);
                        writer.WriteLine("StackTrace : " + ex.StackTrace);

                        ex = ex.InnerException;
                    }
                }
            }

            try
            {
                FileVersionInfo eglExe =
                    FileVersionInfo.GetVersionInfo(Environment.CurrentDirectory + @"\Switcher\EGL\GTA5.exe");
                _eglVer = eglExe.FileVersion;
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(_exPath, true))
                {
                    while (ex != null)
                    {
                        writer.WriteLine(
                            "-----------------------------------------------------------------------------");
                        writer.WriteLine("Date : " + DateTime.Now.ToString());
                        writer.WriteLine();
                        writer.WriteLine(ex.GetType().FullName);
                        writer.WriteLine("Message : " + ex.Message);
                        writer.WriteLine("StackTrace : " + ex.StackTrace);

                        ex = ex.InnerException;
                    }
                }
            }

            if (_pp != "Steam" && _pp != "RGL" && _pp != "EGL")
            {
                _pp = "Unknown";
            }

            if (_cp != "Steam" && _cp != "RGL" && _cp != "EGL")
            {
                _cp = "Unknown";
            }

            if (!(_gb.Length > 0) || _gb == null)
            {
                _gb = "unknown";
            }

            if (!(_rglVer.Length > 0) || _rglVer == null)
            {
                _rglVer = "unknown";
            }

            if (!(_steamVer.Length > 0) || _steamVer == null)
            {
                _steamVer = "unknown";
            }

            if (!(_eglVer.Length > 0) || _eglVer == null)
            {
                _eglVer = "unknown";
            }

            lblGameVer.Text = _gb + "\n" + _rglVer + "\n" + _steamVer + "\n" + _eglVer + "\n" + _cp;
            try
            {
                if (File.Exists(_steamApi64Orig) == true && File.Exists(_steamApi64Back) == true)
                {
                    if (_cp == "Steam")
                    {
                        File.Delete(_steamApi64Back);
                    }
                    else
                    {
                        File.Delete(_steamApi64Orig);
                    }
                }
                // else if (_cp == "Steam")
                // {
                //     if (File.Exists(_steamApi64Orig) == false && File.Exists(_steamApi64Back) == false)
                //     {
                //         MessageBox.Show(_tmbSteamApi64NotFound, _oops, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //     }
                // }
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(_exPath, true))
                {
                    while (ex != null)
                    {
                        writer.WriteLine(
                            "-----------------------------------------------------------------------------");
                        writer.WriteLine("Date : " + DateTime.Now.ToString());
                        writer.WriteLine("Current platform is " + _cp + ", previous is " + _pp);
                        writer.WriteLine();
                        writer.WriteLine(ex.GetType().FullName);
                        writer.WriteLine("Message : " + ex.Message);
                        writer.WriteLine("StackTrace : " + ex.StackTrace);
                        ex = ex.InnerException;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckVersions();
            bool isElevated;
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);

            if (isElevated == false)
            {
                btnSteamInstalled.Enabled = false;
                btnFixPlayOnSteam.Enabled = false;
                btnFixPlayOnEpic.Enabled = false;
                btnInstallEpic.Enabled = false;
                lblRunAsAdmin.Visible = true;
            }

            ;
        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void CheckForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //using (UpdatesWindow frm = new UpdatesWindow())
            //{
            //    frm.ShowDialog();
            //}
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _pp = _cp;
            _cp = "RGL";
            Switch();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutWindow frm = new AboutWindow())
            {
                frm.ShowDialog();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblTextGameVer_Click(object sender, EventArgs e)
        {
        }

        private void LblGameVer_Click(object sender, EventArgs e)
        {
        }

        private void BtnSteam_Click(object sender, EventArgs e)
        {
            _pp = _cp;
            _cp = "Steam";
            Switch();
        }

        private void BtnLaunch_Click(object sender, EventArgs e)
        {
            string cp = ConfigurationManager.AppSettings["CurrentPlatform"]; // load platform from config
            if (cp == "Steam")
            {
                Process.Start("steam://rungameid/271590");
            }
            else if (cp == "RGL")
            {
                Process.Start("PlayGTAV");
            }
            else if (cp == "EGL")
            {
                Process.Start(
                    "com.epicgames.launcher://apps/9d2d0eb64d5c44529cece33fe2a46482?action=launch&silent=true");
                Application.Exit();
            }
            else
            {
                MessageBox.Show(_tmbLaunchError, _oops, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void troubleshootingToolStripMenuItem_Click(object sender, EventArgs e) =>
            Process.Start("Switcher\\GTA V Platform Switcher.docx");

        private void btnFixPlayOnSteam_Click(object sender, EventArgs e)
        {
            Process.Start("reg", @" add HKCU\SOFTWARE\Valve\Steam\Apps\271590 /v Installed /t REG_DWORD /d 0 /f");
            Process.Start("reg",
                " delete \"" + @"HKLM\SOFTWARE\WOW6432Node\Rockstar Games\GTAV" + "\" /v InstallFolderSteam /f");
            MessageBox.Show(_tmbFixSteam, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _pp = _cp;
            _cp = "RGL";
            Switch();
        }

        private void btnSteamInstalled_Click(object sender, EventArgs e)
        {
            Process.Start("reg", @" add HKCU\SOFTWARE\Valve\Steam\Apps\271590 /v Installed /t REG_DWORD /d 1 /f");
            Process.Start("reg",
                "add \"" + @"HKLM\SOFTWARE\WOW6432Node\Rockstar Games\GTAV" +
                "\" /v InstallFolderSteam /t REG_SZ /d \"" + @Environment.CurrentDirectory + "\\GTAV\"" + @" /f");
        }

        private void btnEpic_Click(object sender, EventArgs e)
        {
            _pp = _cp;
            _cp = "EGL";
            Switch();
        }

        private void btnFixPlayOnEpic_Click(object sender, EventArgs e)
        {
            Process.Start("reg",
                " delete \"" + @"HKLM\SOFTWARE\WOW6432Node\Rockstar Games\Grand Theft Auto V" + "\" /v InstallFolderEpic /f");
            MessageBox.Show(_tmbFixEpic, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInstallEpic_Click(object sender, EventArgs e)
        {
            Process.Start("reg",
                "add \"" + @"HKLM\SOFTWARE\WOW6432Node\Rockstar Games\Grand Theft Auto V" +
                "\" /v InstallFolderEpic /t REG_SZ /d \"" + @Environment.CurrentDirectory + "\" /f");
        }
    }
}