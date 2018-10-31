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
            this.lbl_Response = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_IP
            // 
            this.tb_IP.Location = new System.Drawing.Point(284, 88);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(265, 20);
            this.tb_IP.TabIndex = 0;
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Location = new System.Drawing.Point(243, 91);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(17, 13);
            this.lbl_IP.TabIndex = 1;
            this.lbl_IP.Text = "IP";
            // 
            // tb_proxyCode
            // 
            this.tb_proxyCode.Location = new System.Drawing.Point(284, 123);
            this.tb_proxyCode.Name = "tb_proxyCode";
            this.tb_proxyCode.Size = new System.Drawing.Size(265, 20);
            this.tb_proxyCode.TabIndex = 2;
            // 
            // proxyCode
            // 
            this.proxyCode.AutoSize = true;
            this.proxyCode.Location = new System.Drawing.Point(217, 126);
            this.proxyCode.Name = "proxyCode";
            this.proxyCode.Size = new System.Drawing.Size(61, 13);
            this.proxyCode.TabIndex = 3;
            this.proxyCode.Text = "Proxy Code";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(688, 606);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // lbl_Response
            // 
            this.lbl_Response.AutoSize = true;
            this.lbl_Response.Location = new System.Drawing.Point(284, 277);
            this.lbl_Response.Name = "lbl_Response";
            this.lbl_Response.Size = new System.Drawing.Size(55, 13);
            this.lbl_Response.TabIndex = 6;
            this.lbl_Response.Text = "Response";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 641);
            this.Controls.Add(this.lbl_Response);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.proxyCode);
            this.Controls.Add(this.tb_proxyCode);
            this.Controls.Add(this.lbl_IP);
            this.Controls.Add(this.tb_IP);
            this.Name = "Form1";
            this.Text = "Proxy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.TextBox tb_proxyCode;
        private System.Windows.Forms.Label proxyCode;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lbl_Response;
    }
}

