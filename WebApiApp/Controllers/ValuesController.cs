using Hipernate_test.Models;
using Hipernate_test.Repository.Interfaces;
using System.Collections.Generic;
using System.Web.Http;
using WebApiApp.Models;

namespace WebApiApp.Controllers
{
    public class ValuesController : ApiController
    {
        private IUserRepository _userRepository;
        public ValuesController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetUser(int id)
        {
            return _userRepository.GetUser(id);
        }

        [HttpPost]
        public void CreateUser([FromBody]User user)
        {
            _userRepository.AddUser(user);
        }

        [HttpPut]
        public void EditUser(int id, [FromBody]User user)
        {
            _userRepository.UpdateUser(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(new User { Id = id });
        }
    }
}

