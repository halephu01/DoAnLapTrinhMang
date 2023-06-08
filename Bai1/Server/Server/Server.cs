using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        private UdpClient server;

        public Server()
        {
            InitializeComponent();
            server = new UdpClient(Int32.Parse(tbPortServer.Text));
            Task.Run(() => Receive());
            CheckForIllegalCrossThreadCalls = false;
        }

        void Receive()
        {
            while (true)
            {
                IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] receivedData = server.Receive(ref clientEndPoint);
                string received_data = Encoding.UTF8.GetString(receivedData);

                string keyWordOpenFile = "OPEN#";

                rtbMessage.Text += "Client: " + received_data + "\n";

                if (received_data.StartsWith(keyWordOpenFile))
                {
                    string filePath = received_data.Substring(keyWordOpenFile.Length);
                    tbPath.Text = filePath;
                    try
                    {
                        Process.Start(filePath);
                        SendData("Tệp tin đã được mở trên Server.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi mở file: " + ex.Message, "Lỗi");
                    }
                }
                else if (received_data.ToUpper() == "SHUTDOWN")
                {
                    SendData("Server đã tắt.");
                    System.Diagnostics.Process.Start("shutdown", "/s /t 0");
                }
            }
        }

        void SendData(string sendData)
        {
            byte[] data = Encoding.UTF8.GetBytes(sendData);
            server.Send(data, data.Length, new IPEndPoint(IPAddress.Parse(tbIPClient.Text), Int32.Parse(tbPortClient.Text)));
        }

        private void btTao_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(tbIPServer.Text, out ip))
                MessageBox.Show("Hãy nhập một IP chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (Int32.Parse(tbPortClient.Text) < 1024 || Int32.Parse(tbPortClient.Text) > 65535)
                    MessageBox.Show("Hãy chọn một Port trong khoảng (1024-65535)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox2.Enabled = true;
                    tbPath.Enabled = true;
                }
            }
        }
    }
}
