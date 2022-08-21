using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Models_Dress_Up
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options)
        { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MemberShip> MemberShips { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<VendorMemberShip> VendorMemberShips { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS; Initial Catalog= DressUp; Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CategoryConfiguration().Configure(modelBuilder.Entity<Category>());
            new MemberShipConfiguration().Configure(modelBuilder.Entity<MemberShip>());
            new VendorConfiguration().Configure(modelBuilder.Entity<Vendor>());
            new VendorMemberShipConfiguration().Configure(modelBuilder.Entity<VendorMemberShip>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
