using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuDoAn
{
    public partial class DoAn : Form
    {
        public DoAn()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BaiTongHop baiTH= new BaiTongHop();
            baiTH.ShowDialog();
        }

        private void btBai1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.ShowDialog();
        }

        private void btBai2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.ShowDialog();
        }

        private void btBai4_Click(object sender, EventArgs e)
        {
            Bai4 bai4 = new Bai4(); 
            bai4.ShowDialog();
        }

        private void btBai7_Click(object sender, EventArgs e)
        {
            Bai7 bai7 = new Bai7();
            bai7.ShowDialog();
        }
    }
}
