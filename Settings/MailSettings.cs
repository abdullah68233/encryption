using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SendMail.Settings
{
    public class MailSettings
    {
        public const string mailProviderSettings = "Mail1Settings";
        public string Mail { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
    }
}
