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
			this.button1 = new System.Windows.Forms.Button();
			this.panel_Connect.SuspendLayout();
			this.SuspendLayout();
			// 
			// tb_IP
			// 
			this.tb_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_IP.Location = new System.Drawing.Point(315, 64);
			this.tb_IP.Name = "tb_IP";
			this.tb_IP.Size = new System.Drawing.Size(265, 29);
			this.tb_IP.TabIndex = 0;
			// 
			// lbl_IP
			// 
			this.lbl_IP.AutoSize = true;
			this.lbl_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_IP.Location = new System.Drawing.Point(200, 67);
			this.lbl_IP.Name = "lbl_IP";
			this.lbl_IP.Size = new System.Drawing.Size(26, 24);
			this.lbl_IP.TabIndex = 1;
			this.lbl_IP.Text = "IP";
			// 
			// tb_proxyCode
			// 
			this.tb_proxyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_proxyCode.Location = new System.Drawing.Point(315, 99);
			this.tb_proxyCode.Name = "tb_proxyCode";
			this.tb_proxyCode.Size = new System.Drawing.Size(265, 29);
			this.tb_proxyCode.TabIndex = 2;
			// 
			// proxyCode
			// 
			this.proxyCode.AutoSize = true;
			this.proxyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.proxyCode.Location = new System.Drawing.Point(200, 102);
			this.proxyCode.Name = "proxyCode";
			this.proxyCode.Size = new System.Drawing.Size(109, 24);
			this.proxyCode.TabIndex = 3;
			this.proxyCode.Text = "Proxy Code";
			// 
			// btn_Connect
			// 
			this.btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Connect.Location = new System.Drawing.Point(603, 569);
			this.btn_Connect.Name = "btn_Connect";
			this.btn_Connect.Size = new System.Drawing.Size(108, 60);
			this.btn_Connect.TabIndex = 4;
			this.btn_Connect.Text = "Connect";
			this.btn_Connect.UseVisualStyleBackColor = true;
			this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
			// 
			// panel_Connect
			// 
			this.panel_Connect.Controls.Add(this.tb_IP);
			this.panel_Connect.Controls.Add(this.lbl_IP);
			this.panel_Connect.Controls.Add(this.tb_proxyCode);
			this.panel_Connect.Controls.Add(this.proxyCode);
			this.panel_Connect.Location = new System.Drawing.Point(12, 12);
			this.panel_Connect.Name = "panel_Connect";
			this.panel_Connect.Size = new System.Drawing.Size(870, 396);
			this.panel_Connect.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(752, 569);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(130, 60);
			this.button1.TabIndex = 8;
			this.button1.Text = "Disconnect";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(894, 641);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel_Connect);
			this.Controls.Add(this.btn_Connect);
			this.Name = "Form1";
			this.Text = "Proxy";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel_Connect.ResumeLayout(false);
			this.panel_Connect.PerformLayout();
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
	}
}

