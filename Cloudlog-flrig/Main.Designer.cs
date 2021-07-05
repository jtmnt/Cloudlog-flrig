namespace Cloudlog_flrig
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerUpdateRadioInfo = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRadioName = new System.Windows.Forms.TextBox();
            this.textBoxFrequency = new System.Windows.Forms.TextBox();
            this.textBoxMode = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRadioFLRig = new System.Windows.Forms.TabPage();
            this.tabPageRadioCustom = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCustomMode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCustomFrequency = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCustomRadioName = new System.Windows.Forms.TextBox();
            this.checkBoxCustomRadioEnabled = new System.Windows.Forms.CheckBox();
            this.timerUpdateCustomRadioInfo = new System.Windows.Forms.Timer(this.components);
            this.buttonCustomBand2m = new System.Windows.Forms.Button();
            this.buttonCustomBand70cm = new System.Windows.Forms.Button();
            this.buttonCustomFrequencyAdd25K = new System.Windows.Forms.Button();
            this.buttonCustomFrequencySubtract25K = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageRadioFLRig.SuspendLayout();
            this.tabPageRadioCustom.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 179);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(464, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripStatusLabel.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel.Text = "Loading...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // timerUpdateRadioInfo
            // 
            this.timerUpdateRadioInfo.Interval = 10000;
            this.timerUpdateRadioInfo.Tick += new System.EventHandler(this.timerUpdateRadioInfo_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Radio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Frequency:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mode:";
            // 
            // textBoxRadioName
            // 
            this.textBoxRadioName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRadioName.Location = new System.Drawing.Point(76, 12);
            this.textBoxRadioName.Name = "textBoxRadioName";
            this.textBoxRadioName.ReadOnly = true;
            this.textBoxRadioName.Size = new System.Drawing.Size(372, 20);
            this.textBoxRadioName.TabIndex = 8;
            // 
            // textBoxFrequency
            // 
            this.textBoxFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFrequency.Location = new System.Drawing.Point(76, 38);
            this.textBoxFrequency.Name = "textBoxFrequency";
            this.textBoxFrequency.ReadOnly = true;
            this.textBoxFrequency.Size = new System.Drawing.Size(372, 20);
            this.textBoxFrequency.TabIndex = 9;
            // 
            // textBoxMode
            // 
            this.textBoxMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMode.Location = new System.Drawing.Point(76, 64);
            this.textBoxMode.Name = "textBoxMode";
            this.textBoxMode.ReadOnly = true;
            this.textBoxMode.Size = new System.Drawing.Size(372, 20);
            this.textBoxMode.TabIndex = 10;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRadioFLRig);
            this.tabControl1.Controls.Add(this.tabPageRadioCustom);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(464, 155);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPageRadioFLRig
            // 
            this.tabPageRadioFLRig.Controls.Add(this.label1);
            this.tabPageRadioFLRig.Controls.Add(this.textBoxMode);
            this.tabPageRadioFLRig.Controls.Add(this.label4);
            this.tabPageRadioFLRig.Controls.Add(this.textBoxFrequency);
            this.tabPageRadioFLRig.Controls.Add(this.label6);
            this.tabPageRadioFLRig.Controls.Add(this.textBoxRadioName);
            this.tabPageRadioFLRig.Location = new System.Drawing.Point(4, 22);
            this.tabPageRadioFLRig.Name = "tabPageRadioFLRig";
            this.tabPageRadioFLRig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRadioFLRig.Size = new System.Drawing.Size(456, 132);
            this.tabPageRadioFLRig.TabIndex = 0;
            this.tabPageRadioFLRig.Text = "FLRig Radio Info";
            this.tabPageRadioFLRig.UseVisualStyleBackColor = true;
            // 
            // tabPageRadioCustom
            // 
            this.tabPageRadioCustom.Controls.Add(this.buttonCustomFrequencySubtract25K);
            this.tabPageRadioCustom.Controls.Add(this.buttonCustomFrequencyAdd25K);
            this.tabPageRadioCustom.Controls.Add(this.buttonCustomBand70cm);
            this.tabPageRadioCustom.Controls.Add(this.buttonCustomBand2m);
            this.tabPageRadioCustom.Controls.Add(this.checkBoxCustomRadioEnabled);
            this.tabPageRadioCustom.Controls.Add(this.label2);
            this.tabPageRadioCustom.Controls.Add(this.textBoxCustomMode);
            this.tabPageRadioCustom.Controls.Add(this.label3);
            this.tabPageRadioCustom.Controls.Add(this.textBoxCustomFrequency);
            this.tabPageRadioCustom.Controls.Add(this.label5);
            this.tabPageRadioCustom.Controls.Add(this.textBoxCustomRadioName);
            this.tabPageRadioCustom.Location = new System.Drawing.Point(4, 22);
            this.tabPageRadioCustom.Name = "tabPageRadioCustom";
            this.tabPageRadioCustom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRadioCustom.Size = new System.Drawing.Size(456, 129);
            this.tabPageRadioCustom.TabIndex = 1;
            this.tabPageRadioCustom.Text = "Custom Radio Info";
            this.tabPageRadioCustom.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Radio:";
            // 
            // textBoxCustomMode
            // 
            this.textBoxCustomMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustomMode.Location = new System.Drawing.Point(76, 64);
            this.textBoxCustomMode.Name = "textBoxCustomMode";
            this.textBoxCustomMode.Size = new System.Drawing.Size(372, 20);
            this.textBoxCustomMode.TabIndex = 16;
            this.textBoxCustomMode.Text = "FM";
            this.textBoxCustomMode.TextChanged += new System.EventHandler(this.textBoxCustomMode_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Frequency:";
            // 
            // textBoxCustomFrequency
            // 
            this.textBoxCustomFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustomFrequency.Location = new System.Drawing.Point(76, 38);
            this.textBoxCustomFrequency.Name = "textBoxCustomFrequency";
            this.textBoxCustomFrequency.Size = new System.Drawing.Size(107, 20);
            this.textBoxCustomFrequency.TabIndex = 15;
            this.textBoxCustomFrequency.Text = "145500000";
            this.textBoxCustomFrequency.TextChanged += new System.EventHandler(this.textBoxCustomFrequency_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mode:";
            // 
            // textBoxCustomRadioName
            // 
            this.textBoxCustomRadioName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustomRadioName.Location = new System.Drawing.Point(76, 12);
            this.textBoxCustomRadioName.Name = "textBoxCustomRadioName";
            this.textBoxCustomRadioName.Size = new System.Drawing.Size(372, 20);
            this.textBoxCustomRadioName.TabIndex = 14;
            this.textBoxCustomRadioName.Text = "FT-8900R";
            this.textBoxCustomRadioName.TextChanged += new System.EventHandler(this.textBoxCustomRadioName_TextChanged);
            // 
            // checkBoxCustomRadioEnabled
            // 
            this.checkBoxCustomRadioEnabled.AutoSize = true;
            this.checkBoxCustomRadioEnabled.Location = new System.Drawing.Point(76, 91);
            this.checkBoxCustomRadioEnabled.Name = "checkBoxCustomRadioEnabled";
            this.checkBoxCustomRadioEnabled.Size = new System.Drawing.Size(65, 17);
            this.checkBoxCustomRadioEnabled.TabIndex = 17;
            this.checkBoxCustomRadioEnabled.Text = "Enabled";
            this.checkBoxCustomRadioEnabled.UseVisualStyleBackColor = true;
            this.checkBoxCustomRadioEnabled.CheckedChanged += new System.EventHandler(this.checkBoxCustomRadioEnabled_CheckedChanged);
            // 
            // timerUpdateCustomRadioInfo
            // 
            this.timerUpdateCustomRadioInfo.Interval = 10000;
            this.timerUpdateCustomRadioInfo.Tick += new System.EventHandler(this.timerUpdateCustomRadioInfo_Tick);
            // 
            // buttonCustomBand2m
            // 
            this.buttonCustomBand2m.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCustomBand2m.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonCustomBand2m.Location = new System.Drawing.Point(349, 36);
            this.buttonCustomBand2m.Name = "buttonCustomBand2m";
            this.buttonCustomBand2m.Size = new System.Drawing.Size(42, 23);
            this.buttonCustomBand2m.TabIndex = 19;
            this.buttonCustomBand2m.Text = "2m";
            this.buttonCustomBand2m.UseVisualStyleBackColor = true;
            this.buttonCustomBand2m.Click += new System.EventHandler(this.buttonCustomBand2m_Click);
            // 
            // buttonCustomBand70cm
            // 
            this.buttonCustomBand70cm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCustomBand70cm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonCustomBand70cm.Location = new System.Drawing.Point(397, 36);
            this.buttonCustomBand70cm.Name = "buttonCustomBand70cm";
            this.buttonCustomBand70cm.Size = new System.Drawing.Size(51, 23);
            this.buttonCustomBand70cm.TabIndex = 20;
            this.buttonCustomBand70cm.Text = "70cm";
            this.buttonCustomBand70cm.UseVisualStyleBackColor = true;
            this.buttonCustomBand70cm.Click += new System.EventHandler(this.buttonCustomBand70cm_Click);
            // 
            // buttonCustomFrequencyAdd25K
            // 
            this.buttonCustomFrequencyAdd25K.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCustomFrequencyAdd25K.Location = new System.Drawing.Point(264, 36);
            this.buttonCustomFrequencyAdd25K.Name = "buttonCustomFrequencyAdd25K";
            this.buttonCustomFrequencyAdd25K.Size = new System.Drawing.Size(69, 23);
            this.buttonCustomFrequencyAdd25K.TabIndex = 21;
            this.buttonCustomFrequencyAdd25K.Text = "+ 25 kHz";
            this.buttonCustomFrequencyAdd25K.UseVisualStyleBackColor = true;
            this.buttonCustomFrequencyAdd25K.Click += new System.EventHandler(this.buttonCustomFrequencyAdd25K_Click);
            // 
            // buttonCustomFrequencySubtract25K
            // 
            this.buttonCustomFrequencySubtract25K.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCustomFrequencySubtract25K.Location = new System.Drawing.Point(189, 36);
            this.buttonCustomFrequencySubtract25K.Name = "buttonCustomFrequencySubtract25K";
            this.buttonCustomFrequencySubtract25K.Size = new System.Drawing.Size(69, 23);
            this.buttonCustomFrequencySubtract25K.TabIndex = 22;
            this.buttonCustomFrequencySubtract25K.Text = "- 25 kHz";
            this.buttonCustomFrequencySubtract25K.UseVisualStyleBackColor = true;
            this.buttonCustomFrequencySubtract25K.Click += new System.EventHandler(this.buttonCustomFrequencySubtract25K_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 201);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 240);
            this.Name = "Main";
            this.Text = "Coudlog-flrig";
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageRadioFLRig.ResumeLayout(false);
            this.tabPageRadioFLRig.PerformLayout();
            this.tabPageRadioCustom.ResumeLayout(false);
            this.tabPageRadioCustom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Timer timerUpdateRadioInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRadioName;
        private System.Windows.Forms.TextBox textBoxFrequency;
        private System.Windows.Forms.TextBox textBoxMode;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRadioFLRig;
        private System.Windows.Forms.TabPage tabPageRadioCustom;
        private System.Windows.Forms.CheckBox checkBoxCustomRadioEnabled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCustomMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCustomFrequency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCustomRadioName;
        private System.Windows.Forms.Timer timerUpdateCustomRadioInfo;
        private System.Windows.Forms.Button buttonCustomBand70cm;
        private System.Windows.Forms.Button buttonCustomBand2m;
        private System.Windows.Forms.Button buttonCustomFrequencySubtract25K;
        private System.Windows.Forms.Button buttonCustomFrequencyAdd25K;
    }
}

