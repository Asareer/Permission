using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace NewP.Services
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var fromMail = "asareerassam@gmail.com";
            var fromPassword = "776050187";
            var message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = subject;
            message.To.Add(email);
            message.Body =$"<html><body>{htmlMessage}</body></html>";
            message.IsBodyHtml = true;
            var smtpClient = new SmtpClient("smtp-mail.Gmail.com")
            {
                Port = 465,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true
            };
            smtpClient.Send(message); 
        }
    }
}
