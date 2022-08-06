using ECommerceApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Product 1", Color = "Black", Size = "500x300", BrandId = 2 },
                new Product { Id = 2, Name = "Product 2", Color = "White", Size = "600x400", BrandId = 1 },
                new Product { Id = 3, Name = "Product 3", Color = "Red", Size = "1080x720", BrandId = 3 }
                );
        }
    }

}
