using Microsoft.EntityFrameworkCore;
using PaivaCommerce.Domain.Entities;

namespace PaivaCommerce.Infra.Data
{
    public class PaivaCommerceDbContext : DbContext
    {
       public PaivaCommerceDbContext(DbContextOptions<PaivaCommerceDbContext> options) : base(options)
       { }

       public DbSet<Product> Products { get; set; }
    }
}