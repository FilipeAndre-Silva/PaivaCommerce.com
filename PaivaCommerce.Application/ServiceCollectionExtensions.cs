using Microsoft.Extensions.DependencyInjection;
using PaivaCommerce.Application.Interfaces;
using PaivaCommerce.Application.Services;
using PaivaCommerce.Domain;
using PaivaCommerce.Infra;

namespace PaivaCommerce.Application
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationService(this IServiceCollection services)
        {
            services.AddInfraDependency();
            services.AddDomainServiceDependency();

            services.AddScoped<IProductApplicationService, ProductApplicationService>();
        }
    }
}