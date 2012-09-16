using System;
using System.Windows.Forms;

namespace V1TaskManager
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigFormLoad(object sender, EventArgs e)
        {
            txtAppPath.Text = Global.Config.ApplicationPath;
            txtUsername.Text = Global.Config.Username;
            txtPassword.Text = Global.Config.Password;
            cbIntegratedSecurity.Checked = Global.Config.UseWindowsIntegrated;
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            Global.Config.ApplicationPath = txtAppPath.Text;
            Global.Config.Username = txtUsername.Text;
            Global.Config.Password = txtPassword.Text;
            Global.Config.UseWindowsIntegrated = cbIntegratedSecurity.Checked;
            Close();
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void cbIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            lblIntegratedUsername.Visible = cbIntegratedSecurity.Checked;
        }
    }
}