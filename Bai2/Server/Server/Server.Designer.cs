namespace Server
{
    partial class Server
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
            this.tbPortServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIPClient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPortClient = new System.Windows.Forms.TextBox();
            this.tbIPServer = new System.Windows.Forms.TextBox();
            this.btTao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPortServer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbIPClient);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbPortClient);
            this.groupBox1.Controls.Add(this.tbIPServer);
            this.groupBox1.Controls.Add(this.btTao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(395, 288);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo thông tin cho máy chủ";
            // 
            // tbPortServer
            // 
            this.tbPortServer.Location = new System.Drawing.Point(173, 78);
            this.tbPortServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPortServer.Name = "tbPortServer";
            this.tbPortServer.Size = new System.Drawing.Size(132, 28);
            this.tbPortServer.TabIndex = 16;
            this.tbPortServer.Text = "8001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Port server: ";
            // 
            // tbIPClient
            // 
            this.tbIPClient.Location = new System.Drawing.Point(173, 124);
            this.tbIPClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIPClient.Name = "tbIPClient";
            this.tbIPClient.Size = new System.Drawing.Size(132, 28);
            this.tbIPClient.TabIndex = 14;
            this.tbIPClient.Text = "127.0.0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "IP client: ";
            // 
            // tbPortClient
            // 
            this.tbPortClient.Location = new System.Drawing.Point(173, 179);
            this.tbPortClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPortClient.Name = "tbPortClient";
            this.tbPortClient.Size = new System.Drawing.Size(132, 28);
            this.tbPortClient.TabIndex = 4;
            this.tbPortClient.Text = "8081";
            // 
            // tbIPServer
            // 
            this.tbIPServer.Location = new System.Drawing.Point(173, 37);
            this.tbIPServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIPServer.Name = "tbIPServer";
            this.tbIPServer.Size = new System.Drawing.Size(132, 28);
            this.tbIPServer.TabIndex = 3;
            this.tbIPServer.Text = "127.0.0.1";
            // 
            // btTao
            // 
            this.btTao.BackColor = System.Drawing.Color.Turquoise;
            this.btTao.Location = new System.Drawing.Point(173, 228);
            this.btTao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTao.Name = "btTao";
            this.btTao.Size = new System.Drawing.Size(100, 41);
            this.btTao.TabIndex = 2;
            this.btTao.Text = "Tạo";
            this.btTao.UseVisualStyleBackColor = false;
            this.btTao.Click += new System.EventHandler(this.btTao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port client: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP server: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbMessage);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(464, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(552, 402);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nội dung từ client";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(21, 23);
            this.rtbMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(503, 360);
            this.rtbMessage.TabIndex = 1;
            this.rtbMessage.Text = "";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Server";
            this.Text = "Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPortServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIPClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPortClient;
        private System.Windows.Forms.TextBox tbIPServer;
        private System.Windows.Forms.Button btTao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbMessage;
    }
}

