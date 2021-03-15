using nvan.FdsFfA320McduConnector.Config;
using System;
using System.Windows.Forms;

namespace nvan.FdsFfA320McduConnector
{
    static class Program
    {
        private const string file = "config.json";

        [STAThread]
        static void Main()
        {
            var configManager = new ConfigManager(
                new JsonReader<Config.Config>(file),
                new JsonWriter<Config.Config>(file)
            );

            var mcduManager = new McduManager(
                new DataRefManager(),
                ref configManager
            );

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(ref configManager, ref mcduManager));
        }
    }
}
