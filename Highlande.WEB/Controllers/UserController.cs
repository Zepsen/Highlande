using System.Collections.Generic;
using System.Threading.Tasks;
using Highlande.BLL.Interfaces;
using Highlande.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

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
        public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2" };
        }

        // GET api/user/5
        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            return await _service.GetUser();
        }

        // POST api/user
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/user/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/user/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
