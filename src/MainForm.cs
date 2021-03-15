using nvan.FdsFfA320McduConnector.Config;
using System;
using System.Windows.Forms;
using System.Linq;

namespace nvan.FdsFfA320McduConnector
{
    public partial class MainForm : Form
    {
        private ConfigManager configManager;
        private McduManager mcduManager;

        public MainForm(ref ConfigManager configManager, ref McduManager mcduManager)
        {
            InitializeComponent();

            this.configManager = configManager;
            this.mcduManager = mcduManager;

            autoStartCheck.Checked = this.configManager.GetConfig().autoStartEnabled;
            mcdu1Check.Checked = this.configManager.GetConfig().mcdu1Enabled;
            mcdu2Check.Checked = this.configManager.GetConfig().mcdu2Enabled;

            mcdu1IpText.Text = this.configManager.GetConfig().mcdu1Ip;
            mcdu1PortText.Text = this.configManager.GetConfig().mcdu1Port.ToString();

            mcdu2IpText.Text = this.configManager.GetConfig().mcdu2Ip;
            mcdu2PortText.Text = this.configManager.GetConfig().mcdu2Port.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var config = new Config.Config {
                autoStartEnabled = autoStartCheck.Checked,
                mcdu1Enabled = mcdu1Check.Checked,
                mcdu2Enabled = mcdu2Check.Checked,

                mcdu1Ip = mcdu1IpText.Text,
                mcdu1Port = int.Parse(mcdu1PortText.Text),

                mcdu2Ip = mcdu2IpText.Text,
                mcdu2Port = int.Parse(mcdu2PortText.Text)
            };

            configManager.UpdateConfig(config);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if(autoStartCheck.Checked)
                StartProcedure();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if(startButton.Text == "Stop")
            {
                StopProcedure();
                return;
            }

            StartProcedure();
        }

        private void StopProcedure()
        {
            mcduManager.Stop();
            SetControlsEnabled(true);
            startButton.Text = "Start";
            statusLabel.Text = "Status: Disconnected";
        }

        private void StartProcedure()
        {
            if(mcduManager.Start())
            {
                SetControlsEnabled(false);
                statusLabel.Text = "Status: Connected";
                startButton.Text = "Stop";
                return;
            }

            statusLabel.Text = "Status: Error";
        }

        private string[] avoidDisableControls = {
            "startButton",
            "statusLabel"
        };

        private void SetControlsEnabled(bool state)
        {
            foreach (Control control in Controls)
            {
                if (avoidDisableControls.Contains(control.Name))
                    continue;

                control.Enabled = state;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (startButton.Text == "Stop")
            {
                StopProcedure();
            }
        }
    }
}
