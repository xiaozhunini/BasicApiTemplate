using MyWeb.Modles;
using MyWeb.Service.IService;

namespace MyWeb.Service
{
    public class UserService : IUserService
    {
        public User userList()
        {

            return new User();
        }
    }
}
