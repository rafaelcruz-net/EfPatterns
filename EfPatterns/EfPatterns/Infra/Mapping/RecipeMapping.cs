using EfPatterns.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EfPatterns.Infra.Mapping
{
    public class RecipeMapping : EntityTypeConfiguration<Recipe>, IMapping
    {
        public RecipeMapping()
        {
            this.ToTable("Recipe");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id);
            this.Property(x => x.Ingredients).HasMaxLength(1024);
            this.Property(x => x.Steps).HasMaxLength(1024);
            this.Property(x => x.Title).IsRequired().HasMaxLength(150);
        }

    }
}