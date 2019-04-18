using Hipernate_test.Models;
using System.Collections;
using System.Collections.Generic;

namespace Hipernate_test.Repository.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUser(int id);
        void AddUser(User user);

        void UpdateUser(User user);

        void DeleteUser(User user);
    }
}
