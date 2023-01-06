using InfiGrowth.Infra.Context;
using InfiGrowth.Infra.Repository;
using InfiGrowth.Infra.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InfiGrowth.Infra.Extensions
{
    public static class InfiGrowthInfraExtensions
    {
        public static IServiceCollection InfiGrowthInfraServiceRegistration(this IServiceCollection builder, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("InfiGrowthConnectionString");

            builder.AddDbContext<InfiGrowthContext>(options => {
                options.UseSqlServer(connectionString);
                options.EnableSensitiveDataLogging(true);
            });
            

            builder.AddScoped<DbContext, InfiGrowthContext>();
            builder.AddScoped<ICustomerRepository, CustomerRepository>();
   
            return builder;
        }

        public static IServiceCollection InfiGrowthInfraServiceRegistrationForBackground(this IServiceCollection builder, IConfiguration configuration)
        {
            //builder.ConfigureCoreInfra();

            var connectionString = configuration.GetConnectionString("InfiGrowthConnectionString");

            builder.AddDbContext<InfiGrowthContext>(
                options => options.UseSqlServer(connectionString),
                ServiceLifetime.Singleton);

            builder.AddTransient<ICustomerRepository, CustomerRepository>();
          
            return builder;

        }

    }
}
