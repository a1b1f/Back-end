using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Models_Dress_Up
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey("ID");
            builder.Property(C => C.ID).ValueGeneratedOnAdd();
            builder.Property(C=>C.NameEN).HasMaxLength(500).IsRequired();
            builder.Property(C => C.NameAR).HasMaxLength(500).IsRequired();
            builder.Property(C => C.IsDelated).HasDefaultValue(false);


        }
    }
}
