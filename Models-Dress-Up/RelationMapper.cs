using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Models_Dress_Up
{
    public class RelationMapper
    {
        public static void Mapper(ModelBuilder modelBuilder)
        {

            /* Vendor MemberShip*/
            modelBuilder.Entity<VendorMemberShip>()
                .HasOne(vm => vm.Vendor)
                .WithMany(vm => vm.VendorMemberShips)
                .HasForeignKey(vm => vm.VendorID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<VendorMemberShip>()
               .HasOne(vm => vm.MemberShip)
               .WithMany(vm => vm.VendorMemberShips)
               .HasForeignKey(vm => vm.MemberShipID)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
