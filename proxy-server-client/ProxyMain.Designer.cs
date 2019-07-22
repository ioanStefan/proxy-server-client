namespace proxy_server_client
{
    partial class ProxyMain
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
            this.btn_ProxyServers = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Text = new System.Windows.Forms.Button();
            this.btn_InternalHosts = new System.Windows.Forms.Button();
            this.btn_ExitApplication = new System.Windows.Forms.Button();
            this.btn_ProxyTargets = new System.Windows.Forms.Button();
            this.panel_Home = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_StartServer = new System.Windows.Forms.Button();
            this.btn_StopServer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ServerPort = new System.Windows.Forms.TextBox();
            this.rtb_Response = new System.Windows.Forms.RichTextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.rtb_Message = new System.Windows.Forms.RichTextBox();
            this.btn_OpenProxyConnection = new System.Windows.Forms.Button();
            this.btn_CloseProxyConnection = new System.Windows.Forms.Button();
            this.rtbClientRequest = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ProxyServers
            // 
            this.btn_ProxyServers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ProxyServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProxyServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProxyServers.Location = new System.Drawing.Point(7, 12);
            this.btn_ProxyServers.Name = "btn_ProxyServers";
            this.btn_ProxyServers.Size = new System.Drawing.Size(277, 52);
            this.btn_ProxyServers.TabIndex = 0;
            this.btn_ProxyServers.Text = "Proxy Servers";
            this.btn_ProxyServers.UseVisualStyleBackColor = true;
            this.btn_ProxyServers.Click += new System.EventHandler(this.btn_ProxyServers_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Text);
            this.splitContainer1.Panel1.Controls.Add(this.btn_InternalHosts);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ExitApplication);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ProxyTargets);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ProxyServers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_Home);
            this.splitContainer1.Size = new System.Drawing.Size(890, 690);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 10;
            // 
            // btn_Text
            // 
            this.btn_Text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Text.Location = new System.Drawing.Point(7, 186);
            this.btn_Text.Name = "btn_Text";
            this.btn_Text.Size = new System.Drawing.Size(277, 52);
            this.btn_Text.TabIndex = 12;
            this.btn_Text.Text = "Test";
            this.btn_Text.UseVisualStyleBackColor = true;
            this.btn_Text.Click += new System.EventHandler(this.btn_Text_Click);
            // 
            // btn_InternalHosts
            // 
            this.btn_InternalHosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InternalHosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InternalHosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InternalHosts.Location = new System.Drawing.Point(7, 128);
            this.btn_InternalHosts.Name = "btn_InternalHosts";
            this.btn_InternalHosts.Size = new System.Drawing.Size(277, 52);
            this.btn_InternalHosts.TabIndex = 11;
            this.btn_InternalHosts.Text = "Internal Hosts";
            this.btn_InternalHosts.UseVisualStyleBackColor = true;
            this.btn_InternalHosts.Click += new System.EventHandler(this.btn_InternalHosts_Click);
            // 
            // btn_ExitApplication
            // 
            this.btn_ExitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExitApplication.Location = new System.Drawing.Point(7, 611);
            this.btn_ExitApplication.Name = "btn_ExitApplication";
            this.btn_ExitApplication.Size = new System.Drawing.Size(277, 52);
            this.btn_ExitApplication.TabIndex = 10;
            this.btn_ExitApplication.Text = "Exit";
            this.btn_ExitApplication.UseVisualStyleBackColor = true;
            this.btn_ExitApplication.Click += new System.EventHandler(this.btn_ExitApplication_Click);
            // 
            // btn_ProxyTargets
            // 
            this.btn_ProxyTargets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ProxyTargets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProxyTargets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProxyTargets.Location = new System.Drawing.Point(7, 70);
            this.btn_ProxyTargets.Name = "btn_ProxyTargets";
            this.btn_ProxyTargets.Size = new System.Drawing.Size(277, 52);
            this.btn_ProxyTargets.TabIndex = 10;
            this.btn_ProxyTargets.Text = "Proxy Targets";
            this.btn_ProxyTargets.UseVisualStyleBackColor = true;
            this.btn_ProxyTargets.Click += new System.EventHandler(this.btn_ProxyTargets_Click);
            // 
            // panel_Home
            // 
            this.panel_Home.Controls.Add(this.rtbClientRequest);
            this.panel_Home.Controls.Add(this.label5);
            this.panel_Home.Controls.Add(this.label4);
            this.panel_Home.Controls.Add(this.btn_StartServer);
            this.panel_Home.Controls.Add(this.btn_StopServer);
            this.panel_Home.Controls.Add(this.label3);
            this.panel_Home.Controls.Add(this.tb_ServerPort);
            this.panel_Home.Controls.Add(this.rtb_Response);
            this.panel_Home.Controls.Add(this.btn_Send);
            this.panel_Home.Controls.Add(this.label2);
            this.panel_Home.Controls.Add(this.label1);
            this.panel_Home.Controls.Add(this.tb_Port);
            this.panel_Home.Controls.Add(this.tb_IP);
            this.panel_Home.Controls.Add(this.rtb_Message);
            this.panel_Home.Controls.Add(this.btn_OpenProxyConnection);
            this.panel_Home.Controls.Add(this.btn_CloseProxyConnection);
            this.panel_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Home.Location = new System.Drawing.Point(0, 0);
            this.panel_Home.Name = "panel_Home";
            this.panel_Home.Size = new System.Drawing.Size(592, 690);
            this.panel_Home.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(536, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "SERVER___________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(551, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "CLIENT______________________________________________________";
            // 
            // btn_StartServer
            // 
            this.btn_StartServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StartServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartServer.Location = new System.Drawing.Point(374, 585);
            this.btn_StartServer.Name = "btn_StartServer";
            this.btn_StartServer.Size = new System.Drawing.Size(100, 93);
            this.btn_StartServer.TabIndex = 19;
            this.btn_StartServer.Text = "Start Server";
            this.btn_StartServer.UseVisualStyleBackColor = true;
            this.btn_StartServer.Click += new System.EventHandler(this.btn_StartServer_Click);
            // 
            // btn_StopServer
            // 
            this.btn_StopServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StopServer.Enabled = false;
            this.btn_StopServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StopServer.Location = new System.Drawing.Point(480, 585);
            this.btn_StopServer.Name = "btn_StopServer";
            this.btn_StopServer.Size = new System.Drawing.Size(100, 93);
            this.btn_StopServer.TabIndex = 18;
            this.btn_StopServer.Text = "Stop Server";
            this.btn_StopServer.UseVisualStyleBackColor = true;
            this.btn_StopServer.Click += new System.EventHandler(this.btn_StopServer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 614);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Port";
            // 
            // tb_ServerPort
            // 
            this.tb_ServerPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_ServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ServerPort.Location = new System.Drawing.Point(73, 611);
            this.tb_ServerPort.Name = "tb_ServerPort";
            this.tb_ServerPort.Size = new System.Drawing.Size(120, 26);
            this.tb_ServerPort.TabIndex = 16;
            // 
            // rtb_Response
            // 
            this.rtb_Response.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Response.Location = new System.Drawing.Point(24, 271);
            this.rtb_Response.Name = "rtb_Response";
            this.rtb_Response.Size = new System.Drawing.Size(450, 96);
            this.rtb_Response.TabIndex = 15;
            this.rtb_Response.Text = "";
            // 
            // btn_Send
            // 
            this.btn_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(480, 172);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(100, 93);
            this.btn_Send.TabIndex = 14;
            this.btn_Send.Text = "SEND";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "IP";
            // 
            // tb_Port
            // 
            this.tb_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Port.Location = new System.Drawing.Point(354, 137);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(120, 26);
            this.tb_Port.TabIndex = 11;
            // 
            // tb_IP
            // 
            this.tb_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IP.Location = new System.Drawing.Point(50, 137);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(254, 26);
            this.tb_IP.TabIndex = 10;
            // 
            // rtb_Message
            // 
            this.rtb_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Message.Location = new System.Drawing.Point(24, 169);
            this.rtb_Message.Name = "rtb_Message";
            this.rtb_Message.Size = new System.Drawing.Size(450, 96);
            this.rtb_Message.TabIndex = 9;
            this.rtb_Message.Text = "";
            this.rtb_Message.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btn_OpenProxyConnection
            // 
            this.btn_OpenProxyConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btn_OpenProxyConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OpenProxyConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenProxyConnection.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenProxyConnection.ForeColor = System.Drawing.Color.White;
            this.btn_OpenProxyConnection.Location = new System.Drawing.Point(24, 12);
            this.btn_OpenProxyConnection.Name = "btn_OpenProxyConnection";
            this.btn_OpenProxyConnection.Size = new System.Drawing.Size(116, 60);
            this.btn_OpenProxyConnection.TabIndex = 4;
            this.btn_OpenProxyConnection.Text = "Open proxy connection";
            this.btn_OpenProxyConnection.UseVisualStyleBackColor = false;
            this.btn_OpenProxyConnection.Click += new System.EventHandler(this.btn_OpenProxyConnection_Click);
            // 
            // btn_CloseProxyConnection
            // 
            this.btn_CloseProxyConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btn_CloseProxyConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CloseProxyConnection.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseProxyConnection.ForeColor = System.Drawing.Color.White;
            this.btn_CloseProxyConnection.Location = new System.Drawing.Point(146, 12);
            this.btn_CloseProxyConnection.Name = "btn_CloseProxyConnection";
            this.btn_CloseProxyConnection.Size = new System.Drawing.Size(116, 60);
            this.btn_CloseProxyConnection.TabIndex = 8;
            this.btn_CloseProxyConnection.Text = "Close proxy connection";
            this.btn_CloseProxyConnection.UseVisualStyleBackColor = false;
            this.btn_CloseProxyConnection.Click += new System.EventHandler(this.btn_CloseProxyConnection_Click);
            // 
            // rtbClientRequest
            // 
            this.rtbClientRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbClientRequest.Location = new System.Drawing.Point(24, 458);
            this.rtbClientRequest.Name = "rtbClientRequest";
            this.rtbClientRequest.ReadOnly = true;
            this.rtbClientRequest.Size = new System.Drawing.Size(450, 96);
            this.rtbClientRequest.TabIndex = 22;
            this.rtbClientRequest.Text = "";
            // 
            // ProxyMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 690);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProxyMain";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.ProxyMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_Home.ResumeLayout(false);
            this.panel_Home.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ProxyServers;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_ProxyTargets;
        private System.Windows.Forms.Button btn_ExitApplication;
        private System.Windows.Forms.Panel panel_Home;
        private System.Windows.Forms.Button btn_OpenProxyConnection;
        private System.Windows.Forms.Button btn_CloseProxyConnection;
        private System.Windows.Forms.Button btn_Text;
        private System.Windows.Forms.Button btn_InternalHosts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.RichTextBox rtb_Message;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.RichTextBox rtb_Response;
        private System.Windows.Forms.Button btn_StartServer;
        private System.Windows.Forms.Button btn_StopServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ServerPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbClientRequest;
    }
}