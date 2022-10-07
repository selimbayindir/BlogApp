using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ConfigurationsJson
{ 
    public static class ServiceBuilder
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<BlogContext>(options =>
            {
                options.UseSqlServer(Configuration.ConnectionString);
                options.EnableSensitiveDataLogging(true);


        });
    }
    }
}
