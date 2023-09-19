using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Cheque
{
    public partial class SendCode : Form
    {
        string randomcode;
        public static string to;
        public SendCode()
        {
            InitializeComponent();
        }

        private void sendcodebacklinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }

        private void sendcodebutton_Click(object sender, EventArgs e)
        {
            string from, pass, messagebody;
            Random rand = new Random();
            randomcode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (emailtextBox.Text).ToString();
            from = "nibal.tasnim.42891@gmail.com";
            pass = "nibal1997";
            messagebody = $"Your Reset Code is {randomcode}";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messagebody;
            message.Subject = "Password Reset Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show(" Code Successfully Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void verifybutton_Click(object sender, EventArgs e)
        {
            if (randomcode == (endtercodetextBox.Text).ToString())
            {
                to = emailtextBox.Text;
                Reset r = new Reset();
                r.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Wrong Code! ");
            }
        }
    }
}
