using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System.IO;
using SendMail.Models;
using SendMail.Settings;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace SendMail.Services
{
    public class APIServices : IMailService
    {
        private readonly APISettings _APISettings;
        public APIServices(IOptions<APISettings> apisittings)
        {
            _APISettings = apisittings.Value;
        }
        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            var client = new SendGridClient(_APISettings.ApiKey);
            var from = new EmailAddress(_APISettings.from);
            var to = new EmailAddress(mailRequest.ToEmail);
            
            var msg = MailHelper.CreateSingleEmail(from, to, mailRequest.Subject, mailRequest.Body, null);
            var response = await client.SendEmailAsync(msg);
        }

    }
}
