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
            this.btn_OpenProxyConnection = new System.Windows.Forms.Button();
            this.btn_CloseProxyConnection = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_ExitApplication = new System.Windows.Forms.Button();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.btn_ProxyTargets = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel_Home = new System.Windows.Forms.Panel();
            this.panel_ProxyServers = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddNewProxyServer = new System.Windows.Forms.Button();
            this.rtb_NewProxyServerDetails = new System.Windows.Forms.RichTextBox();
            this.tb_NewProxyServerPort = new System.Windows.Forms.TextBox();
            this.tb_NewProxyServerIP = new System.Windows.Forms.TextBox();
            this.btn_UndoRemoveProxyServer = new System.Windows.Forms.Button();
            this.btn_RemoveProxyServer = new System.Windows.Forms.Button();
            this.lbl_AddNewProxyServer = new System.Windows.Forms.Label();
            this.lbl_ProxyDetails = new System.Windows.Forms.Label();
            this.rtbox_ProxyDetails = new System.Windows.Forms.RichTextBox();
            this.lbl_ProxyServers = new System.Windows.Forms.Label();
            this.lbox_ProxyServers = new System.Windows.Forms.ListBox();
            this.lbl_Home = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_Home.SuspendLayout();
            this.panel_ProxyServers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ProxyServers
            // 
            this.btn_ProxyServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProxyServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProxyServers.Location = new System.Drawing.Point(7, 61);
            this.btn_ProxyServers.Name = "btn_ProxyServers";
            this.btn_ProxyServers.Size = new System.Drawing.Size(277, 52);
            this.btn_ProxyServers.TabIndex = 0;
            this.btn_ProxyServers.Text = "Proxy Servers";
            this.btn_ProxyServers.UseVisualStyleBackColor = true;
            this.btn_ProxyServers.Click += new System.EventHandler(this.btn_ProxyServers_Click);
            // 
            // btn_OpenProxyConnection
            // 
            this.btn_OpenProxyConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btn_OpenProxyConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OpenProxyConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenProxyConnection.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenProxyConnection.ForeColor = System.Drawing.Color.White;
            this.btn_OpenProxyConnection.Location = new System.Drawing.Point(312, 17);
            this.btn_OpenProxyConnection.Name = "btn_OpenProxyConnection";
            this.btn_OpenProxyConnection.Size = new System.Drawing.Size(110, 60);
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
            this.btn_CloseProxyConnection.Location = new System.Drawing.Point(428, 17);
            this.btn_CloseProxyConnection.Name = "btn_CloseProxyConnection";
            this.btn_CloseProxyConnection.Size = new System.Drawing.Size(116, 60);
            this.btn_CloseProxyConnection.TabIndex = 8;
            this.btn_CloseProxyConnection.Text = "Close proxy connection";
            this.btn_CloseProxyConnection.UseVisualStyleBackColor = false;
            this.btn_CloseProxyConnection.Click += new System.EventHandler(this.btn_CloseProxyConnection_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_ExitApplication);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ChangePassword);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ProxyTargets);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Home);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ProxyServers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_Home);
            this.splitContainer1.Size = new System.Drawing.Size(878, 690);
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.TabIndex = 10;
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
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangePassword.Location = new System.Drawing.Point(7, 491);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(277, 52);
            this.btn_ChangePassword.TabIndex = 10;
            this.btn_ChangePassword.Text = "Change Password";
            this.btn_ChangePassword.UseVisualStyleBackColor = true;
            // 
            // btn_ProxyTargets
            // 
            this.btn_ProxyTargets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProxyTargets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProxyTargets.Location = new System.Drawing.Point(7, 119);
            this.btn_ProxyTargets.Name = "btn_ProxyTargets";
            this.btn_ProxyTargets.Size = new System.Drawing.Size(277, 52);
            this.btn_ProxyTargets.TabIndex = 10;
            this.btn_ProxyTargets.Text = "Proxy Targets";
            this.btn_ProxyTargets.UseVisualStyleBackColor = true;
            // 
            // btn_Home
            // 
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Location = new System.Drawing.Point(7, 3);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(277, 52);
            this.btn_Home.TabIndex = 1;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panel_Home
            // 
            this.panel_Home.Controls.Add(this.panel_ProxyServers);
            this.panel_Home.Controls.Add(this.lbl_Home);
            this.panel_Home.Controls.Add(this.btn_OpenProxyConnection);
            this.panel_Home.Controls.Add(this.btn_CloseProxyConnection);
            this.panel_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Home.Location = new System.Drawing.Point(0, 0);
            this.panel_Home.Name = "panel_Home";
            this.panel_Home.Size = new System.Drawing.Size(583, 690);
            this.panel_Home.TabIndex = 9;
            // 
            // panel_ProxyServers
            // 
            this.panel_ProxyServers.Controls.Add(this.label3);
            this.panel_ProxyServers.Controls.Add(this.label1);
            this.panel_ProxyServers.Controls.Add(this.label2);
            this.panel_ProxyServers.Controls.Add(this.btn_AddNewProxyServer);
            this.panel_ProxyServers.Controls.Add(this.rtb_NewProxyServerDetails);
            this.panel_ProxyServers.Controls.Add(this.tb_NewProxyServerPort);
            this.panel_ProxyServers.Controls.Add(this.tb_NewProxyServerIP);
            this.panel_ProxyServers.Controls.Add(this.btn_UndoRemoveProxyServer);
            this.panel_ProxyServers.Controls.Add(this.btn_RemoveProxyServer);
            this.panel_ProxyServers.Controls.Add(this.lbl_AddNewProxyServer);
            this.panel_ProxyServers.Controls.Add(this.lbl_ProxyDetails);
            this.panel_ProxyServers.Controls.Add(this.rtbox_ProxyDetails);
            this.panel_ProxyServers.Controls.Add(this.lbl_ProxyServers);
            this.panel_ProxyServers.Controls.Add(this.lbox_ProxyServers);
            this.panel_ProxyServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ProxyServers.Location = new System.Drawing.Point(0, 0);
            this.panel_ProxyServers.Name = "panel_ProxyServers";
            this.panel_ProxyServers.Size = new System.Drawing.Size(583, 690);
            this.panel_ProxyServers.TabIndex = 10;
            this.panel_ProxyServers.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = " IP/HOSTNAME *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Port";
            // 
            // btn_AddNewProxyServer
            // 
            this.btn_AddNewProxyServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNewProxyServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewProxyServer.Location = new System.Drawing.Point(433, 626);
            this.btn_AddNewProxyServer.Name = "btn_AddNewProxyServer";
            this.btn_AddNewProxyServer.Size = new System.Drawing.Size(135, 52);
            this.btn_AddNewProxyServer.TabIndex = 16;
            this.btn_AddNewProxyServer.Text = "Add";
            this.btn_AddNewProxyServer.UseVisualStyleBackColor = true;
            // 
            // rtb_NewProxyServerDetails
            // 
            this.rtb_NewProxyServerDetails.Location = new System.Drawing.Point(157, 516);
            this.rtb_NewProxyServerDetails.Name = "rtb_NewProxyServerDetails";
            this.rtb_NewProxyServerDetails.Size = new System.Drawing.Size(265, 162);
            this.rtb_NewProxyServerDetails.TabIndex = 15;
            this.rtb_NewProxyServerDetails.Text = "";
            // 
            // tb_NewProxyServerPort
            // 
            this.tb_NewProxyServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NewProxyServerPort.Location = new System.Drawing.Point(157, 481);
            this.tb_NewProxyServerPort.Name = "tb_NewProxyServerPort";
            this.tb_NewProxyServerPort.Size = new System.Drawing.Size(265, 29);
            this.tb_NewProxyServerPort.TabIndex = 14;
            // 
            // tb_NewProxyServerIP
            // 
            this.tb_NewProxyServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NewProxyServerIP.Location = new System.Drawing.Point(157, 446);
            this.tb_NewProxyServerIP.Name = "tb_NewProxyServerIP";
            this.tb_NewProxyServerIP.Size = new System.Drawing.Size(265, 29);
            this.tb_NewProxyServerIP.TabIndex = 13;
            // 
            // btn_UndoRemoveProxyServer
            // 
            this.btn_UndoRemoveProxyServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UndoRemoveProxyServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UndoRemoveProxyServer.Location = new System.Drawing.Point(433, 333);
            this.btn_UndoRemoveProxyServer.Name = "btn_UndoRemoveProxyServer";
            this.btn_UndoRemoveProxyServer.Size = new System.Drawing.Size(135, 52);
            this.btn_UndoRemoveProxyServer.TabIndex = 12;
            this.btn_UndoRemoveProxyServer.Text = "Undo";
            this.btn_UndoRemoveProxyServer.UseVisualStyleBackColor = true;
            // 
            // btn_RemoveProxyServer
            // 
            this.btn_RemoveProxyServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveProxyServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveProxyServer.Location = new System.Drawing.Point(292, 333);
            this.btn_RemoveProxyServer.Name = "btn_RemoveProxyServer";
            this.btn_RemoveProxyServer.Size = new System.Drawing.Size(135, 52);
            this.btn_RemoveProxyServer.TabIndex = 11;
            this.btn_RemoveProxyServer.Text = "Remove";
            this.btn_RemoveProxyServer.UseVisualStyleBackColor = true;
            // 
            // lbl_AddNewProxyServer
            // 
            this.lbl_AddNewProxyServer.AutoSize = true;
            this.lbl_AddNewProxyServer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewProxyServer.Location = new System.Drawing.Point(7, 406);
            this.lbl_AddNewProxyServer.Name = "lbl_AddNewProxyServer";
            this.lbl_AddNewProxyServer.Size = new System.Drawing.Size(179, 19);
            this.lbl_AddNewProxyServer.TabIndex = 5;
            this.lbl_AddNewProxyServer.Text = "Add new Proxy Server";
            // 
            // lbl_ProxyDetails
            // 
            this.lbl_ProxyDetails.AutoSize = true;
            this.lbl_ProxyDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProxyDetails.Location = new System.Drawing.Point(371, 53);
            this.lbl_ProxyDetails.Name = "lbl_ProxyDetails";
            this.lbl_ProxyDetails.Size = new System.Drawing.Size(61, 19);
            this.lbl_ProxyDetails.TabIndex = 4;
            this.lbl_ProxyDetails.Text = "Details";
            // 
            // rtbox_ProxyDetails
            // 
            this.rtbox_ProxyDetails.Location = new System.Drawing.Point(292, 75);
            this.rtbox_ProxyDetails.Name = "rtbox_ProxyDetails";
            this.rtbox_ProxyDetails.Size = new System.Drawing.Size(277, 252);
            this.rtbox_ProxyDetails.TabIndex = 3;
            this.rtbox_ProxyDetails.Text = "";
            // 
            // lbl_ProxyServers
            // 
            this.lbl_ProxyServers.AutoSize = true;
            this.lbl_ProxyServers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProxyServers.Location = new System.Drawing.Point(72, 53);
            this.lbl_ProxyServers.Name = "lbl_ProxyServers";
            this.lbl_ProxyServers.Size = new System.Drawing.Size(117, 19);
            this.lbl_ProxyServers.TabIndex = 2;
            this.lbl_ProxyServers.Text = "Proxy Servers";
            // 
            // lbox_ProxyServers
            // 
            this.lbox_ProxyServers.FormattingEnabled = true;
            this.lbox_ProxyServers.Location = new System.Drawing.Point(9, 75);
            this.lbox_ProxyServers.Name = "lbox_ProxyServers";
            this.lbox_ProxyServers.Size = new System.Drawing.Size(277, 251);
            this.lbox_ProxyServers.TabIndex = 1;
            // 
            // lbl_Home
            // 
            this.lbl_Home.AutoSize = true;
            this.lbl_Home.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.Location = new System.Drawing.Point(6, 17);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(54, 19);
            this.lbl_Home.TabIndex = 9;
            this.lbl_Home.Text = "Home";
            // 
            // ProxyMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 690);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProxyMain";
            this.Text = "ProxyMain";
            this.Load += new System.EventHandler(this.ProxyMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_Home.ResumeLayout(false);
            this.panel_Home.PerformLayout();
            this.panel_ProxyServers.ResumeLayout(false);
            this.panel_ProxyServers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ProxyServers;
        private System.Windows.Forms.Button btn_OpenProxyConnection;
        private System.Windows.Forms.Button btn_CloseProxyConnection;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel_Home;
        private System.Windows.Forms.Label lbl_Home;
        private System.Windows.Forms.Button btn_ProxyTargets;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_ExitApplication;
        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.Panel panel_ProxyServers;
        private System.Windows.Forms.RichTextBox rtbox_ProxyDetails;
        private System.Windows.Forms.Label lbl_ProxyServers;
        private System.Windows.Forms.ListBox lbox_ProxyServers;
        private System.Windows.Forms.Label lbl_ProxyDetails;
        private System.Windows.Forms.Button btn_UndoRemoveProxyServer;
        private System.Windows.Forms.Button btn_RemoveProxyServer;
        private System.Windows.Forms.Label lbl_AddNewProxyServer;
        private System.Windows.Forms.Button btn_AddNewProxyServer;
        private System.Windows.Forms.RichTextBox rtb_NewProxyServerDetails;
        private System.Windows.Forms.TextBox tb_NewProxyServerPort;
        private System.Windows.Forms.TextBox tb_NewProxyServerIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}