using Microsoft.AspNetCore.Mvc;
using MyWeb.Modles;
using MyWeb.Service.IService;
using WebApplication1.Config;

namespace MyWeb.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;


        public UserController(IUserService userService)
        {
            _userService = userService;

        }
        [HttpGet]
        public ActionResult<int> userAll()
        {
            DataDemo dataDemo = new DataDemo();
            dataDemo.DataDemoText();
            return _userService.userList();
        }

                
    }
}
