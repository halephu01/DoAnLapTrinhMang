namespace Client
{
    partial class Client
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTuTiengAnh = new System.Windows.Forms.TextBox();
            this.btDich = new System.Windows.Forms.Button();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIPClient = new System.Windows.Forms.TextBox();
            this.tbPortClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btKetNoi = new System.Windows.Forms.Button();
            this.tbIPServer = new System.Windows.Forms.TextBox();
            this.tbPortServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbTuTiengAnh);
            this.groupBox2.Controls.Add(this.btDich);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(665, 304);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(364, 165);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Translate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = " Nhập từ: ";
            // 
            // tbTuTiengAnh
            // 
            this.tbTuTiengAnh.Location = new System.Drawing.Point(128, 46);
            this.tbTuTiengAnh.Margin = new System.Windows.Forms.Padding(4);
            this.tbTuTiengAnh.Name = "tbTuTiengAnh";
            this.tbTuTiengAnh.Size = new System.Drawing.Size(180, 28);
            this.tbTuTiengAnh.TabIndex = 1;
            // 
            // btDich
            // 
            this.btDich.BackColor = System.Drawing.Color.Turquoise;
            this.btDich.Location = new System.Drawing.Point(128, 96);
            this.btDich.Margin = new System.Windows.Forms.Padding(4);
            this.btDich.Name = "btDich";
            this.btDich.Size = new System.Drawing.Size(109, 42);
            this.btDich.TabIndex = 0;
            this.btDich.Text = "Dịch";
            this.btDich.UseVisualStyleBackColor = false;
            this.btDich.Click += new System.EventHandler(this.btDich_Click);
            // 
            // rtbMessage
            // 
            this.rtbMessage.Enabled = false;
            this.rtbMessage.Location = new System.Drawing.Point(35, 37);
            this.rtbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(601, 431);
            this.rtbMessage.TabIndex = 15;
            this.rtbMessage.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbIPClient);
            this.groupBox1.Controls.Add(this.tbPortClient);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btKetNoi);
            this.groupBox1.Controls.Add(this.tbIPServer);
            this.groupBox1.Controls.Add(this.tbPortServer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(669, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(360, 246);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kết nối";
            // 
            // tbIPClient
            // 
            this.tbIPClient.Location = new System.Drawing.Point(181, 119);
            this.tbIPClient.Margin = new System.Windows.Forms.Padding(4);
            this.tbIPClient.Name = "tbIPClient";
            this.tbIPClient.Size = new System.Drawing.Size(157, 28);
            this.tbIPClient.TabIndex = 10;
            this.tbIPClient.Text = "127.0.0.1";
            // 
            // tbPortClient
            // 
            this.tbPortClient.Location = new System.Drawing.Point(181, 164);
            this.tbPortClient.Margin = new System.Windows.Forms.Padding(4);
            this.tbPortClient.Name = "tbPortClient";
            this.tbPortClient.Size = new System.Drawing.Size(157, 28);
            this.tbPortClient.TabIndex = 9;
            this.tbPortClient.Text = "8081";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port client:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "IP client: ";
            // 
            // btKetNoi
            // 
            this.btKetNoi.BackColor = System.Drawing.Color.Turquoise;
            this.btKetNoi.Location = new System.Drawing.Point(124, 196);
            this.btKetNoi.Margin = new System.Windows.Forms.Padding(4);
            this.btKetNoi.Name = "btKetNoi";
            this.btKetNoi.Size = new System.Drawing.Size(115, 42);
            this.btKetNoi.TabIndex = 6;
            this.btKetNoi.Text = "Kết nối";
            this.btKetNoi.UseVisualStyleBackColor = false;
            this.btKetNoi.Click += new System.EventHandler(this.btKetNoi_Click);
            // 
            // tbIPServer
            // 
            this.tbIPServer.Location = new System.Drawing.Point(181, 34);
            this.tbIPServer.Margin = new System.Windows.Forms.Padding(4);
            this.tbIPServer.Name = "tbIPServer";
            this.tbIPServer.Size = new System.Drawing.Size(157, 28);
            this.tbIPServer.TabIndex = 5;
            this.tbIPServer.Text = "127.0.0.1";
            // 
            // tbPortServer
            // 
            this.tbPortServer.Location = new System.Drawing.Point(181, 79);
            this.tbPortServer.Margin = new System.Windows.Forms.Padding(4);
            this.tbPortServer.Name = "tbPortServer";
            this.tbPortServer.Size = new System.Drawing.Size(157, 28);
            this.tbPortServer.TabIndex = 4;
            this.tbPortServer.Text = "8001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP server: ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Khaki;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1070, 542);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Client";
            this.Text = "Client";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTuTiengAnh;
        private System.Windows.Forms.Button btDich;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIPClient;
        private System.Windows.Forms.TextBox tbPortClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btKetNoi;
        private System.Windows.Forms.TextBox tbIPServer;
        private System.Windows.Forms.TextBox tbPortServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

