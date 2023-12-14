using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PaivaCommerce.Domain.Interfaces;
using PaivaCommerce.Infra.Data;
using PaivaCommerce.Infra.Repositories;

namespace PaivaCommerce.Infra
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfraDependency(this IServiceCollection services)
        {
            services.AddDbContext<PaivaCommerceDbContext>(options => options.UseSqlite("Data Source=PaivaCommerceDb.db"));
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}