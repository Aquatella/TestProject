using System.Collections.Generic;
using Hipernate_test.Models;
using Hipernate_test.Repository.Interfaces;
using NHibernate;


namespace Hipernate_test.Repository
{
    public class UserRepository : IUserRepository
    {
        public void AddUser(User user)
        {
            using (var session = HibernateHelper.GetCurrentSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(user);
                    transaction.Commit();
                }
            }
        }

        public void UpdateUser(User user) {
            using (var session = HibernateHelper.GetCurrentSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(user);
                    transaction.Commit();
                }
            }
        }

        public void DeleteUser(User user) {
            using (var session = HibernateHelper.GetCurrentSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(user);
                    transaction.Commit();
                }
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            IList<User> list;
            using (var session = HibernateHelper.GetCurrentSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    ICriteria criteria = session.CreateCriteria<User>();
                    list = criteria.List<User>();
                    transaction.Commit();
                }
            }
            return list;
        }

        public User GetUser(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
