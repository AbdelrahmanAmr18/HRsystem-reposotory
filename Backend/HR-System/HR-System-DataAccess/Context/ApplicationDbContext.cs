using HR_System_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_System_DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                         .Property(e => e.DepartmentId)
                         .IsRequired(false); // Set the column as nullable
        }

        public virtual DbSet<Employee>? Employees { get; set; }
        public virtual DbSet<Company>? Companies { get; set; }
        public virtual DbSet<Branch>? Branches { get; set; }
        public virtual DbSet<Department>? Departments { get; set; }
        public virtual DbSet<Position>? Positions { get; set; }
        public virtual DbSet<Level>? Levels { get; set; }


    }
}
