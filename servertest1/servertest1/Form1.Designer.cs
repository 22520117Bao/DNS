namespace servertest1
{
    partial class Form1
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
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.lbServer = new System.Windows.Forms.Label();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtServerLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(140, 65);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(109, 20);
            this.txtServerIP.TabIndex = 0;
            this.txtServerIP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Location = new System.Drawing.Point(59, 65);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(38, 13);
            this.lbServer.TabIndex = 1;
            this.lbServer.Text = "Server";
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(62, 119);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(75, 23);
            this.btnStartServer.TabIndex = 2;
            this.btnStartServer.Text = "Login";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.button1_Click);
            // 
            // top
            // 
            this.top.AutoSize = true;
            this.top.Location = new System.Drawing.Point(381, 71);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(26, 13);
            this.top.TabIndex = 3;
            this.top.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(501, 64);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 4;
            // 
            // txtServerLog
            // 
            this.txtServerLog.Location = new System.Drawing.Point(334, 121);
            this.txtServerLog.Name = "txtServerLog";
            this.txtServerLog.Size = new System.Drawing.Size(221, 20);
            this.txtServerLog.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtServerLog);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.top);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.txtServerIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Label top;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtServerLog;
    }
}

