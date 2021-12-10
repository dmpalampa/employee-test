using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class DepartmentMap
    {
        public DepartmentMap(EntityTypeBuilder<Department> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.dHead).IsRequired();
            entityBuilder.Property(t => t.dName).IsRequired();
            entityBuilder.HasMany(t => t.Employee)
            .WithOne(e => e.dept);
        }
    }
}
