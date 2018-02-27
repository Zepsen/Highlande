using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Highlande.BLL.Interfaces;
using Highlande.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace Highlande.WEB.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        // GET api/user
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _service.GetAllUsers();
        }

        // GET api/user/5
        [HttpGet("{id}")]
        public async Task<User> Get(string id)
        {
            return await _service.GetUser(id);
        }

        // POST api/user
        [HttpPost]
        public async Task Post(User user)
        {
            await _service.InsertUser(user);
        }

        // PUT api/user/5
        [HttpPut("{id}")]
        public async Task Put([FromBody]User user)
        {
            await _service.UpdateUser(user);
        }

        // DELETE api/user/5
        [HttpDelete("{id}")]
        public async Task Delete([FromBody]User user)
        {
            await _service.DeleteUser(user);
        }
    }
}
