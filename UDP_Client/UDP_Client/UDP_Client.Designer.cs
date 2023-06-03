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
            this.btGui = new System.Windows.Forms.Button();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTuTiengAnh = new System.Windows.Forms.TextBox();
            this.btDich = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(488, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kết nối";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "127.0.0.1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "8080";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port client:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "IP client: ";
            // 
            // btKetNoi
            // 
            this.btKetNoi.Location = new System.Drawing.Point(93, 159);
            this.btKetNoi.Name = "btKetNoi";
            this.btKetNoi.Size = new System.Drawing.Size(75, 23);
            this.btKetNoi.TabIndex = 6;
            this.btKetNoi.Text = "Kết nối";
            this.btKetNoi.UseVisualStyleBackColor = true;
            this.btKetNoi.Click += new System.EventHandler(this.btKetNoi_Click);
            // 
            // tbIPMayChu
            // 
            this.tbIPMayChu.Location = new System.Drawing.Point(136, 28);
            this.tbIPMayChu.Name = "tbIPMayChu";
            this.tbIPMayChu.Size = new System.Drawing.Size(119, 20);
            this.tbIPMayChu.TabIndex = 5;
            this.tbIPMayChu.Text = "127.0.0.1";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(136, 64);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(119, 20);
            this.tbPort.TabIndex = 4;
            this.tbPort.Text = "8000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP server: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btGui
            // 
            this.btGui.Location = new System.Drawing.Point(389, 392);
            this.btGui.Name = "btGui";
            this.btGui.Size = new System.Drawing.Size(75, 23);
            this.btGui.TabIndex = 7;
            this.btGui.Text = "Gửi";
            this.btGui.UseVisualStyleBackColor = true;
            this.btGui.Click += new System.EventHandler(this.btGui_Click);
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(12, 25);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(452, 351);
            this.rtbMessage.TabIndex = 8;
            this.rtbMessage.Text = "";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(12, 395);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(359, 20);
            this.tbMessage.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbTuTiengAnh);
            this.groupBox2.Controls.Add(this.btDich);
            this.groupBox2.Location = new System.Drawing.Point(485, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 134);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Translate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = " Nhập từ: ";
            // 
            // tbTuTiengAnh
            // 
            this.tbTuTiengAnh.Location = new System.Drawing.Point(96, 37);
            this.tbTuTiengAnh.Name = "tbTuTiengAnh";
            this.tbTuTiengAnh.Size = new System.Drawing.Size(136, 20);
            this.tbTuTiengAnh.TabIndex = 1;
            // 
            // btDich
            // 
            this.btDich.Location = new System.Drawing.Point(96, 78);
            this.btDich.Name = "btDich";
            this.btDich.Size = new System.Drawing.Size(75, 23);
            this.btDich.TabIndex = 0;
            this.btDich.Text = "Dịch";
            this.btDich.UseVisualStyleBackColor = true;
            this.btDich.Click += new System.EventHandler(this.btDich_Click);
            // 
            // UDP_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.btGui);
            this.Controls.Add(this.groupBox1);
            this.Name = "UDP_Client";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

