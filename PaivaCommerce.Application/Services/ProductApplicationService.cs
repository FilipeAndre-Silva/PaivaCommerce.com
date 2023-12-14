using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaivaCommerce.Application.Interfaces;
using PaivaCommerce.Domain.Entities;
using PaivaCommerce.Domain.Services.Interfaces;

namespace PaivaCommerce.Application.Services
{
    public class ProductApplicationService : IProductApplicationService
    {
        private readonly IProductService _productService;
        public ProductApplicationService(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _productService.GetAllAsync();
        }
    }
}