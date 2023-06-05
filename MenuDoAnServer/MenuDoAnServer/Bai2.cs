using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuDoAnServer
{
    public partial class Bai2 : Form
    {
        private UdpClient server;

        public Bai2()
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

                string keyWordDich = "DICH#";

                if (received_data.StartsWith(keyWordDich))
                    rtbMessage.Text += "Client: " + received_data.Substring(keyWordDich.Length) + "\n";

                if (received_data.StartsWith(keyWordDich))
                {
                    string word = received_data.Substring(keyWordDich.Length).ToUpper();
                    string wordTranslate;

                    if (word == "COMPUTER")
                        wordTranslate = "Máy tính";
                    else if (word == "RAM")
                        wordTranslate = "Bộ nhớ truy cập tạm thời";
                    else if (word == "HDD")
                        wordTranslate = "Ổ đĩa cứng";
                    else
                        wordTranslate = "Not found";

                    SendData(wordTranslate);
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
                }
            }
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }
    }
}
