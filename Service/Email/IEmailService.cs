using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Email
{
    interface IEmailService
    {
        void SendEmailToRecipient(string recipient, string title, string body);
        void SendEmailToRecipients(IEnumerable<string> recipients, string title, string body);

        void SendEmailToAllMembers(string title, string body);
    }
}
