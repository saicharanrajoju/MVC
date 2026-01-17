using ecommerce_app.Dtos;
using ecommerce_app.Models;
using ecommerce_app.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller {

        private readonly IUsersService _UsersService;
        public UsersController(IUsersService UsersService)
        {
            _UsersService = UsersService;
        }

        // api/users/
        [HttpGet]
        public ActionResult<IEnumerable<User>> Index()
        {
            return Ok(_UsersService.GetAll());
        }

        // api/users/:id
        [HttpGet("{id:int}")]
        public ActionResult<User> Get(int Id)
        {
            return Ok(_UsersService.Get(Id));
        }

        [HttpPost]
        public ActionResult<User> Create(CreateUserDto CreateUserDto)
        {
            return Ok(_UsersService.Create(CreateUserDto));
        }


        [HttpPatch("{id:int}")]
        public ActionResult<User> Update(int Id,[FromBody] JsonPatchDocument<UpdateUserDto> UpdateUserDto)
        {
            return Ok(_UsersService.Update(Id, UpdateUserDto));
        }

        [HttpDelete("{id:int}")]
        public ActionResult<User> Delete(int Id)
        {
            return Ok(_UsersService.Delete(Id));
        }
    }
}
