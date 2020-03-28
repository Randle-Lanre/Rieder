using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using RiederBackend.Model;
using RiederBackend.ServiceInterface;

namespace RiederBackend.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class authtestController : ControllerBase
    {
        private IUserServices _userServices;

        public authtestController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] AuthenticateModel model)
        {
            var user = _userServices.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new {Message = "Username or password incorrect"});

            return Ok(user);



            
        }

        public IActionResult GetAll()
        {
            var users = _userServices.GetAll();

            return Ok(users);
        }
    }
}