using nvan.FdsFfA320McduConnector.Config;
using System.Net.Sockets;
using System.Threading;
using System;
using System.Text;
using XPlaneConnector;
using System.Collections.Generic;

namespace nvan.FdsFfA320McduConnector
{
    public class McduManager
    {
        private DataRefManager dataRefManager;
        private ConfigManager configManager;

        private XPlaneConnector.XPlaneConnector xPlaneConnector;
        private TcpClient mcdu1Client, mcdu2Client;

        private Thread mcdu1Thread, mcdu2Thread;

        public McduManager(DataRefManager dataRefManager, ref ConfigManager configManager)
        {
            this.dataRefManager = dataRefManager;
            this.configManager = configManager;
        }

        public bool Start()
        {
            try
            {
                xPlaneConnector = new XPlaneConnector.XPlaneConnector(
                    "127.0.0.1",
                    49000
                );
                xPlaneConnector.Start();
            }
            catch
            {
                return false;
            }

            try
            {
                if (configManager.GetConfig().mcdu1Enabled)
                {
                    mcdu1Client = new TcpClient();
                    mcdu1Client.Connect(
                        configManager.GetConfig().mcdu1Ip,
                        configManager.GetConfig().mcdu1Port
                    );

                    mcdu1Thread = new Thread(new McduConnector(
                        ref xPlaneConnector,
                        ref mcdu1Client,
                        ref dataRefManager,
                        1
                    ).StartThread);

                    mcdu1Thread.Start();
                }

                if (configManager.GetConfig().mcdu2Enabled)
                {
                    mcdu2Client = new TcpClient();
                    mcdu2Client.Connect(
                        configManager.GetConfig().mcdu2Ip,
                        configManager.GetConfig().mcdu2Port
                    );

                    mcdu2Thread = new Thread(new McduConnector(
                        ref xPlaneConnector,
                        ref mcdu2Client,
                        ref dataRefManager,
                        2
                    ).StartThread);

                    mcdu2Thread.Start();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void Stop() {
            if (configManager.GetConfig().mcdu1Enabled)
            {
                mcdu1Thread.Abort();
                mcdu1Client.Close();
            }
            if (configManager.GetConfig().mcdu2Enabled)
            {
                mcdu2Thread.Abort();
                mcdu2Client.Close();
            }

            try
            {
                xPlaneConnector.Stop();
            }
            catch {}
        }
    }

    public class McduConnector {
        private XPlaneConnector.XPlaneConnector xPlaneConnector;
        private TcpClient mcduClient;
        private DataRefManager dataRefManager;
        private int mcduNumber;

        public McduConnector(
            ref XPlaneConnector.XPlaneConnector xPlaneConnector,
            ref TcpClient mcduClient,
            ref DataRefManager dataRefManager,
            int mcduNumber
        )
        {
            this.xPlaneConnector = xPlaneConnector;
            this.mcduClient = mcduClient;
            this.dataRefManager = dataRefManager;
            this.mcduNumber = mcduNumber;
        }

        public void StartThread()
        {
            Byte[] bytes, sendBytes;
            NetworkStream stream = mcduClient.GetStream();

            var ledsState = new Dictionary<int, bool>();
            bool firstIteration = false;

            while (true)
            {
                try
                {
                    if (mcduClient.ReceiveBufferSize > 0)
                    {
                        bytes = new byte[mcduClient.ReceiveBufferSize];
                        stream.Read(bytes, 0, mcduClient.ReceiveBufferSize);
                        string msg = Encoding.ASCII.GetString(bytes);

                        foreach (
                            string op
                            in msg.Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                        )
                        {
                            if (op.Contains("SW:") && op.Contains(":ON"))
                            {
                                int code = int.Parse(op.Split(':')[1]);
                                xPlaneConnector.SendCommand(
                                    dataRefManager.getXPlaneCommands(mcduNumber)[code]
                                );
                            }
                        }

                    }

                    // Done on purpose to sync LEDs at startup
                    // TODO Clean this code
                    if(!firstIteration)
                    {
                        foreach (KeyValuePair<int, DataRefElement> dataRef in dataRefManager.getLedXPlaneDataRefs(mcduNumber))
                        {
                            ledsState.Add(dataRef.Key, false);

                            xPlaneConnector.Subscribe(dataRef.Value, 5, (dr, value) =>
                            {
                                var state = value != 0;

                                if (ledsState[dataRef.Key] != state)
                                {
                                    sendBytes = Encoding.ASCII.GetBytes("B1:LED:" + dataRef.Key + ":" + (state ? "ON" : "OFF") + Environment.NewLine);
                                    stream.Write(sendBytes, 0, sendBytes.Length);
                                }


                                ledsState[dataRef.Key] = state;
                            });
                        }

                        firstIteration = true;
                    }
                }
                catch { }
            }
        }
    }
}
