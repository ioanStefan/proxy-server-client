namespace proxy_server_client
{
    partial class ProxyLogin
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
            this.tb_token = new System.Windows.Forms.TextBox();
            this.proxyCode = new System.Windows.Forms.Label();
            this.panel_Connect = new System.Windows.Forms.Panel();
            this.lbl_ProxyServer = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel_Connect.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_IP
            // 
            this.tb_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IP.Location = new System.Drawing.Point(182, 107);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(265, 29);
            this.tb_IP.TabIndex = 0;
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IP.Location = new System.Drawing.Point(39, 110);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(137, 24);
            this.lbl_IP.TabIndex = 1;
            this.lbl_IP.Text = "Server address";
            // 
            // tb_token
            // 
            this.tb_token.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_token.Location = new System.Drawing.Point(182, 144);
            this.tb_token.Name = "tb_token";
            this.tb_token.Size = new System.Drawing.Size(265, 29);
            this.tb_token.TabIndex = 2;
            // 
            // proxyCode
            // 
            this.proxyCode.AutoSize = true;
            this.proxyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proxyCode.Location = new System.Drawing.Point(112, 147);
            this.proxyCode.Name = "proxyCode";
            this.proxyCode.Size = new System.Drawing.Size(64, 24);
            this.proxyCode.TabIndex = 3;
            this.proxyCode.Text = "Token";
            // 
            // panel_Connect
            // 
            this.panel_Connect.Controls.Add(this.lbl_ProxyServer);
            this.panel_Connect.Controls.Add(this.btnLogin);
            this.panel_Connect.Controls.Add(this.tb_IP);
            this.panel_Connect.Controls.Add(this.lbl_IP);
            this.panel_Connect.Controls.Add(this.tb_token);
            this.panel_Connect.Controls.Add(this.proxyCode);
            this.panel_Connect.Location = new System.Drawing.Point(12, 12);
            this.panel_Connect.Name = "panel_Connect";
            this.panel_Connect.Size = new System.Drawing.Size(604, 304);
            this.panel_Connect.TabIndex = 7;
            // 
            // lbl_ProxyServer
            // 
            this.lbl_ProxyServer.AutoSize = true;
            this.lbl_ProxyServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProxyServer.Location = new System.Drawing.Point(255, 30);
            this.lbl_ProxyServer.Name = "lbl_ProxyServer";
            this.lbl_ProxyServer.Size = new System.Drawing.Size(118, 24);
            this.lbl_ProxyServer.TabIndex = 5;
            this.lbl_ProxyServer.Text = "Proxy Server";
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
            this.btnLogin.Location = new System.Drawing.Point(249, 209);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(130, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // ProxyLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 328);
            this.Controls.Add(this.panel_Connect);
            this.Name = "ProxyLogin";
            this.Text = "Proxy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Connect.ResumeLayout(false);
            this.panel_Connect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.TextBox tb_token;
        private System.Windows.Forms.Label proxyCode;
		private System.Windows.Forms.Panel panel_Connect;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbl_ProxyServer;
    }
}

