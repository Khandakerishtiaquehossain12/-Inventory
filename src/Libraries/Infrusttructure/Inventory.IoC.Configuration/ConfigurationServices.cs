using Microsoft.Extensions.DependencyInjection;
using Inventory.Infrastructure.DatabaseContex;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Inventory.Core.Mapper;
using Inventory.Core;
using Inventory.Repositories.Interface;
using Inventory.Repositiories.Base;

namespace Inventory.IoC.Configuration
{
    public static class ConfigurationServices

    {
        public static IServiceCollection AddExtention(this IServiceCollection services, IConfiguration configuration)
        {
            {
                services.AddDbContext<InventoryDbContext>(option => option.UseSqlServer(configuration.GetConnectionString("Conn")));
                services.AddAutoMapper(typeof(CommonMapper).Assembly);

                services.AddTransient<IInventoryRepository, InventoryRepository>();



                services.AddAutoMapper(typeof(CommonMapper).Assembly);
                services.AddMediatR(options => options.RegisterServicesFromAssemblies(typeof(ICore).Assembly));


                return services;
            }
        }

    }
}


