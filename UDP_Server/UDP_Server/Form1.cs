using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;


namespace UDP_Server
{
    public partial class Form1 : Form
    {
        private UdpClient server;
        Socket socket;
        byte[] buffer = new byte[1024];
        

        public Form1()
        {
            InitializeComponent();
            server =  new UdpClient(8000);
            Task.Run(() => Receive());
            CheckForIllegalCrossThreadCalls = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
                }
            }
        }

        void Receive()
        {
            while (true)
            {
                IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] receivedData = server.Receive(ref clientEndPoint);
                string received_data = Encoding.ASCII.GetString(receivedData);
              
                string keyWordOpenFile = "OPEN#";

                string keyWordDich = "DICH#";

                if (received_data.StartsWith(keyWordDich))
                    rtbMessage.Text += "Client: " + received_data.Substring(keyWordDich.Length) + "\n";
                else
                    rtbMessage.Text += "Client: " + received_data + "\n";

                if (received_data.StartsWith(keyWordOpenFile))
                {
                    string filePath=received_data.Substring(keyWordOpenFile.Length);
                    tbPath.Text = filePath;
                    try
                    {
                        Process.Start(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi mở file: " + ex.Message, "Lỗi");
                    }
                }

                else if (received_data == "SHUTDOWN")
                {
                    System.Diagnostics.Process.Start("shutdown", "/s /t 0");
                }

                else if (received_data == "RESTART")
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
                        process.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi restart máy tính: " + ex.Message, "Lỗi");
                    }
                }

                else if (received_data.StartsWith(keyWordDich))
                {
                    string word = received_data.Substring(keyWordDich.Length);
                    string wordTranslate;

                    if (word == "Computer")
                        wordTranslate = "Máy tính";
                    else if (word == "RAM")
                        wordTranslate = "Bộ nhớ truy cập tạm thời";
                    else if (word == "HDD")
                        wordTranslate = "Ổ đĩa cứng";
                    else
                        wordTranslate = "Not found";

                    byte[] data = Encoding.UTF8.GetBytes(wordTranslate);
                    IPAddress clientIP = IPAddress.Parse(tbIPClient.Text);
                    server.Send(data,data.Length,new IPEndPoint(clientIP,Int32.Parse(tbPortClient.Text)));
                }     
                
                else if (File.Exists(received_data))
                {
                    string content = File.ReadAllText(received_data);

                    byte[] data = Encoding.UTF8.GetBytes(content);
                    server.Send(data, data.Length, new IPEndPoint(IPAddress.Parse(tbIPClient.Text), Int32.Parse(tbPortClient.Text)));
                }
            }
        }
    }
}
