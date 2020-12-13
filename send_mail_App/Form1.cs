using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace send_mail_App
{
    public partial class Form1 : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login = new NetworkCredential(textUserName.Text, textPassword.Text);
            client = new SmtpClient(textSMTP.Text);
            client.Port = Convert.ToInt32(textPort.Text);
            client.EnableSsl = checkBox1.Checked;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(textUserName.Text + textSMTP.Text.Replace("smtp.","@"),"Madhu",Encoding.UTF8) };
            msg.To.Add(new MailAddress(textTo.Text));

            if (!string.IsNullOrEmpty(textCc.Text))
                msg.To.Add(new MailAddress(textCc.Text));

            msg.Subject = textSubject.Text;
            msg.Body = textMessage.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += Client_SendCompleted;
        }

        private void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send cancelled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            
            {
                MessageBox.Show("Your messsage has been sent successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
