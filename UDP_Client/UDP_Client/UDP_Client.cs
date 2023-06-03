using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace UDP_Client
{
    public partial class UDP_Client : Form
    {
        private UdpClient client;
        Socket socket;
        IPEndPoint endpoint;
        byte[] buffer = new byte[1024];

        public UDP_Client()
        {
            InitializeComponent();
            client = new UdpClient(8080);
            Task.Run(() => ReceiveData());
            CheckForIllegalCrossThreadCalls = false;
        }

        private void ReceiveData()
        {
            while (true)
            {
                IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] receivedData = client.Receive(ref serverEndPoint);
                string receivedMessage = Encoding.UTF8.GetString(receivedData);
                rtbMessage.Text += "Server: " + receivedMessage + "\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btKetNoi_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(tbIPMayChu.Text, out ip))
                MessageBox.Show("Hãy nhập một IP chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (Int32.Parse(tbPort.Text) < 1024 || Int32.Parse(tbPort.Text) > 65535)
                    MessageBox.Show("Hãy chọn một Port trong khoảng (1024-65535)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string IP = tbIPMayChu.Text;
                    int Port = Int32.Parse(tbPort.Text);
                    endpoint = new IPEndPoint(IPAddress.Parse(IP), Port);

                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btGui_Click(object sender, EventArgs e)
        {

            if (tbMessage.Text != "")
            {               
                byte[] data = Encoding.UTF8.GetBytes(tbMessage.Text);
                socket.SendTo(data, endpoint);
                rtbMessage.Text += "Client: "+ tbMessage.Text + "\n";
                
                tbMessage.Text = String.Empty;        
            }
        }

        private void btDich_Click(object sender, EventArgs e)
        {
            if (tbTuTiengAnh.Text != "")
            {
                byte[] data = Encoding.UTF8.GetBytes("DICH#" + tbTuTiengAnh.Text);
                socket.SendTo(data, endpoint);
                rtbMessage.Text += "Client: " + tbTuTiengAnh.Text + "\n";

                tbTuTiengAnh.Text = String.Empty;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
