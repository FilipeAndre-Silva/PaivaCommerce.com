using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaivaCommerce.Domain.Entities;

namespace PaivaCommerce.Infra.Mapper
{
    public class ProductMapper : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
        
            builder.HasKey(p => p.Id);
            
            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.UnitPrice)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(p => p.Amount)
                .IsRequired();

            builder.Property(p => p.CreationDate)
                .IsRequired();

            builder.Property(p => p.ChangeDate)
                .IsRequired();
        }
    }
}