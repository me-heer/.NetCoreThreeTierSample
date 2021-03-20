using Data;
using Data.Interface;
using Data.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterDataServices(configuration);
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return services;
        }
    }
}
