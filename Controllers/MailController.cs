using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SendMail.Models;
using SendMail.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SendMail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailService mailService;
        private readonly IConfiguration configuration;
        public MailController(IMailService mailService, IConfiguration Configuration)
        {
            this.mailService = mailService;
            configuration = Configuration;
        }
        [HttpPost("send")]
        public async Task<IActionResult> SendMail([FromForm] MailRequest request)
        {
            try
            {
                await mailService.SendEmailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        [HttpGet("hamda")]
        public void test()
        {
            try
            {
                while(true)
                {
                    try
                    {
                        pass t = new pass(configuration);
                        t.jsonmethod();
                    }
                    catch (Exception ex)
                    {
                    }
                }
           
            }
            catch (Exception ex)
            {
                
            }

        }
    }
}
