using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ASP.NET_Core_Identity.BlazorAdmin.Data
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }
        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
    }
}
