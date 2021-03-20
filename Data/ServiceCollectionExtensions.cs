using Data.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EmpContext>(o => o.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<EmpContext>()
                .AddDefaultTokenProviders();

            return services;
        }
    }
}
