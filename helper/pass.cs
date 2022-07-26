using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SendGrid.Helpers.Mail;
using SendMail;

namespace SendMail
{
    public class pass 
    {
        public IConfiguration Configuration { get; }
        public pass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        List<MailSettings> people = new List<MailSettings>();
        public static string Password { get; set; }
        public  void jsonmethod() 
        {
         
            var s = Configuration.GetSection("MailSettings");

        }
        public static string Decrypted(string password)
        {
            StringBuilder decrypted = new StringBuilder();
            for (int i = 0; i < password.Length; i++)
            {



                decrypted.Append((char)((int)password[i] - 3));

            }
            return decrypted.ToString();

        }
        public static string Encrypt(string password)
        {

            string encrypted = "";

            for (int i = 0; i < password.Length; i++)
            {



                encrypted += (char)((int)password[i] + 3);

                } 
                return encrypted;
        }
        }

    
}

    
        
    

