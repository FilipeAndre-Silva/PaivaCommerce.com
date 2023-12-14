using Microsoft.EntityFrameworkCore;
using PaivaCommerce.Domain.Entities;
using PaivaCommerce.Domain.Interfaces;
using PaivaCommerce.Infra.Data;

namespace PaivaCommerce.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly PaivaCommerceDbContext _context;
        public ProductRepository(PaivaCommerceDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}