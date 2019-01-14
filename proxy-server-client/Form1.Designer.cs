namespace proxy_server_client
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
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.tb_proxyCode = new System.Windows.Forms.TextBox();
            this.proxyCode = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.panel_Connect = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_ProxyServer = new System.Windows.Forms.Label();
            this.panel_Configuration = new System.Windows.Forms.Panel();
            this.lbl_Configuration = new System.Windows.Forms.Label();
            this.panel_Connect.SuspendLayout();
            this.panel_Configuration.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_IP
            // 
            this.tb_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IP.Location = new System.Drawing.Point(315, 175);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(265, 29);
            this.tb_IP.TabIndex = 0;
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IP.Location = new System.Drawing.Point(253, 178);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(56, 24);
            this.lbl_IP.TabIndex = 1;
            this.lbl_IP.Text = "Code";
            // 
            // tb_proxyCode
            // 
            this.tb_proxyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_proxyCode.Location = new System.Drawing.Point(315, 210);
            this.tb_proxyCode.Name = "tb_proxyCode";
            this.tb_proxyCode.Size = new System.Drawing.Size(265, 29);
            this.tb_proxyCode.TabIndex = 2;
            // 
            // proxyCode
            // 
            this.proxyCode.AutoSize = true;
            this.proxyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proxyCode.Location = new System.Drawing.Point(217, 213);
            this.proxyCode.Name = "proxyCode";
            this.proxyCode.Size = new System.Drawing.Size(92, 24);
            this.proxyCode.TabIndex = 3;
            this.proxyCode.Text = "Password";
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Connect.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.ForeColor = System.Drawing.Color.White;
            this.btn_Connect.Location = new System.Drawing.Point(628, 17);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(110, 60);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "Open proxy connection";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // panel_Connect
            // 
            this.panel_Connect.Controls.Add(this.lbl_ProxyServer);
            this.panel_Connect.Controls.Add(this.btnLogin);
            this.panel_Connect.Controls.Add(this.tb_IP);
            this.panel_Connect.Controls.Add(this.lbl_IP);
            this.panel_Connect.Controls.Add(this.tb_proxyCode);
            this.panel_Connect.Controls.Add(this.proxyCode);
            this.panel_Connect.Location = new System.Drawing.Point(12, 12);
            this.panel_Connect.Name = "panel_Connect";
            this.panel_Connect.Size = new System.Drawing.Size(870, 396);
            this.panel_Connect.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(382, 275);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(130, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(744, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close proxy connection";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbl_ProxyServer
            // 
            this.lbl_ProxyServer.AutoSize = true;
            this.lbl_ProxyServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProxyServer.Location = new System.Drawing.Point(388, 120);
            this.lbl_ProxyServer.Name = "lbl_ProxyServer";
            this.lbl_ProxyServer.Size = new System.Drawing.Size(118, 24);
            this.lbl_ProxyServer.TabIndex = 5;
            this.lbl_ProxyServer.Text = "Proxy Server";
            // 
            // panel_Configuration
            // 
            this.panel_Configuration.Controls.Add(this.lbl_Configuration);
            this.panel_Configuration.Controls.Add(this.btn_Connect);
            this.panel_Configuration.Controls.Add(this.button1);
            this.panel_Configuration.Location = new System.Drawing.Point(12, 12);
            this.panel_Configuration.Name = "panel_Configuration";
            this.panel_Configuration.Size = new System.Drawing.Size(870, 796);
            this.panel_Configuration.TabIndex = 9;
            // 
            // lbl_Configuration
            // 
            this.lbl_Configuration.AutoSize = true;
            this.lbl_Configuration.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Configuration.Location = new System.Drawing.Point(6, 17);
            this.lbl_Configuration.Name = "lbl_Configuration";
            this.lbl_Configuration.Size = new System.Drawing.Size(163, 19);
            this.lbl_Configuration.TabIndex = 9;
            this.lbl_Configuration.Text = "Proxy Configuration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 820);
            this.Controls.Add(this.panel_Configuration);
            this.Controls.Add(this.panel_Connect);
            this.Name = "Form1";
            this.Text = "Proxy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Connect.ResumeLayout(false);
            this.panel_Connect.PerformLayout();
            this.panel_Configuration.ResumeLayout(false);
            this.panel_Configuration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.TextBox tb_proxyCode;
        private System.Windows.Forms.Label proxyCode;
        private System.Windows.Forms.Button btn_Connect;
		private System.Windows.Forms.Panel panel_Connect;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbl_ProxyServer;
        private System.Windows.Forms.Panel panel_Configuration;
        private System.Windows.Forms.Label lbl_Configuration;
    }
}

