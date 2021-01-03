using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_Core_Identity.BlazorAdmin.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public DbSet<ApplicationUser> ApplicationUsers { get; set; }
		public DbSet<ApplicationRole> ApplicationRoles { get; set; }
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
	}
}
