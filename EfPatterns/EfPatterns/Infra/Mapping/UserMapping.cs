using EfPatterns.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EfPatterns.Infra.Mapping
{
    public class UserMapping : EntityTypeConfiguration<User>, IMapping
    {
        public UserMapping()
        {
            this.ToTable("User");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id);
            this.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            this.Property(x => x.Email).IsRequired().HasMaxLength(255);
            this.Property(x => x.DtNascimento).IsRequired();
            this.HasMany(x => x.Recipes).WithOptional().HasForeignKey(x => x.UserId);
        }

    }
}