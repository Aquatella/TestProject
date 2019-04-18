using Hipernate_test.Models;
using Hipernate_test.Repository;
using NHibernate;
using System.Collections.Generic;

namespace Hipernate_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestHipernate();
        }

        public static void TestHipernate()
        {
            ISession session = HibernateHelper.GetCurrentSession();
            using (session.BeginTransaction())
            {
                ICriteria criteria = session.CreateCriteria<User>();
                IList<User> list = criteria.List<User>();

                session.Transaction.Commit();
            }
            session.Close();

            var rep = new UserRepository();

            rep.AddUser(new User { Name = "Name", Password = "Pass" });
            rep.UpdateUser(new User { Id = 2, Name = "Name", Password = "Pass1" });
        }
    }
}
