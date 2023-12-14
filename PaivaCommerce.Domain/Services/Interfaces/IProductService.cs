using PaivaCommerce.Domain.Entities;

namespace PaivaCommerce.Domain.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync();
    }
}