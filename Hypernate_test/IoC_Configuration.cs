using Autofac;
using Hipernate_test.Repository;
using Hipernate_test.Repository.Interfaces;

namespace Hipernate_test
{
    public class IoC_Configuration
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.Build();
        }
    }
}
