using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SendMail.Controllers
{
    public class EncryptionController : Controller
    {
                
        [HttpGet("Encrypt")]
        public IActionResult Encrypt(string realPassword)
        {
            try
            {
               return Ok(pass.Encrypt(realPassword));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }
}
