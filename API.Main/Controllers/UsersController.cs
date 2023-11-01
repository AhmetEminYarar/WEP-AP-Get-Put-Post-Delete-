using API.Main.Fake;
using API.Main.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Main.Controllers
{
    [Route("api/[Controller]")]
    public class UsersController : ControllerBase
    {
        
        private List<User> _users = Fakedata.GetUsers(100);
        [HttpGet]
        public List<User> Get()
        {
            return _users;
        }
        [HttpGet("{ID}")]
        public User GetUser(int ID)
        {
            var user = _users.FirstOrDefault(u => u.ID == ID);
            return user;
        }
        [HttpPost]
        public User Post([FromBody] User user)
        { 
            _users.Add(user);
            return user;
        }
        [HttpPut]
        public User Put([FromBody] User user)
        {
            var Edituser= _users.FirstOrDefault(u => u.ID==user.ID);
            Edituser.Firstname=user.Firstname;
            Edituser.Lastname=user.Lastname;
            Edituser.Address = user.Address;
            return user;
        }
        [HttpDelete]
        public void Delete(int ID)
        {
            var deleteuser = _users.FirstOrDefault(u => u.ID == ID);
            _users.Remove(deleteuser);
        }






    }
}
