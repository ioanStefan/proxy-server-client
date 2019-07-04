namespace proxy_server_client
{
    partial class ProxyServers
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
            this.panel_ProxyServers = new System.Windows.Forms.Panel();
            this.cb_pdAlgorithm = new System.Windows.Forms.ComboBox();
            this.tb_pdSecredKey = new System.Windows.Forms.TextBox();
            this.tb_pdPort = new System.Windows.Forms.TextBox();
            this.tb_pdHostname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_newAlgorithm = new System.Windows.Forms.ComboBox();
            this.tb_newSecredKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddNewProxyServer = new System.Windows.Forms.Button();
            this.rtb_NewProxyServerDetails = new System.Windows.Forms.RichTextBox();
            this.tb_NewProxyServerPort = new System.Windows.Forms.TextBox();
            this.tb_NewProxyServerIP = new System.Windows.Forms.TextBox();
            this.btn_UpdateProxyServer = new System.Windows.Forms.Button();
            this.btn_RemoveProxyServer = new System.Windows.Forms.Button();
            this.lbl_AddNewProxyServer = new System.Windows.Forms.Label();
            this.lbl_ProxyDetails = new System.Windows.Forms.Label();
            this.rtb_ProxyDetails = new System.Windows.Forms.RichTextBox();
            this.lbl_ProxyServers = new System.Windows.Forms.Label();
            this.lbox_ProxyServers = new System.Windows.Forms.ListBox();
            this.panel_ProxyServers.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ProxyServers
            // 
            this.panel_ProxyServers.Controls.Add(this.cb_pdAlgorithm);
            this.panel_ProxyServers.Controls.Add(this.tb_pdSecredKey);
            this.panel_ProxyServers.Controls.Add(this.tb_pdPort);
            this.panel_ProxyServers.Controls.Add(this.tb_pdHostname);
            this.panel_ProxyServers.Controls.Add(this.label5);
            this.panel_ProxyServers.Controls.Add(this.label4);
            this.panel_ProxyServers.Controls.Add(this.cb_newAlgorithm);
            this.panel_ProxyServers.Controls.Add(this.tb_newSecredKey);
            this.panel_ProxyServers.Controls.Add(this.label3);
            this.panel_ProxyServers.Controls.Add(this.label1);
            this.panel_ProxyServers.Controls.Add(this.label2);
            this.panel_ProxyServers.Controls.Add(this.btn_AddNewProxyServer);
            this.panel_ProxyServers.Controls.Add(this.rtb_NewProxyServerDetails);
            this.panel_ProxyServers.Controls.Add(this.tb_NewProxyServerPort);
            this.panel_ProxyServers.Controls.Add(this.tb_NewProxyServerIP);
            this.panel_ProxyServers.Controls.Add(this.btn_UpdateProxyServer);
            this.panel_ProxyServers.Controls.Add(this.btn_RemoveProxyServer);
            this.panel_ProxyServers.Controls.Add(this.lbl_AddNewProxyServer);
            this.panel_ProxyServers.Controls.Add(this.lbl_ProxyDetails);
            this.panel_ProxyServers.Controls.Add(this.rtb_ProxyDetails);
            this.panel_ProxyServers.Controls.Add(this.lbl_ProxyServers);
            this.panel_ProxyServers.Controls.Add(this.lbox_ProxyServers);
            this.panel_ProxyServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ProxyServers.Location = new System.Drawing.Point(0, 0);
            this.panel_ProxyServers.Name = "panel_ProxyServers";
            this.panel_ProxyServers.Size = new System.Drawing.Size(575, 684);
            this.panel_ProxyServers.TabIndex = 11;
            // 
            // cb_pdAlgorithm
            // 
            this.cb_pdAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pdAlgorithm.FormattingEnabled = true;
            this.cb_pdAlgorithm.Items.AddRange(new object[] {
            "aes-256-cbc",
            "aes-256-ctr",
            "aes-256-cfb",
            "des-cbc",
            "des-cfb"});
            this.cb_pdAlgorithm.Location = new System.Drawing.Point(298, 135);
            this.cb_pdAlgorithm.Name = "cb_pdAlgorithm";
            this.cb_pdAlgorithm.Size = new System.Drawing.Size(265, 32);
            this.cb_pdAlgorithm.TabIndex = 28;
            // 
            // tb_pdSecredKey
            // 
            this.tb_pdSecredKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pdSecredKey.Location = new System.Drawing.Point(298, 100);
            this.tb_pdSecredKey.Name = "tb_pdSecredKey";
            this.tb_pdSecredKey.Size = new System.Drawing.Size(265, 29);
            this.tb_pdSecredKey.TabIndex = 27;
            // 
            // tb_pdPort
            // 
            this.tb_pdPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pdPort.Location = new System.Drawing.Point(298, 65);
            this.tb_pdPort.Name = "tb_pdPort";
            this.tb_pdPort.Size = new System.Drawing.Size(265, 29);
            this.tb_pdPort.TabIndex = 26;
            // 
            // tb_pdHostname
            // 
            this.tb_pdHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pdHostname.Location = new System.Drawing.Point(298, 30);
            this.tb_pdHostname.Name = "tb_pdHostname";
            this.tb_pdHostname.ReadOnly = true;
            this.tb_pdHostname.Size = new System.Drawing.Size(265, 29);
            this.tb_pdHostname.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Algorithm *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Secret key *";
            // 
            // cb_newAlgorithm
            // 
            this.cb_newAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_newAlgorithm.FormattingEnabled = true;
            this.cb_newAlgorithm.Items.AddRange(new object[] {
            "aes-256-cbc",
            "aes-256-ctr",
            "aes-256-cfb",
            "des-cbc",
            "des-cfb"});
            this.cb_newAlgorithm.Location = new System.Drawing.Point(157, 472);
            this.cb_newAlgorithm.Name = "cb_newAlgorithm";
            this.cb_newAlgorithm.Size = new System.Drawing.Size(265, 32);
            this.cb_newAlgorithm.TabIndex = 22;
            // 
            // tb_newSecredKey
            // 
            this.tb_newSecredKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_newSecredKey.Location = new System.Drawing.Point(157, 437);
            this.tb_newSecredKey.Name = "tb_newSecredKey";
            this.tb_newSecredKey.Size = new System.Drawing.Size(265, 29);
            this.tb_newSecredKey.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Details *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hostname *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Port *";
            // 
            // btn_AddNewProxyServer
            // 
            this.btn_AddNewProxyServer.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_AddNewProxyServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNewProxyServer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewProxyServer.ForeColor = System.Drawing.Color.White;
            this.btn_AddNewProxyServer.Location = new System.Drawing.Point(453, 627);
            this.btn_AddNewProxyServer.Name = "btn_AddNewProxyServer";
            this.btn_AddNewProxyServer.Size = new System.Drawing.Size(110, 45);
            this.btn_AddNewProxyServer.TabIndex = 16;
            this.btn_AddNewProxyServer.Text = "ADD";
            this.btn_AddNewProxyServer.UseVisualStyleBackColor = false;
            this.btn_AddNewProxyServer.Click += new System.EventHandler(this.btn_AddNewProxyServer_Click);
            // 
            // rtb_NewProxyServerDetails
            // 
            this.rtb_NewProxyServerDetails.Location = new System.Drawing.Point(157, 510);
            this.rtb_NewProxyServerDetails.Name = "rtb_NewProxyServerDetails";
            this.rtb_NewProxyServerDetails.Size = new System.Drawing.Size(265, 162);
            this.rtb_NewProxyServerDetails.TabIndex = 15;
            this.rtb_NewProxyServerDetails.Text = "";
            // 
            // tb_NewProxyServerPort
            // 
            this.tb_NewProxyServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NewProxyServerPort.Location = new System.Drawing.Point(157, 402);
            this.tb_NewProxyServerPort.Name = "tb_NewProxyServerPort";
            this.tb_NewProxyServerPort.Size = new System.Drawing.Size(265, 29);
            this.tb_NewProxyServerPort.TabIndex = 14;
            // 
            // tb_NewProxyServerIP
            // 
            this.tb_NewProxyServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NewProxyServerIP.Location = new System.Drawing.Point(157, 367);
            this.tb_NewProxyServerIP.Name = "tb_NewProxyServerIP";
            this.tb_NewProxyServerIP.Size = new System.Drawing.Size(265, 29);
            this.tb_NewProxyServerIP.TabIndex = 13;
            // 
            // btn_UpdateProxyServer
            // 
            this.btn_UpdateProxyServer.BackColor = System.Drawing.Color.DarkGray;
            this.btn_UpdateProxyServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateProxyServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateProxyServer.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateProxyServer.Location = new System.Drawing.Point(453, 288);
            this.btn_UpdateProxyServer.Name = "btn_UpdateProxyServer";
            this.btn_UpdateProxyServer.Size = new System.Drawing.Size(110, 45);
            this.btn_UpdateProxyServer.TabIndex = 12;
            this.btn_UpdateProxyServer.Text = "Update";
            this.btn_UpdateProxyServer.UseVisualStyleBackColor = false;
            this.btn_UpdateProxyServer.Click += new System.EventHandler(this.btn_UpdateProxyServer_Click);
            // 
            // btn_RemoveProxyServer
            // 
            this.btn_RemoveProxyServer.BackColor = System.Drawing.Color.Tomato;
            this.btn_RemoveProxyServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveProxyServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveProxyServer.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveProxyServer.Location = new System.Drawing.Point(337, 288);
            this.btn_RemoveProxyServer.Name = "btn_RemoveProxyServer";
            this.btn_RemoveProxyServer.Size = new System.Drawing.Size(110, 45);
            this.btn_RemoveProxyServer.TabIndex = 11;
            this.btn_RemoveProxyServer.Text = "Remove";
            this.btn_RemoveProxyServer.UseVisualStyleBackColor = false;
            this.btn_RemoveProxyServer.Click += new System.EventHandler(this.btn_RemoveProxyServer_Click);
            // 
            // lbl_AddNewProxyServer
            // 
            this.lbl_AddNewProxyServer.AutoSize = true;
            this.lbl_AddNewProxyServer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewProxyServer.Location = new System.Drawing.Point(5, 336);
            this.lbl_AddNewProxyServer.Name = "lbl_AddNewProxyServer";
            this.lbl_AddNewProxyServer.Size = new System.Drawing.Size(176, 19);
            this.lbl_AddNewProxyServer.TabIndex = 5;
            this.lbl_AddNewProxyServer.Text = "Add new proxy server";
            // 
            // lbl_ProxyDetails
            // 
            this.lbl_ProxyDetails.AutoSize = true;
            this.lbl_ProxyDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProxyDetails.Location = new System.Drawing.Point(294, 8);
            this.lbl_ProxyDetails.Name = "lbl_ProxyDetails";
            this.lbl_ProxyDetails.Size = new System.Drawing.Size(61, 19);
            this.lbl_ProxyDetails.TabIndex = 4;
            this.lbl_ProxyDetails.Text = "Details";
            // 
            // rtb_ProxyDetails
            // 
            this.rtb_ProxyDetails.Location = new System.Drawing.Point(298, 173);
            this.rtb_ProxyDetails.Name = "rtb_ProxyDetails";
            this.rtb_ProxyDetails.Size = new System.Drawing.Size(265, 109);
            this.rtb_ProxyDetails.TabIndex = 3;
            this.rtb_ProxyDetails.Text = "";
            // 
            // lbl_ProxyServers
            // 
            this.lbl_ProxyServers.AutoSize = true;
            this.lbl_ProxyServers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProxyServers.Location = new System.Drawing.Point(5, 8);
            this.lbl_ProxyServers.Name = "lbl_ProxyServers";
            this.lbl_ProxyServers.Size = new System.Drawing.Size(117, 19);
            this.lbl_ProxyServers.TabIndex = 2;
            this.lbl_ProxyServers.Text = "Proxy Servers";
            // 
            // lbox_ProxyServers
            // 
            this.lbox_ProxyServers.FormattingEnabled = true;
            this.lbox_ProxyServers.Location = new System.Drawing.Point(9, 30);
            this.lbox_ProxyServers.Name = "lbox_ProxyServers";
            this.lbox_ProxyServers.Size = new System.Drawing.Size(283, 251);
            this.lbox_ProxyServers.TabIndex = 1;
            this.lbox_ProxyServers.SelectedIndexChanged += new System.EventHandler(this.lbox_ProxyServers_SelectedIndexChanged);
            // 
            // ProxyServers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 684);
            this.Controls.Add(this.panel_ProxyServers);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(591, 723);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(591, 723);
            this.Name = "ProxyServers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Proxy Servers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProxyServers_FormClosed);
            this.panel_ProxyServers.ResumeLayout(false);
            this.panel_ProxyServers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ProxyServers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddNewProxyServer;
        private System.Windows.Forms.RichTextBox rtb_NewProxyServerDetails;
        private System.Windows.Forms.TextBox tb_NewProxyServerPort;
        private System.Windows.Forms.TextBox tb_NewProxyServerIP;
        private System.Windows.Forms.Button btn_UpdateProxyServer;
        private System.Windows.Forms.Button btn_RemoveProxyServer;
        private System.Windows.Forms.Label lbl_AddNewProxyServer;
        private System.Windows.Forms.Label lbl_ProxyDetails;
        private System.Windows.Forms.RichTextBox rtb_ProxyDetails;
        private System.Windows.Forms.Label lbl_ProxyServers;
        private System.Windows.Forms.ListBox lbox_ProxyServers;
        private System.Windows.Forms.ComboBox cb_pdAlgorithm;
        private System.Windows.Forms.TextBox tb_pdSecredKey;
        private System.Windows.Forms.TextBox tb_pdPort;
        private System.Windows.Forms.TextBox tb_pdHostname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_newAlgorithm;
        private System.Windows.Forms.TextBox tb_newSecredKey;
    }
}