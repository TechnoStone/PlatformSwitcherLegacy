using System;
using System.Reflection;
using System.Windows.Forms;

namespace Grand_Theft_Auto_V_Platform_Switcher
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void BtnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://TechnoSt.one/donate");
        }

        private void LblProductVersion_Click(object sender, EventArgs e)
        {
            
        }

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            LblProductVersion.Text = "Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void LinkLblTS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://TechnoSt.one");
        }

        private void LinkLblTG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/TechnoStones");
        }
    }
}
