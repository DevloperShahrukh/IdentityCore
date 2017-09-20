using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySolution.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        //public string Username { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
