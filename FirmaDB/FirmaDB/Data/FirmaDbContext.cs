using FirmaDB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaDB.Data
{
    public class FirmaDbContext : DbContext
    {
        public FirmaDbContext() : base("name=DefaultConnection")
        {
        }
        public DbSet<AccessLevel> AccessLevels { get; set; }
        public DbSet<Children> Childrens { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<HealthCheck> HealthChecks { get; set; }
        public DbSet<JobTenure> JobTenures { get; set; }
        public DbSet<LoanableItems> LoanableItems { get; set; }
        public DbSet<Loaning> Loanings { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Requests> Requests { get; set; }
        public DbSet<SickLeave> SickLeaves { get; set; }
        public DbSet<Suggestions> Suggestions { get; set; }
        public DbSet<Vacation> Vacations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
