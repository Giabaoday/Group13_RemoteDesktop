namespace Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            ip = new TextBox();
            port = new TextBox();
            connect = new Button();
            share = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 43);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 0;
            label1.Text = "IP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 106);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 0;
            label2.Text = "Port:";
            // 
            // ip
            // 
            ip.Location = new Point(121, 43);
            ip.Name = "ip";
            ip.Size = new Size(170, 27);
            ip.TabIndex = 1;
            ip.Text = "127.0.0.1";
            // 
            // port
            // 
            port.Location = new Point(121, 108);
            port.Name = "port";
            port.Size = new Size(170, 27);
            port.TabIndex = 2;
            port.Text = "55";
            // 
            // connect
            // 
            connect.Location = new Point(37, 185);
            connect.Name = "connect";
            connect.Size = new Size(94, 29);
            connect.TabIndex = 3;
            connect.Text = "Connect";
            connect.UseVisualStyleBackColor = true;
            connect.Click += connect_Click;
            // 
            // share
            // 
            share.Location = new Point(157, 185);
            share.Name = "share";
            share.Size = new Size(134, 29);
            share.TabIndex = 4;
            share.Text = "Share desktop";
            share.UseVisualStyleBackColor = true;
            share.Click += share_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 247);
            Controls.Add(share);
            Controls.Add(connect);
            Controls.Add(port);
            Controls.Add(ip);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox ip;
        private TextBox port;
        private Button connect;
        private Button share;
        private System.Windows.Forms.Timer timer1;
    }
}
