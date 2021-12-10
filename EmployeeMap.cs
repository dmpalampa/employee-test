using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class EmployeeMap
    {
        public EmployeeMap(EntityTypeBuilder<Employee> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.f_name).IsRequired();
            entityBuilder.Property(t => t.l_name).IsRequired();
            entityBuilder.Property(t => t.email);
            entityBuilder.Property(t => t.dept_id);
            entityBuilder.Property(t => t.address_id);
        }
    }
}
