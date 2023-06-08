using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Bai1 : Form
    {
        private UdpClient client;
        Socket socket;
        IPEndPoint endpoint;

        public Bai1()
        {
            InitializeComponent();
            client = new UdpClient(Int32.Parse(tbPortClient.Text));
            Task.Run(() => ReceiveData());
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btKetNoi_Click(object sender, EventArgs e)
        {
            if (tbMessage.Text != "")
            {
                SendData(tbMessage.Text);
                tbMessage.Text = String.Empty;
            }
        }
        void SendData(string sendData)
        {
            byte[] data = Encoding.UTF8.GetBytes(sendData);
            socket.SendTo(data, endpoint);

            string keyWordDich = "DICH#";

            if (sendData.StartsWith(keyWordDich))
                rtbMessage.Text += "Client: " + sendData.Substring(keyWordDich.Length) + "\n";
            else
                rtbMessage.Text += "Client: " + sendData + "\n";
        }

        void ReceiveData()
        {
            while (true)
            {
                IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] receivedData = client.Receive(ref serverEndPoint);
                string receivedMessage = Encoding.UTF8.GetString(receivedData);
                rtbMessage.Text += "Server: " + receivedMessage + "\n";
            }
        }

        private void btGui_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(tbIPServer.Text, out ip))
                MessageBox.Show("Hãy nhập một IP chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (Int32.Parse(tbPortServer.Text) < 1024 || Int32.Parse(tbPortServer.Text) > 65535)
                    MessageBox.Show("Hãy chọn một Port trong khoảng (1024-65535)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string IP = tbIPServer.Text;
                    int Port = Int32.Parse(tbPortServer.Text);
                    endpoint = new IPEndPoint(IPAddress.Parse(IP), Port);

                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    rtbMessage.Enabled = true;
                    tbMessage.Enabled = true;
                    btGui.Enabled = true;
                }
            }
        }
    }
}
