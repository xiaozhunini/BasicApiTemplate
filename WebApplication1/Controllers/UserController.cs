using Microsoft.AspNetCore.Mvc;
using MyWeb.Modles;
using MyWeb.Service.IService;

namespace MyWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;


        public UserController(IUserService userService)
        {
            _userService = userService;

        }
        [HttpGet]
        public ActionResult<User> userAll()
        {
            return _userService.userList();
        }
    }
}
