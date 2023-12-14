using Microsoft.Extensions.DependencyInjection;
using PaivaCommerce.Domain.Services;
using PaivaCommerce.Domain.Services.Interfaces;

namespace PaivaCommerce.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDomainServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}