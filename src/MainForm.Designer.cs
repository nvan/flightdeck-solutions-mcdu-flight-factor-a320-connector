namespace nvan.FdsFfA320McduConnector
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mcdu1GroupBox = new System.Windows.Forms.GroupBox();
            this.mcdu1PortLabel = new System.Windows.Forms.Label();
            this.mcdu1Check = new System.Windows.Forms.CheckBox();
            this.mcdu1IpLabel = new System.Windows.Forms.Label();
            this.mcdu1IpText = new System.Windows.Forms.TextBox();
            this.mcdu2GroupBox = new System.Windows.Forms.GroupBox();
            this.mcdu2PortText = new System.Windows.Forms.TextBox();
            this.mcdu2PortLabel = new System.Windows.Forms.Label();
            this.mcdu2Check = new System.Windows.Forms.CheckBox();
            this.mcdu2IpLabel = new System.Windows.Forms.Label();
            this.mcdu2IpText = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.mcdu1PortText = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.autoStartCheck = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.mcdu1GroupBox.SuspendLayout();
            this.mcdu2GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcdu1GroupBox
            // 
            this.mcdu1GroupBox.Controls.Add(this.mcdu1PortLabel);
            this.mcdu1GroupBox.Controls.Add(this.mcdu1Check);
            this.mcdu1GroupBox.Controls.Add(this.mcdu1IpLabel);
            this.mcdu1GroupBox.Controls.Add(this.mcdu1IpText);
            this.mcdu1GroupBox.Location = new System.Drawing.Point(12, 12);
            this.mcdu1GroupBox.Name = "mcdu1GroupBox";
            this.mcdu1GroupBox.Size = new System.Drawing.Size(175, 71);
            this.mcdu1GroupBox.TabIndex = 0;
            this.mcdu1GroupBox.TabStop = false;
            this.mcdu1GroupBox.Text = "MCDU 1";
            // 
            // mcdu1PortLabel
            // 
            this.mcdu1PortLabel.AutoSize = true;
            this.mcdu1PortLabel.Location = new System.Drawing.Point(80, 46);
            this.mcdu1PortLabel.Name = "mcdu1PortLabel";
            this.mcdu1PortLabel.Size = new System.Drawing.Size(29, 13);
            this.mcdu1PortLabel.TabIndex = 3;
            this.mcdu1PortLabel.Text = "Port:";
            // 
            // mcdu1Check
            // 
            this.mcdu1Check.AutoSize = true;
            this.mcdu1Check.Location = new System.Drawing.Point(6, 45);
            this.mcdu1Check.Name = "mcdu1Check";
            this.mcdu1Check.Size = new System.Drawing.Size(65, 17);
            this.mcdu1Check.TabIndex = 2;
            this.mcdu1Check.Text = "Enabled";
            this.mcdu1Check.UseVisualStyleBackColor = true;
            // 
            // mcdu1IpLabel
            // 
            this.mcdu1IpLabel.AutoSize = true;
            this.mcdu1IpLabel.Location = new System.Drawing.Point(6, 22);
            this.mcdu1IpLabel.Name = "mcdu1IpLabel";
            this.mcdu1IpLabel.Size = new System.Drawing.Size(20, 13);
            this.mcdu1IpLabel.TabIndex = 1;
            this.mcdu1IpLabel.Text = "IP:";
            // 
            // mcdu1IpText
            // 
            this.mcdu1IpText.Location = new System.Drawing.Point(32, 19);
            this.mcdu1IpText.Name = "mcdu1IpText";
            this.mcdu1IpText.Size = new System.Drawing.Size(137, 20);
            this.mcdu1IpText.TabIndex = 0;
            // 
            // mcdu2GroupBox
            // 
            this.mcdu2GroupBox.Controls.Add(this.mcdu2PortText);
            this.mcdu2GroupBox.Controls.Add(this.mcdu2PortLabel);
            this.mcdu2GroupBox.Controls.Add(this.mcdu2Check);
            this.mcdu2GroupBox.Controls.Add(this.mcdu2IpLabel);
            this.mcdu2GroupBox.Controls.Add(this.mcdu2IpText);
            this.mcdu2GroupBox.Location = new System.Drawing.Point(198, 12);
            this.mcdu2GroupBox.Name = "mcdu2GroupBox";
            this.mcdu2GroupBox.Size = new System.Drawing.Size(175, 71);
            this.mcdu2GroupBox.TabIndex = 1;
            this.mcdu2GroupBox.TabStop = false;
            this.mcdu2GroupBox.Text = "MCDU 2";
            // 
            // mcdu2PortText
            // 
            this.mcdu2PortText.Location = new System.Drawing.Point(112, 43);
            this.mcdu2PortText.Name = "mcdu2PortText";
            this.mcdu2PortText.Size = new System.Drawing.Size(57, 20);
            this.mcdu2PortText.TabIndex = 6;
            // 
            // mcdu2PortLabel
            // 
            this.mcdu2PortLabel.AutoSize = true;
            this.mcdu2PortLabel.Location = new System.Drawing.Point(80, 46);
            this.mcdu2PortLabel.Name = "mcdu2PortLabel";
            this.mcdu2PortLabel.Size = new System.Drawing.Size(29, 13);
            this.mcdu2PortLabel.TabIndex = 5;
            this.mcdu2PortLabel.Text = "Port:";
            // 
            // mcdu2Check
            // 
            this.mcdu2Check.AutoSize = true;
            this.mcdu2Check.Location = new System.Drawing.Point(6, 45);
            this.mcdu2Check.Name = "mcdu2Check";
            this.mcdu2Check.Size = new System.Drawing.Size(65, 17);
            this.mcdu2Check.TabIndex = 3;
            this.mcdu2Check.Text = "Enabled";
            this.mcdu2Check.UseVisualStyleBackColor = true;
            // 
            // mcdu2IpLabel
            // 
            this.mcdu2IpLabel.AutoSize = true;
            this.mcdu2IpLabel.Location = new System.Drawing.Point(6, 22);
            this.mcdu2IpLabel.Name = "mcdu2IpLabel";
            this.mcdu2IpLabel.Size = new System.Drawing.Size(20, 13);
            this.mcdu2IpLabel.TabIndex = 3;
            this.mcdu2IpLabel.Text = "IP:";
            // 
            // mcdu2IpText
            // 
            this.mcdu2IpText.Location = new System.Drawing.Point(32, 19);
            this.mcdu2IpText.Name = "mcdu2IpText";
            this.mcdu2IpText.Size = new System.Drawing.Size(137, 20);
            this.mcdu2IpText.TabIndex = 2;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(298, 89);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // mcdu1PortText
            // 
            this.mcdu1PortText.Location = new System.Drawing.Point(124, 55);
            this.mcdu1PortText.Name = "mcdu1PortText";
            this.mcdu1PortText.Size = new System.Drawing.Size(57, 20);
            this.mcdu1PortText.TabIndex = 4;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 94);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(109, 13);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Status: Disconnected";
            // 
            // autoStartCheck
            // 
            this.autoStartCheck.AutoSize = true;
            this.autoStartCheck.Location = new System.Drawing.Point(139, 93);
            this.autoStartCheck.Name = "autoStartCheck";
            this.autoStartCheck.Size = new System.Drawing.Size(115, 17);
            this.autoStartCheck.TabIndex = 4;
            this.autoStartCheck.Text = "Auto-Start on open";
            this.autoStartCheck.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(251, 89);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(44, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 124);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.autoStartCheck);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.mcdu1PortText);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.mcdu2GroupBox);
            this.Controls.Add(this.mcdu1GroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "NVAN Flightdeck Solutions MCDU Flight Factor A320 Connector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.mcdu1GroupBox.ResumeLayout(false);
            this.mcdu1GroupBox.PerformLayout();
            this.mcdu2GroupBox.ResumeLayout(false);
            this.mcdu2GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox mcdu1GroupBox;
        private System.Windows.Forms.Label mcdu1PortLabel;
        private System.Windows.Forms.CheckBox mcdu1Check;
        private System.Windows.Forms.Label mcdu1IpLabel;
        private System.Windows.Forms.TextBox mcdu1IpText;
        private System.Windows.Forms.GroupBox mcdu2GroupBox;
        private System.Windows.Forms.TextBox mcdu2PortText;
        private System.Windows.Forms.Label mcdu2PortLabel;
        private System.Windows.Forms.CheckBox mcdu2Check;
        private System.Windows.Forms.Label mcdu2IpLabel;
        private System.Windows.Forms.TextBox mcdu2IpText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox mcdu1PortText;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox autoStartCheck;
        private System.Windows.Forms.Button saveButton;
    }
}

