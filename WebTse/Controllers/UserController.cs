using Microsoft.AspNetCore.Mvc;
using WebTse.Modules;
using WebTse.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebTse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserService userService = new();
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User>? Get()
        {
            return userService.Get();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User? Get(int id)
        {
            return userService.Get(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] User value)
        {
            userService.Post(value);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User value)
        {
            userService.Put(id, value);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            userService.Delete(id);
        }
    }
}
