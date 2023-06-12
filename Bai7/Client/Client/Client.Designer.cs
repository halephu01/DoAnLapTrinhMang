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
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.btGui = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMessage
            // 
            this.tbMessage.Enabled = false;
            this.tbMessage.Location = new System.Drawing.Point(36, 336);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(513, 22);
            this.tbMessage.TabIndex = 26;
            // 
            // rtbMessage
            // 
            this.rtbMessage.Enabled = false;
            this.rtbMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessage.Location = new System.Drawing.Point(36, 37);
            this.rtbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(601, 265);
            this.rtbMessage.TabIndex = 25;
            this.rtbMessage.Text = "";
            // 
            // btGui
            // 
            this.btGui.BackColor = System.Drawing.Color.Turquoise;
            this.btGui.Enabled = false;
            this.btGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGui.Image = global::Client.Properties.Resources.paper_plane;
            this.btGui.Location = new System.Drawing.Point(557, 318);
            this.btGui.Margin = new System.Windows.Forms.Padding(4);
            this.btGui.Name = "btGui";
            this.btGui.Size = new System.Drawing.Size(80, 52);
            this.btGui.TabIndex = 24;
            this.btGui.UseVisualStyleBackColor = false;
            this.btGui.Click += new System.EventHandler(this.btGui_Click);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(671, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(360, 265);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kết nối";
            // 
            // tbIPClient
            // 
            this.tbIPClient.Location = new System.Drawing.Point(181, 119);
            this.tbIPClient.Margin = new System.Windows.Forms.Padding(4);
            this.tbIPClient.Name = "tbIPClient";
            this.tbIPClient.Size = new System.Drawing.Size(157, 30);
            this.tbIPClient.TabIndex = 10;
            this.tbIPClient.Text = "127.0.0.1";
            // 
            // tbPortClient
            // 
            this.tbPortClient.Location = new System.Drawing.Point(181, 164);
            this.tbPortClient.Margin = new System.Windows.Forms.Padding(4);
            this.tbPortClient.Name = "tbPortClient";
            this.tbPortClient.Size = new System.Drawing.Size(157, 30);
            this.tbPortClient.TabIndex = 9;
            this.tbPortClient.Text = "8083";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port client:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "IP client: ";
            // 
            // btKetNoi
            // 
            this.btKetNoi.BackColor = System.Drawing.Color.Turquoise;
            this.btKetNoi.Location = new System.Drawing.Point(132, 202);
            this.btKetNoi.Margin = new System.Windows.Forms.Padding(4);
            this.btKetNoi.Name = "btKetNoi";
            this.btKetNoi.Size = new System.Drawing.Size(100, 47);
            this.btKetNoi.TabIndex = 6;
            this.btKetNoi.Text = "Kết nối";
            this.btKetNoi.UseVisualStyleBackColor = false;
            this.btKetNoi.Click += new System.EventHandler(this.btKetNoi_Click);
            // 
            // tbIPServer
            // 
            this.tbIPServer.Location = new System.Drawing.Point(181, 39);
            this.tbIPServer.Margin = new System.Windows.Forms.Padding(4);
            this.tbIPServer.Name = "tbIPServer";
            this.tbIPServer.Size = new System.Drawing.Size(157, 30);
            this.tbIPServer.TabIndex = 5;
            this.tbIPServer.Text = "127.0.0.1";
            // 
            // tbPortServer
            // 
            this.tbPortServer.Location = new System.Drawing.Point(181, 79);
            this.tbPortServer.Margin = new System.Windows.Forms.Padding(4);
            this.tbPortServer.Name = "tbPortServer";
            this.tbPortServer.Size = new System.Drawing.Size(157, 30);
            this.tbPortServer.TabIndex = 4;
            this.tbPortServer.Text = "8003";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP server: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 463);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 27;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Khaki;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1066, 542);
            this.flowLayoutPanel1.TabIndex = 28;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.btGui);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Client";
            this.Text = "Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button btGui;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

