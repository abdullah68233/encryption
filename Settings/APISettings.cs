using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SendMail.Settings
{
    public class APISettings
    {
        public const string APISettingsName = "SendGridAPI";
        public string ApiKey { get; set; }
        public string from { get; set; }
    }
}
