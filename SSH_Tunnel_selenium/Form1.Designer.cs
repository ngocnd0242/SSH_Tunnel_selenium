namespace SSH_Tunnel_selenium
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
            this.btnGet = new System.Windows.Forms.Button();
            this.textHtml = new System.Windows.Forms.RichTextBox();
            this.txip = new System.Windows.Forms.TextBox();
            this.txusername = new System.Windows.Forms.TextBox();
            this.txpwd = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(573, 102);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 178);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "Get HTML";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // textHtml
            // 
            this.textHtml.Location = new System.Drawing.Point(5, 102);
            this.textHtml.Name = "textHtml";
            this.textHtml.Size = new System.Drawing.Size(540, 178);
            this.textHtml.TabIndex = 1;
            this.textHtml.Text = "";
            // 
            // txip
            // 
            this.txip.Location = new System.Drawing.Point(68, 17);
            this.txip.Name = "txip";
            this.txip.Size = new System.Drawing.Size(100, 20);
            this.txip.TabIndex = 2;
            // 
            // txusername
            // 
            this.txusername.Location = new System.Drawing.Point(235, 17);
            this.txusername.Name = "txusername";
            this.txusername.Size = new System.Drawing.Size(39, 20);
            this.txusername.TabIndex = 3;
            this.txusername.Text = "www";
            // 
            // txpwd
            // 
            this.txpwd.Location = new System.Drawing.Point(355, 17);
            this.txpwd.Name = "txpwd";
            this.txpwd.PasswordChar = '*';
            this.txpwd.Size = new System.Drawing.Size(63, 20);
            this.txpwd.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(440, 16);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ip address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txpwd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txusername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 56);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SSH Config";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Disconnect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txUrl
            // 
            this.txUrl.Location = new System.Drawing.Point(59, 74);
            this.txUrl.Name = "txUrl";
            this.txUrl.Size = new System.Drawing.Size(461, 20);
            this.txUrl.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "URL:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 283);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txUrl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textHtml);
            this.Controls.Add(this.btnGet);
            this.Name = "Form1";
            this.Text = "SSH Tunnel Selenium";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RichTextBox textHtml;
        private System.Windows.Forms.TextBox txip;
        private System.Windows.Forms.TextBox txusername;
        private System.Windows.Forms.TextBox txpwd;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txUrl;
        private System.Windows.Forms.Label label4;
    }
}

