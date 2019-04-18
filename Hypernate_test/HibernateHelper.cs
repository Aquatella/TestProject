using NHibernate;
using NHibernate.Cfg;

namespace Hipernate_test
{
    public sealed class HibernateHelper
        {
            private static ISessionFactory SessionFactory;

            private static void OpenSession()
            {
                var configuration = new Configuration();
                configuration.Configure();
                SessionFactory = configuration.BuildSessionFactory();
            }

            public static ISession GetCurrentSession()
            {
                if (SessionFactory == null)
                OpenSession();
                return SessionFactory.OpenSession();
            }

            public static void CloseSessionFactory()
            {
                if (SessionFactory != null)
                    SessionFactory.Close();
            }
        
    
}
}
