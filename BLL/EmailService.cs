using System;
using System.Net;
using System.Net.Mail;

namespace BLL
{
    public class EmailService
    {
        public void SendEmail(string to, string subject, string content)
        {
            string from = "52200089@student.tdtu.edu.vn";
            string pass = "baotran53";

            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.From = new MailAddress(from);
            mail.Subject = subject;
            mail.Body = content;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gửi email thất bại: {ex.Message}");
            }
        }
    }
}
