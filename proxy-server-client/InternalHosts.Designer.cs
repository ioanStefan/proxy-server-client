namespace proxy_server_client
{
    partial class InternalHosts
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
            this.btn_AddNewHost = new System.Windows.Forms.Button();
            this.rtb_NewInternalHostDetails = new System.Windows.Forms.RichTextBox();
            this.tb_NewInternalHostPort = new System.Windows.Forms.TextBox();
            this.tb_NewInternalHostIP = new System.Windows.Forms.TextBox();
            this.btn_UpdateHost = new System.Windows.Forms.Button();
            this.btn_RemoveHost = new System.Windows.Forms.Button();
            this.lbl_AddNewProxyServer = new System.Windows.Forms.Label();
            this.lbl_ProxyDetails = new System.Windows.Forms.Label();
            this.rtb_InternalHostDetails = new System.Windows.Forms.RichTextBox();
            this.lbl_InternalHosts = new System.Windows.Forms.Label();
            this.lb_InternalHosts = new System.Windows.Forms.ListBox();
            this.panel_ProxyServers = new System.Windows.Forms.Panel();
            this.panel_ProxyServers.SuspendLayout();
            this.SuspendLayout();
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
            this.label5.Location = new System.Drawing.Point(54, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Algorithm *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 443);
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
            this.label3.Location = new System.Drawing.Point(72, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Details *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hostname *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Port *";
            // 
            // btn_AddNewHost
            // 
            this.btn_AddNewHost.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_AddNewHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNewHost.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewHost.ForeColor = System.Drawing.Color.White;
            this.btn_AddNewHost.Location = new System.Drawing.Point(453, 627);
            this.btn_AddNewHost.Name = "btn_AddNewHost";
            this.btn_AddNewHost.Size = new System.Drawing.Size(110, 45);
            this.btn_AddNewHost.TabIndex = 16;
            this.btn_AddNewHost.Text = "ADD";
            this.btn_AddNewHost.UseVisualStyleBackColor = false;
            this.btn_AddNewHost.Click += new System.EventHandler(this.btn_AddNewHost_Click);
            // 
            // rtb_NewInternalHostDetails
            // 
            this.rtb_NewInternalHostDetails.Location = new System.Drawing.Point(157, 510);
            this.rtb_NewInternalHostDetails.Name = "rtb_NewInternalHostDetails";
            this.rtb_NewInternalHostDetails.Size = new System.Drawing.Size(265, 162);
            this.rtb_NewInternalHostDetails.TabIndex = 15;
            this.rtb_NewInternalHostDetails.Text = "";
            // 
            // tb_NewInternalHostPort
            // 
            this.tb_NewInternalHostPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NewInternalHostPort.Location = new System.Drawing.Point(157, 402);
            this.tb_NewInternalHostPort.Name = "tb_NewInternalHostPort";
            this.tb_NewInternalHostPort.Size = new System.Drawing.Size(265, 29);
            this.tb_NewInternalHostPort.TabIndex = 14;
            // 
            // tb_NewInternalHostIP
            // 
            this.tb_NewInternalHostIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NewInternalHostIP.Location = new System.Drawing.Point(157, 367);
            this.tb_NewInternalHostIP.Name = "tb_NewInternalHostIP";
            this.tb_NewInternalHostIP.Size = new System.Drawing.Size(265, 29);
            this.tb_NewInternalHostIP.TabIndex = 13;
            // 
            // btn_UpdateHost
            // 
            this.btn_UpdateHost.BackColor = System.Drawing.Color.DarkGray;
            this.btn_UpdateHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateHost.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateHost.Location = new System.Drawing.Point(453, 288);
            this.btn_UpdateHost.Name = "btn_UpdateHost";
            this.btn_UpdateHost.Size = new System.Drawing.Size(110, 45);
            this.btn_UpdateHost.TabIndex = 12;
            this.btn_UpdateHost.Text = "Update";
            this.btn_UpdateHost.UseVisualStyleBackColor = false;
            this.btn_UpdateHost.Click += new System.EventHandler(this.btn_UpdateHost_Click);
            // 
            // btn_RemoveHost
            // 
            this.btn_RemoveHost.BackColor = System.Drawing.Color.Tomato;
            this.btn_RemoveHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveHost.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveHost.Location = new System.Drawing.Point(337, 288);
            this.btn_RemoveHost.Name = "btn_RemoveHost";
            this.btn_RemoveHost.Size = new System.Drawing.Size(110, 45);
            this.btn_RemoveHost.TabIndex = 11;
            this.btn_RemoveHost.Text = "Remove";
            this.btn_RemoveHost.UseVisualStyleBackColor = false;
            this.btn_RemoveHost.Click += new System.EventHandler(this.btn_RemoveHost_Click);
            // 
            // lbl_AddNewProxyServer
            // 
            this.lbl_AddNewProxyServer.AutoSize = true;
            this.lbl_AddNewProxyServer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewProxyServer.Location = new System.Drawing.Point(5, 336);
            this.lbl_AddNewProxyServer.Name = "lbl_AddNewProxyServer";
            this.lbl_AddNewProxyServer.Size = new System.Drawing.Size(175, 19);
            this.lbl_AddNewProxyServer.TabIndex = 5;
            this.lbl_AddNewProxyServer.Text = "Add new internal host";
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
            // rtb_InternalHostDetails
            // 
            this.rtb_InternalHostDetails.Location = new System.Drawing.Point(298, 173);
            this.rtb_InternalHostDetails.Name = "rtb_InternalHostDetails";
            this.rtb_InternalHostDetails.Size = new System.Drawing.Size(265, 109);
            this.rtb_InternalHostDetails.TabIndex = 3;
            this.rtb_InternalHostDetails.Text = "";
            // 
            // lbl_InternalHosts
            // 
            this.lbl_InternalHosts.AutoSize = true;
            this.lbl_InternalHosts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InternalHosts.Location = new System.Drawing.Point(5, 8);
            this.lbl_InternalHosts.Name = "lbl_InternalHosts";
            this.lbl_InternalHosts.Size = new System.Drawing.Size(111, 19);
            this.lbl_InternalHosts.TabIndex = 2;
            this.lbl_InternalHosts.Text = "InternalHosts";
            // 
            // lb_InternalHosts
            // 
            this.lb_InternalHosts.FormattingEnabled = true;
            this.lb_InternalHosts.Location = new System.Drawing.Point(9, 30);
            this.lb_InternalHosts.Name = "lb_InternalHosts";
            this.lb_InternalHosts.Size = new System.Drawing.Size(283, 251);
            this.lb_InternalHosts.TabIndex = 1;
            this.lb_InternalHosts.SelectedIndexChanged += new System.EventHandler(this.lb_InternalHosts_SelectedIndexChanged);
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
            this.panel_ProxyServers.Controls.Add(this.btn_AddNewHost);
            this.panel_ProxyServers.Controls.Add(this.rtb_NewInternalHostDetails);
            this.panel_ProxyServers.Controls.Add(this.tb_NewInternalHostPort);
            this.panel_ProxyServers.Controls.Add(this.tb_NewInternalHostIP);
            this.panel_ProxyServers.Controls.Add(this.btn_UpdateHost);
            this.panel_ProxyServers.Controls.Add(this.btn_RemoveHost);
            this.panel_ProxyServers.Controls.Add(this.lbl_AddNewProxyServer);
            this.panel_ProxyServers.Controls.Add(this.lbl_ProxyDetails);
            this.panel_ProxyServers.Controls.Add(this.rtb_InternalHostDetails);
            this.panel_ProxyServers.Controls.Add(this.lbl_InternalHosts);
            this.panel_ProxyServers.Controls.Add(this.lb_InternalHosts);
            this.panel_ProxyServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ProxyServers.Location = new System.Drawing.Point(0, 0);
            this.panel_ProxyServers.Name = "panel_ProxyServers";
            this.panel_ProxyServers.Size = new System.Drawing.Size(575, 684);
            this.panel_ProxyServers.TabIndex = 12;
            // 
            // InternalHosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 684);
            this.Controls.Add(this.panel_ProxyServers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InternalHosts";
            this.ShowIcon = false;
            this.Text = "Internal Hosts";
            this.panel_ProxyServers.ResumeLayout(false);
            this.panel_ProxyServers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_pdAlgorithm;
        private System.Windows.Forms.TextBox tb_pdSecredKey;
        private System.Windows.Forms.TextBox tb_pdPort;
        private System.Windows.Forms.TextBox tb_pdHostname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_newAlgorithm;
        private System.Windows.Forms.TextBox tb_newSecredKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddNewHost;
        private System.Windows.Forms.RichTextBox rtb_NewInternalHostDetails;
        private System.Windows.Forms.TextBox tb_NewInternalHostPort;
        private System.Windows.Forms.TextBox tb_NewInternalHostIP;
        private System.Windows.Forms.Button btn_UpdateHost;
        private System.Windows.Forms.Button btn_RemoveHost;
        private System.Windows.Forms.Label lbl_AddNewProxyServer;
        private System.Windows.Forms.Label lbl_ProxyDetails;
        private System.Windows.Forms.RichTextBox rtb_InternalHostDetails;
        private System.Windows.Forms.Label lbl_InternalHosts;
        private System.Windows.Forms.ListBox lb_InternalHosts;
        private System.Windows.Forms.Panel panel_ProxyServers;
    }
}