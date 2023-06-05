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
    public partial class Bai4 : Form
    {
        private UdpClient server;

        public Bai4()
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

                rtbMessage.Text += "Client: " + received_data + "\n";

                if (received_data.ToUpper() == "SHUTDOWN")
                {
                    SendData("Server đã tắt.");
                    System.Diagnostics.Process.Start("shutdown", "/s /t 0");
                }

                else if (received_data.ToUpper() == "RESTART")
                {
                    // Tạo một quy trình mới
                    Process process = new Process();

                    // Thiết lập các thuộc tính cho quy trình
                    process.StartInfo.FileName = "shutdown";
                    process.StartInfo.Arguments = "/r /t 0"; // Thực hiện restart ngay lập tức
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.UseShellExecute = false;

                    try
                    {
                        // Khởi chạy quy trình để restart máy tính
                        SendData("Server đã khởi động lại.");
                        process.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi restart máy tính: " + ex.Message, "Lỗi");
                    }
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

    }
}
