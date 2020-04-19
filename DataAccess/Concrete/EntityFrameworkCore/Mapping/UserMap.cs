using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.Firstname).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Surname).HasMaxLength(100).IsRequired(false);
            builder.Property(I => I.Phone).HasMaxLength(100);
            builder.Property(I => I.Email).HasMaxLength(100).IsRequired();



            builder.HasMany(I => I.Works).WithOne(I => I.User).HasForeignKey(I => I.UserId);

        }
    }
}
