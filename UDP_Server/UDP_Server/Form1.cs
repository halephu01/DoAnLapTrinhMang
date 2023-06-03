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
        EndPoint endpoint = new IPEndPoint(IPAddress.Any, 0);

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btTao_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(tbIP.Text, out ip))
                MessageBox.Show("Hãy nhập một IP chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (Int32.Parse(tbPort.Text) < 1024 || Int32.Parse(tbPort.Text) > 65535)
                    MessageBox.Show("Hãy chọn một Port trong khoảng (1024-65535)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    IPEndPoint IPendpoint = new IPEndPoint(IPAddress.Parse(tbIP.Text), Int32.Parse(tbPort.Text));
                    socket.Bind(IPendpoint);
                    Thread listen = new Thread(Receive);
                    listen.IsBackground = true;
                    listen.Start();
                    MessageBox.Show("Tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void Receive()
        {
            while (true)
            {
                int received_length = socket.ReceiveFrom(buffer, 0, 1024, SocketFlags.None, ref endpoint);
                string received_data = Encoding.UTF8.GetString(buffer, 0, received_length);

                rtbMessage.Text += "Client: " + received_data + "\n";

                string keyWordOpenFile = "OPEN#";
                string keyWordDich = "DICH#";

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
                    string wordTranslate = "";

                    if (word == "Computer")
                        wordTranslate = "Máy tính";
                    else if (word == "RAM")
                        wordTranslate = "Bộ nhớ truy cập tạm thời";
                    else if (word == "HDD")
                        wordTranslate = "Ổ đĩa cứng";
                    else
                        wordTranslate = "Not found";


                }
                                                                                    
            }
        }
    }
}
