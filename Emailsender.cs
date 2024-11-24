using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EcommProject_1155.Utility
{
    public class Emailsender : IEmailSender
    {
        private EmailSettings _settings { get; }
        public Emailsender(IOptions<EmailSettings> emailSettings)
        {
            _settings = emailSettings.Value;
        }

        public async Task Execute(string email, string subject, string message)
        {
            try
            {
                string toEmail = string.IsNullOrEmpty(email) ? _settings.ToEmail : email;
                MailMessage mailMessage = new MailMessage()
                {
                    From = new MailAddress(_settings.UsernameEmail, "My Email Name"),
                };
                mailMessage.To.Add(toEmail);
                if (!string.IsNullOrEmpty(_settings.CcEmail))
                {
                    mailMessage.CC.Add(_settings.CcEmail);
                }
                mailMessage.To.Add(_settings.CcEmail);
                mailMessage.To.Add(toEmail);
                mailMessage.Subject = "Shopping App: " + subject;
                mailMessage.Body = message;
                mailMessage.IsBodyHtml = true;
                mailMessage.Priority = MailPriority.High;

                using (SmtpClient smtp = new SmtpClient(_settings.PrmiaryDomain, _settings.PrimaryPort))
                {
                    smtp.Credentials = new NetworkCredential(_settings.UsernameEmail, _settings.UsernamePassword);
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(mailMessage);
                }
            }
            catch (Exception ex)
            {

                string str = ex.Message;
            }
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(email, subject, htmlMessage);
        }
    }

}