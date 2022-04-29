using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebTse.Modules;
using WebTse.Services;

namespace WebTse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignController : ControllerBase
    {
        UserService userService = new();
        [HttpGet]
        public int SignIn([FromBody] User user)
        {
            return userService.SignIn(user);
        }

        public int SignUp([FromBody] User user)
        {
            return 0;
        }
    }
}
