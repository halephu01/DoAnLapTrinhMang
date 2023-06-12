namespace UDP_Client
{
    partial class UDP_Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btKetNoi = new System.Windows.Forms.Button();
            this.tbIPMayChu = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTuTiengAnh = new System.Windows.Forms.TextBox();
            this.btDich = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btGui = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btKetNoi);
            this.groupBox1.Controls.Add(this.tbIPMayChu);
            this.groupBox1.Controls.Add(this.tbPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(651, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(360, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kết nối";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 119);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "127.0.0.1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 164);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "8080";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port client:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "IP client: ";
            // 
            // btKetNoi
            // 
            this.btKetNoi.Location = new System.Drawing.Point(124, 196);
            this.btKetNoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btKetNoi.Name = "btKetNoi";
            this.btKetNoi.Size = new System.Drawing.Size(100, 28);
            this.btKetNoi.TabIndex = 6;
            this.btKetNoi.Text = "Kết nối";
            this.btKetNoi.UseVisualStyleBackColor = true;
            this.btKetNoi.Click += new System.EventHandler(this.btKetNoi_Click);
            // 
            // tbIPMayChu
            // 
            this.tbIPMayChu.Location = new System.Drawing.Point(181, 34);
            this.tbIPMayChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIPMayChu.Name = "tbIPMayChu";
            this.tbIPMayChu.Size = new System.Drawing.Size(157, 22);
            this.tbIPMayChu.TabIndex = 5;
            this.tbIPMayChu.Text = "127.0.0.1";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(181, 79);
            this.tbPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(157, 22);
            this.tbPort.TabIndex = 4;
            this.tbPort.Text = "8000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP server: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rtbMessage
            // 
            this.rtbMessage.Enabled = false;
            this.rtbMessage.Location = new System.Drawing.Point(13, 110);
            this.rtbMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(592, 312);
            this.rtbMessage.TabIndex = 8;
            this.rtbMessage.Text = "";
            // 
            // tbMessage
            // 
            this.tbMessage.Enabled = false;
            this.tbMessage.Location = new System.Drawing.Point(13, 495);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(499, 22);
            this.tbMessage.TabIndex = 9;
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbTuTiengAnh);
            this.groupBox2.Controls.Add(this.btDich);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(647, 298);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(364, 165);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Translate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = " Nhập từ: ";
            // 
            // tbTuTiengAnh
            // 
            this.tbTuTiengAnh.Location = new System.Drawing.Point(128, 46);
            this.tbTuTiengAnh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTuTiengAnh.Name = "tbTuTiengAnh";
            this.tbTuTiengAnh.Size = new System.Drawing.Size(180, 22);
            this.tbTuTiengAnh.TabIndex = 1;
            // 
            // btDich
            // 
            this.btDich.Location = new System.Drawing.Point(128, 96);
            this.btDich.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDich.Name = "btDich";
            this.btDich.Size = new System.Drawing.Size(100, 28);
            this.btDich.TabIndex = 0;
            this.btDich.Text = "Dịch";
            this.btDich.UseVisualStyleBackColor = true;
            this.btDich.Click += new System.EventHandler(this.btDich_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.rtbMessage);
            this.panel1.Controls.Add(this.btGui);
            this.panel1.Controls.Add(this.tbMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 570);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btGui
            // 
            this.btGui.Enabled = false;
            this.btGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGui.Image = global::UDP_Client.Properties.Resources.paper_plane;
            this.btGui.Location = new System.Drawing.Point(536, 472);
            this.btGui.Margin = new System.Windows.Forms.Padding(4);
            this.btGui.Name = "btGui";
            this.btGui.Size = new System.Drawing.Size(69, 62);
            this.btGui.TabIndex = 7;
            this.btGui.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGui.UseVisualStyleBackColor = true;
            this.btGui.Click += new System.EventHandler(this.btGui_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 90);
            this.panel2.TabIndex = 12;
            // 
            // UDP_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UDP_Client";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btKetNoi;
        private System.Windows.Forms.TextBox tbIPMayChu;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button btGui;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTuTiengAnh;
        private System.Windows.Forms.Button btDich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

