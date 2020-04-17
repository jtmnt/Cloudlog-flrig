using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloudlog_flrig
{
    public partial class Settings : Form
    {        
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.FLRigURL)) 
            {
                Properties.Settings.Default.FLRigURL = "http://127.0.0.1:12345";
            }
            textBoxCloudlogURL.Text = Properties.Settings.Default.CloudlogURL;
            textBoxCloudlogAPIKey.Text = Properties.Settings.Default.CloudlogAPIKey;
            textBoxFLRigURL.Text = Properties.Settings.Default.FLRigURL;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CloudlogURL = textBoxCloudlogURL.Text;
            Properties.Settings.Default.CloudlogAPIKey = textBoxCloudlogAPIKey.Text;
            Properties.Settings.Default.FLRigURL = textBoxFLRigURL.Text;

            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.FLRigURL))
            {
                Properties.Settings.Default.FLRigURL = "http://127.0.0.1:12345";
            }

            Properties.Settings.Default.Save();

            DialogResult = DialogResult.OK;
        }
    }
}
