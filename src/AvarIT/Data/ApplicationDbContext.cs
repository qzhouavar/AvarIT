using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AvarIT.Models;
using AvarIT.Models.InventoryModels;

namespace AvarIT.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<ComputerCase> ComputerCases { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<Monitor> Monitors { get; set; }
        public DbSet<NetWork> NetWorks { get; set; }
        public DbSet<Miscellaneous> MiscellaneousItems { get; set; }
        public DbSet<WebCompatibilityIssues> Issues { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<OperationSystem> OperationSystems { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<OfficeLocation> OfficeLocations { get; set; }
    }
}
