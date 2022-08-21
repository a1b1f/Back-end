using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Models_Dress_Up
{
    public class VendorConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.ToTable("Vendor");
            builder.HasKey("ID");
            builder.Property(V => V.ID).ValueGeneratedOnAdd();
            builder.Property(V=>V.NameEN).HasMaxLength(500).IsRequired();
            builder.Property(V=>V.NameAR).HasMaxLength(500).IsRequired();
            builder.Property(V=>V.Password).HasMaxLength(500).IsRequired();
            builder.Property(V => V.Image).HasMaxLength(500).IsRequired();
            builder.Property(V => V.phone).HasMaxLength(500).IsRequired();
            builder.Property(V => V.Email).HasMaxLength(500).IsRequired();
            builder.Property(V => V.RegisterDate).HasDefaultValue(DateTime.Now);
            builder.Property(V => V.IsDeleted).HasDefaultValue(false);
        }
    }
}
