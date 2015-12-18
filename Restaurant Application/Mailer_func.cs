using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Application
{
    class Mailer_func
    {
        public void SendEmail(String ToEmail, String Subj, string Message)
        {
            string email = Microsoft.VisualBasic.Interaction.InputBox("Enter your Gmail: ", "Mail configuration", "", 150, 150);
            string pass = Microsoft.VisualBasic.Interaction.InputBox("Enter your Gmail oassword(\nN.B: We are not store your password.\nIt's use for mail authonication): ", "Mail configuration- Pass", "", 150, 150);
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(email);
                mail.To.Add(ToEmail);
                mail.Subject = Subj;
                mail.Body = Message;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(email, pass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void SendEmail_From(String Subj, string Message)
        {
            string email = Microsoft.VisualBasic.Interaction.InputBox("Enter your Gmail: ", "Mail configuration", "", 150, 150);
            string pass = Microsoft.VisualBasic.Interaction.InputBox("Enter your Gmail oassword(\nN.B: We are not store your password.\nIt's use for mail authonication): ", "Mail configuration- Pass", "", 150, 150);
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(email);
                mail.To.Add("mfislam_2323@yahoo.com");
                mail.Subject = Subj;
                mail.Body = Message;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(email, pass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
