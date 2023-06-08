using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

                if (File.Exists(received_data))
                {
                    string content = File.ReadAllText(received_data);

                    SendData(content);
                }
            }
        }

        void SendData(string sendData)
        {
            byte[] data = Encoding.UTF8.GetBytes(sendData);
            server.Send(data, data.Length, new IPEndPoint(IPAddress.Parse(tbIPClient.Text), Int32.Parse(tbPortClient.Text)));
        }

        private void Server_Load(object sender, EventArgs e)
        {

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
