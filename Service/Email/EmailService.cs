using System;
using System.Collections.Generic;
using SendGrid;
using System.Net.Mail;

namespace Service.Email
{
    class EmailService : IEmailService
    {
        private string _apiKey;
        private MailAddress _senderEmail;
        public void SendEmailToAllMembers(string title, string body)
        {
            throw new NotImplementedException();
        }

        public void SendEmailToRecipient(string recipient, string title, string body)
        {
            SendEmailToRecipients(new List<string> { recipient }, title, body);
        }

        public void SendEmailToRecipients(IEnumerable<string> recipients, string title, string body)
        {
            var message = new SendGridMessage();
            message.AddTo(recipients);
            message.From = _senderEmail;
            message.Subject = title;
            message.Text = body;
            var service = new Web(_apiKey);
        }
    }
}
