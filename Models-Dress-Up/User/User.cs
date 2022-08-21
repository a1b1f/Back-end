using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Models_Dress_Up
{
    public class User : IdentityUser
    {
        public string? NameEN { get; set; }
        public string? NameAR { get; set; }
        public string? Image { get; set; }
        public string? Adress { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
