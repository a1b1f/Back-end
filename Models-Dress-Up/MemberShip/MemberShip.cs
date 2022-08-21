using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_Dress_Up
{
    public class MemberShip
    {
        public string? ID { get; set; }
        public string? TypeEn { get; set; }
        public string? TypeAr { get; set; }
        public int NumOfOrders { get; set; }
        public float Price { get; set; }
        public virtual List<VendorMemberShip>? VendorMemberShips { get; set; }
    }
}
