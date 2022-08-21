using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_Dress_Up
{
    public class Vendor
    {
        public string? ID { get; set; }
        public string? NameAR { get; set; }
        public string? NameEN { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsDeleted { get; set; }
        public string? Image { get; set; }
        public string? phone { get; set; }
        public virtual List<VendorMemberShip>? VendorMemberShips { get; set; }
    }
}
