using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SampleCoreApp.Models;

namespace SampleCoreApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        
        // *****************
        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        // {
        // // in memory database used for simplicity, change to a real db for production applications
        
        // //* options.UseInMemoryDatabase("TestDb");
        // options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        // }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
