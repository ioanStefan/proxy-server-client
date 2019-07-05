namespace proxy_server_client
{
    partial class Test
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
            this.cb_ProxyServers = new System.Windows.Forms.ComboBox();
            this.tb_SecretKey = new System.Windows.Forms.TextBox();
            this.rtb_PlainText = new System.Windows.Forms.RichTextBox();
            this.rtb_ResponseDecrypted = new System.Windows.Forms.RichTextBox();
            this.rtb_ResponseEncrypted = new System.Windows.Forms.RichTextBox();
            this.rtb_Encrypted = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Test = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_ResponseTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_ProxyServers
            // 
            this.cb_ProxyServers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ProxyServers.FormattingEnabled = true;
            this.cb_ProxyServers.Location = new System.Drawing.Point(179, 12);
            this.cb_ProxyServers.Name = "cb_ProxyServers";
            this.cb_ProxyServers.Size = new System.Drawing.Size(384, 27);
            this.cb_ProxyServers.TabIndex = 0;
            // 
            // tb_SecretKey
            // 
            this.tb_SecretKey.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SecretKey.Location = new System.Drawing.Point(179, 45);
            this.tb_SecretKey.Name = "tb_SecretKey";
            this.tb_SecretKey.ReadOnly = true;
            this.tb_SecretKey.Size = new System.Drawing.Size(384, 26);
            this.tb_SecretKey.TabIndex = 1;
            // 
            // rtb_PlainText
            // 
            this.rtb_PlainText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_PlainText.Location = new System.Drawing.Point(179, 77);
            this.rtb_PlainText.Name = "rtb_PlainText";
            this.rtb_PlainText.Size = new System.Drawing.Size(384, 96);
            this.rtb_PlainText.TabIndex = 2;
            this.rtb_PlainText.Text = "";
            // 
            // rtb_ResponseDecrypted
            // 
            this.rtb_ResponseDecrypted.Location = new System.Drawing.Point(179, 576);
            this.rtb_ResponseDecrypted.Name = "rtb_ResponseDecrypted";
            this.rtb_ResponseDecrypted.ReadOnly = true;
            this.rtb_ResponseDecrypted.Size = new System.Drawing.Size(384, 96);
            this.rtb_ResponseDecrypted.TabIndex = 3;
            this.rtb_ResponseDecrypted.Text = "";
            // 
            // rtb_ResponseEncrypted
            // 
            this.rtb_ResponseEncrypted.Location = new System.Drawing.Point(179, 463);
            this.rtb_ResponseEncrypted.Name = "rtb_ResponseEncrypted";
            this.rtb_ResponseEncrypted.ReadOnly = true;
            this.rtb_ResponseEncrypted.Size = new System.Drawing.Size(384, 96);
            this.rtb_ResponseEncrypted.TabIndex = 4;
            this.rtb_ResponseEncrypted.Text = "";
            // 
            // rtb_Encrypted
            // 
            this.rtb_Encrypted.Location = new System.Drawing.Point(179, 348);
            this.rtb_Encrypted.Name = "rtb_Encrypted";
            this.rtb_Encrypted.ReadOnly = true;
            this.rtb_Encrypted.Size = new System.Drawing.Size(384, 96);
            this.rtb_Encrypted.TabIndex = 5;
            this.rtb_Encrypted.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Proxy Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Secret key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Plain text";
            // 
            // btn_Test
            // 
            this.btn_Test.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Test.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Test.Location = new System.Drawing.Point(488, 179);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(75, 48);
            this.btn_Test.TabIndex = 9;
            this.btn_Test.Text = "Test";
            this.btn_Test.UseVisualStyleBackColor = false;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Results";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Encrypted text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Response encrypted";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 575);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Response decrypted";
            // 
            // lbl_ResponseTime
            // 
            this.lbl_ResponseTime.AutoSize = true;
            this.lbl_ResponseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ResponseTime.Location = new System.Drawing.Point(12, 203);
            this.lbl_ResponseTime.Name = "lbl_ResponseTime";
            this.lbl_ResponseTime.Size = new System.Drawing.Size(149, 24);
            this.lbl_ResponseTime.TabIndex = 14;
            this.lbl_ResponseTime.Text = "Response Time:";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 684);
            this.Controls.Add(this.lbl_ResponseTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_Encrypted);
            this.Controls.Add(this.rtb_ResponseEncrypted);
            this.Controls.Add(this.rtb_ResponseDecrypted);
            this.Controls.Add(this.rtb_PlainText);
            this.Controls.Add(this.tb_SecretKey);
            this.Controls.Add(this.cb_ProxyServers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Test";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_ProxyServers;
        private System.Windows.Forms.TextBox tb_SecretKey;
        private System.Windows.Forms.RichTextBox rtb_PlainText;
        private System.Windows.Forms.RichTextBox rtb_ResponseDecrypted;
        private System.Windows.Forms.RichTextBox rtb_ResponseEncrypted;
        private System.Windows.Forms.RichTextBox rtb_Encrypted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_ResponseTime;
    }
}