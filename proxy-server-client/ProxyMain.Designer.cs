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
            this.btn_OpenProxyConnection = new System.Windows.Forms.Button();
            this.btn_CloseProxyConnection = new System.Windows.Forms.Button();
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
            this.panel_Home.Controls.Add(this.btn_OpenProxyConnection);
            this.panel_Home.Controls.Add(this.btn_CloseProxyConnection);
            this.panel_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Home.Location = new System.Drawing.Point(0, 0);
            this.panel_Home.Name = "panel_Home";
            this.panel_Home.Size = new System.Drawing.Size(592, 690);
            this.panel_Home.TabIndex = 9;
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
            this.btn_CloseProxyConnection.Location = new System.Drawing.Point(24, 104);
            this.btn_CloseProxyConnection.Name = "btn_CloseProxyConnection";
            this.btn_CloseProxyConnection.Size = new System.Drawing.Size(116, 60);
            this.btn_CloseProxyConnection.TabIndex = 8;
            this.btn_CloseProxyConnection.Text = "Close proxy connection";
            this.btn_CloseProxyConnection.UseVisualStyleBackColor = false;
            this.btn_CloseProxyConnection.Click += new System.EventHandler(this.btn_CloseProxyConnection_Click);
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
    }
}