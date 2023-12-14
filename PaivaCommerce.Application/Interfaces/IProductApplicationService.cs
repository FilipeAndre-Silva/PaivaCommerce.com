using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaivaCommerce.Domain.Entities;

namespace PaivaCommerce.Application.Interfaces
{
    public interface IProductApplicationService
    {
        Task<List<Product>> GetAllAsync();
    }
}