using PaivaCommerce.Domain.Entities;

namespace PaivaCommerce.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
    }
}