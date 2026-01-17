using ecommerce_app.Dtos;
using ecommerce_app.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthenticateService _authenticateService;
        public AuthController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] LoginDto loginDto)
        {
            var token = _authenticateService.Authenticate(loginDto.Email, loginDto.Password);
            if(token==null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
    }
}
