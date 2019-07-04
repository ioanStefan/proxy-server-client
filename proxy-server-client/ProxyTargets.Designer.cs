namespace proxy_server_client
{
    partial class ProxyTargets
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_ProxyServers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ProxyTargets = new System.Windows.Forms.ListBox();
            this.lbl_ProxyDetails = new System.Windows.Forms.Label();
            this.tb_tdPort = new System.Windows.Forms.TextBox();
            this.tb_tdHost = new System.Windows.Forms.TextBox();
            this.rtb_Details = new System.Windows.Forms.RichTextBox();
            this.btn_UpdateProxyTarget = new System.Windows.Forms.Button();
            this.btn_RemoveProxyTarget = new System.Windows.Forms.Button();
            this.rtb_NewTargetDetails = new System.Windows.Forms.RichTextBox();
            this.tb_NewTargetPort = new System.Windows.Forms.TextBox();
            this.tb_NewTargetHost = new System.Windows.Forms.TextBox();
            this.cb_NewTargetProxyServer = new System.Windows.Forms.ComboBox();
            this.btn_AddNewTarget = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proxy Servers";
            // 
            // cb_ProxyServers
            // 
            this.cb_ProxyServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ProxyServers.FormattingEnabled = true;
            this.cb_ProxyServers.Location = new System.Drawing.Point(12, 31);
            this.cb_ProxyServers.Name = "cb_ProxyServers";
            this.cb_ProxyServers.Size = new System.Drawing.Size(265, 32);
            this.cb_ProxyServers.TabIndex = 29;
            this.cb_ProxyServers.SelectedIndexChanged += new System.EventHandler(this.cb_ProxyServers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Proxy Targets";
            // 
            // lb_ProxyTargets
            // 
            this.lb_ProxyTargets.FormattingEnabled = true;
            this.lb_ProxyTargets.Location = new System.Drawing.Point(12, 101);
            this.lb_ProxyTargets.Name = "lb_ProxyTargets";
            this.lb_ProxyTargets.Size = new System.Drawing.Size(265, 186);
            this.lb_ProxyTargets.TabIndex = 29;
            this.lb_ProxyTargets.SelectedIndexChanged += new System.EventHandler(this.lb_ProxyTargets_SelectedIndexChanged);
            // 
            // lbl_ProxyDetails
            // 
            this.lbl_ProxyDetails.AutoSize = true;
            this.lbl_ProxyDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProxyDetails.Location = new System.Drawing.Point(289, 9);
            this.lbl_ProxyDetails.Name = "lbl_ProxyDetails";
            this.lbl_ProxyDetails.Size = new System.Drawing.Size(61, 19);
            this.lbl_ProxyDetails.TabIndex = 31;
            this.lbl_ProxyDetails.Text = "Details";
            // 
            // tb_tdPort
            // 
            this.tb_tdPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tdPort.Location = new System.Drawing.Point(293, 66);
            this.tb_tdPort.Name = "tb_tdPort";
            this.tb_tdPort.Size = new System.Drawing.Size(265, 29);
            this.tb_tdPort.TabIndex = 34;
            // 
            // tb_tdHost
            // 
            this.tb_tdHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tdHost.Location = new System.Drawing.Point(293, 31);
            this.tb_tdHost.Name = "tb_tdHost";
            this.tb_tdHost.ReadOnly = true;
            this.tb_tdHost.Size = new System.Drawing.Size(265, 29);
            this.tb_tdHost.TabIndex = 33;
            // 
            // rtb_Details
            // 
            this.rtb_Details.Location = new System.Drawing.Point(293, 101);
            this.rtb_Details.Name = "rtb_Details";
            this.rtb_Details.Size = new System.Drawing.Size(265, 186);
            this.rtb_Details.TabIndex = 32;
            this.rtb_Details.Text = "";
            // 
            // btn_UpdateProxyTarget
            // 
            this.btn_UpdateProxyTarget.BackColor = System.Drawing.Color.DarkGray;
            this.btn_UpdateProxyTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateProxyTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateProxyTarget.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateProxyTarget.Location = new System.Drawing.Point(448, 293);
            this.btn_UpdateProxyTarget.Name = "btn_UpdateProxyTarget";
            this.btn_UpdateProxyTarget.Size = new System.Drawing.Size(110, 45);
            this.btn_UpdateProxyTarget.TabIndex = 37;
            this.btn_UpdateProxyTarget.Text = "Update";
            this.btn_UpdateProxyTarget.UseVisualStyleBackColor = false;
            this.btn_UpdateProxyTarget.Click += new System.EventHandler(this.btn_UpdateProxyTarget_Click);
            // 
            // btn_RemoveProxyTarget
            // 
            this.btn_RemoveProxyTarget.BackColor = System.Drawing.Color.Tomato;
            this.btn_RemoveProxyTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveProxyTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveProxyTarget.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveProxyTarget.Location = new System.Drawing.Point(332, 293);
            this.btn_RemoveProxyTarget.Name = "btn_RemoveProxyTarget";
            this.btn_RemoveProxyTarget.Size = new System.Drawing.Size(110, 45);
            this.btn_RemoveProxyTarget.TabIndex = 36;
            this.btn_RemoveProxyTarget.Text = "Remove";
            this.btn_RemoveProxyTarget.UseVisualStyleBackColor = false;
            // 
            // rtb_NewTargetDetails
            // 
            this.rtb_NewTargetDetails.Location = new System.Drawing.Point(177, 510);
            this.rtb_NewTargetDetails.Name = "rtb_NewTargetDetails";
            this.rtb_NewTargetDetails.Size = new System.Drawing.Size(265, 162);
            this.rtb_NewTargetDetails.TabIndex = 40;
            this.rtb_NewTargetDetails.Text = "";
            // 
            // tb_NewTargetPort
            // 
            this.tb_NewTargetPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NewTargetPort.Location = new System.Drawing.Point(177, 475);
            this.tb_NewTargetPort.Name = "tb_NewTargetPort";
            this.tb_NewTargetPort.Size = new System.Drawing.Size(265, 29);
            this.tb_NewTargetPort.TabIndex = 39;
            // 
            // tb_NewTargetHost
            // 
            this.tb_NewTargetHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NewTargetHost.Location = new System.Drawing.Point(177, 440);
            this.tb_NewTargetHost.Name = "tb_NewTargetHost";
            this.tb_NewTargetHost.Size = new System.Drawing.Size(265, 29);
            this.tb_NewTargetHost.TabIndex = 38;
            // 
            // cb_NewTargetProxyServer
            // 
            this.cb_NewTargetProxyServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_NewTargetProxyServer.FormattingEnabled = true;
            this.cb_NewTargetProxyServer.Location = new System.Drawing.Point(177, 402);
            this.cb_NewTargetProxyServer.Name = "cb_NewTargetProxyServer";
            this.cb_NewTargetProxyServer.Size = new System.Drawing.Size(265, 32);
            this.cb_NewTargetProxyServer.TabIndex = 41;
            // 
            // btn_AddNewTarget
            // 
            this.btn_AddNewTarget.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_AddNewTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNewTarget.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewTarget.ForeColor = System.Drawing.Color.White;
            this.btn_AddNewTarget.Location = new System.Drawing.Point(453, 627);
            this.btn_AddNewTarget.Name = "btn_AddNewTarget";
            this.btn_AddNewTarget.Size = new System.Drawing.Size(110, 45);
            this.btn_AddNewTarget.TabIndex = 29;
            this.btn_AddNewTarget.Text = "ADD";
            this.btn_AddNewTarget.UseVisualStyleBackColor = false;
            this.btn_AddNewTarget.Click += new System.EventHandler(this.btn_AddNewTarget_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Add new proxy target";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Target Port *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Details *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Proxy Hostname *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Target Hostname *";
            // 
            // ProxyTargets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 684);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_AddNewTarget);
            this.Controls.Add(this.cb_NewTargetProxyServer);
            this.Controls.Add(this.rtb_NewTargetDetails);
            this.Controls.Add(this.tb_NewTargetPort);
            this.Controls.Add(this.tb_NewTargetHost);
            this.Controls.Add(this.btn_UpdateProxyTarget);
            this.Controls.Add(this.btn_RemoveProxyTarget);
            this.Controls.Add(this.tb_tdPort);
            this.Controls.Add(this.tb_tdHost);
            this.Controls.Add(this.rtb_Details);
            this.Controls.Add(this.lbl_ProxyDetails);
            this.Controls.Add(this.lb_ProxyTargets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_ProxyServers);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(591, 723);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(591, 723);
            this.Name = "ProxyTargets";
            this.ShowIcon = false;
            this.Text = "Proxy Targets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_ProxyServers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_ProxyTargets;
        private System.Windows.Forms.Label lbl_ProxyDetails;
        private System.Windows.Forms.TextBox tb_tdPort;
        private System.Windows.Forms.TextBox tb_tdHost;
        private System.Windows.Forms.RichTextBox rtb_Details;
        private System.Windows.Forms.Button btn_UpdateProxyTarget;
        private System.Windows.Forms.Button btn_RemoveProxyTarget;
        private System.Windows.Forms.RichTextBox rtb_NewTargetDetails;
        private System.Windows.Forms.TextBox tb_NewTargetPort;
        private System.Windows.Forms.TextBox tb_NewTargetHost;
        private System.Windows.Forms.ComboBox cb_NewTargetProxyServer;
        private System.Windows.Forms.Button btn_AddNewTarget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}