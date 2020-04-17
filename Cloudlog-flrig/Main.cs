﻿using Cloudlog_flrig.Models;
using CookComputing.XmlRpc;
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
    public partial class Main : Form
    {
        private Models.RadioInfo lastSyncedRadioInfo = null;
        private DateTime dttmLastSyncedTimeUTC;

        public Main()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            UpdateRadioInfo();
        }

        private CloudlogAPI.CloudlogAPIClient m_CloudlogAPIClient = null;

        private CloudlogAPI.CloudlogAPIClient CloudlogAPIClient
        {
            get
            {
                if (m_CloudlogAPIClient == null) m_CloudlogAPIClient = new CloudlogAPI.CloudlogAPIClient();
                return m_CloudlogAPIClient;
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Settings frm = new Settings())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    UpdateRadioInfo();
                }
            }
        }

        private void timerUpdateRadioInfo_Tick(object sender, EventArgs e)
        {
            UpdateRadioInfo();
        }

        private void UpdateRadioInfo()
        {
            timerUpdateRadioInfo.Stop();
            try
            {
                if (string.IsNullOrWhiteSpace(Properties.Settings.Default.CloudlogURL))
                {
                    UpdateStatus($"Error: missing Cloudlog URL!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(Properties.Settings.Default.CloudlogAPIKey))
                {
                    UpdateStatus($"Error: missing Cloudlog API Key!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(Properties.Settings.Default.FLRigURL))
                {
                    UpdateStatus($"Error: missing FLRig URL!");
                    return;
                }

                Models.RadioInfo radioInfo = null;

                try
                {
                    radioInfo = GetRadioInfoFromFlRig();
                }
                catch (Exception e)
                {
                    UpdateStatus($"Error contacting FLRig: {e.Message}");
                    timerUpdateRadioInfo.Interval = 10 * 1000;
                }

                UpdateRadioInfoTextBoxes(radioInfo);

                if (radioInfo != null)
                {
                    try
                    {
                        if (lastSyncedRadioInfo == null ||
                            (lastSyncedRadioInfo.Frequency != radioInfo.Frequency) ||
                            (lastSyncedRadioInfo.Mode != radioInfo.Mode) ||
                            (dttmLastSyncedTimeUTC.AddSeconds(30) < DateTime.UtcNow)
                           )
                        {
                            var result = CloudlogAPIClient.SendRadioInfo(Properties.Settings.Default.CloudlogURL, Properties.Settings.Default.CloudlogAPIKey, radioInfo);

                            if (result.status == "success")
                            {
                                lastSyncedRadioInfo = radioInfo;
                                dttmLastSyncedTimeUTC = DateTime.UtcNow;

                                UpdateStatus($"Last synced to cloudlog: {DateTime.Now.ToString("G")}");

                                timerUpdateRadioInfo.Interval = 1000;

                                timerUpdateRadioInfo.Tag = null;
                            }
                            else
                            {
                                UpdateStatus($"Cloudlog API Error: status: {result.status}, reason: {result.reason}");
                                timerUpdateRadioInfo.Tag = result;
                                return;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        UpdateStatus($"Error contacting cloudlog: Check Cloudlog URL!");
                        timerUpdateRadioInfo.Interval = 10 * 1000;
                    }
                }
            }
            finally
            {
                if (timerUpdateRadioInfo.Tag == null)
                {
                    timerUpdateRadioInfo.Start();
                }
            }
        }

        private void UpdateRadioInfoTextBoxes(RadioInfo radioInfo)
        {
            textBoxRadioName.Text = radioInfo?.RadioName;
            textBoxFrequency.Text = radioInfo?.Frequency.ToString();
            textBoxMode.Text = radioInfo?.Mode;

            this.Update();
        }

        private void UpdateStatus(string v)
        {
            toolStripStatusLabel.Text = v;
            statusStrip1.Refresh();
            this.Update();

            notifyIcon.Text = $"Cloudlog-flrig: {v}";
        }

        private RadioInfo GetRadioInfoFromFlRig()
        {
            FLRigAPI.FLRigClient flRigClient = new FLRigAPI.FLRigClient();

            RadioInfo radioInfo = flRigClient.GetRadioInfo();

            return radioInfo;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                notifyIcon.BalloonTipText = "Cloudlog-flrig minimized to notification area!";
                //notifyIcon.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
        }
    }
}
