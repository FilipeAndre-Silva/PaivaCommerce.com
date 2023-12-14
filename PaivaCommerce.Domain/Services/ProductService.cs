using PaivaCommerce.Domain.Entities;
using PaivaCommerce.Domain.Interfaces;
using PaivaCommerce.Domain.Services.Interfaces;

namespace PaivaCommerce.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}