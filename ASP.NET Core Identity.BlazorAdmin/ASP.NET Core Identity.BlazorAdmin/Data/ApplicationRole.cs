using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ASP.NET_Core_Identity.BlazorAdmin.Data
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() { }

        public ApplicationRole(string roleName)
            : base(roleName) { }

        public virtual ICollection<IdentityRoleClaim<string>> Claims { get; set; }
    }
}
