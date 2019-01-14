using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Student.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Repositories.EntityFramework.Mapping
{
    public class UserMap : BaseEntityTypeConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));
            builder.Property(p => p.Name).HasColumnType("varchar(100)").IsRequired();
            builder.Property(p => p.Password).HasColumnType("varchar(100)").IsRequired();
        }
    }
}
