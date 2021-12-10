using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class AddressMap
    {
        public AddressMap(EntityTypeBuilder<Address> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.city).IsRequired();
            entityBuilder.Property(t => t.village).IsRequired();
            entityBuilder.Property(t => t.street).IsRequired();
            entityBuilder.Property(t => t.zip_code).IsRequired();
            entityBuilder.HasMany(t => t.Employee)
            .WithOne(e => e.address);
        }
    }
}
