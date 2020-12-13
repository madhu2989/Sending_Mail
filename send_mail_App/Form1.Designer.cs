namespace send_mail_App
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textTo = new System.Windows.Forms.TextBox();
            this.textCc = new System.Windows.Forms.TextBox();
            this.textSubject = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.textSMTP = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Message:";
            // 
            // textTo
            // 
            this.textTo.Location = new System.Drawing.Point(182, 28);
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(317, 20);
            this.textTo.TabIndex = 0;
            // 
            // textCc
            // 
            this.textCc.Location = new System.Drawing.Point(182, 57);
            this.textCc.Name = "textCc";
            this.textCc.Size = new System.Drawing.Size(317, 20);
            this.textCc.TabIndex = 1;
            // 
            // textSubject
            // 
            this.textSubject.Location = new System.Drawing.Point(182, 84);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(317, 20);
            this.textSubject.TabIndex = 2;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(182, 111);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(317, 128);
            this.textMessage.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textSMTP);
            this.groupBox1.Controls.Add(this.textPort);
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Controls.Add(this.textUserName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(182, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 136);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login informtion";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(286, 387);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Send..!";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Port:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "SMTP:";
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(104, 21);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(201, 20);
            this.textUserName.TabIndex = 0;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(104, 47);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(201, 20);
            this.textPassword.TabIndex = 1;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(104, 73);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(63, 20);
            this.textPort.TabIndex = 2;
            this.textPort.Text = "587";
            // 
            // textSMTP
            // 
            this.textSMTP.Location = new System.Drawing.Point(104, 99);
            this.textSMTP.Name = "textSMTP";
            this.textSMTP.Size = new System.Drawing.Size(132, 20);
            this.textSMTP.TabIndex = 3;
            this.textSMTP.Text = "smtp.gmail.com";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(194, 79);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "SSL";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.textCc);
            this.Controls.Add(this.textTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sendind Mail App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTo;
        private System.Windows.Forms.TextBox textCc;
        private System.Windows.Forms.TextBox textSubject;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textSMTP;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSend;
    }
}

