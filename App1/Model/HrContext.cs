namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HrContext : DbContext
    {
        public HrContext()
            : base("name=Hr")
        {
        }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<JobHistory> JobsHistory { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Region> Regions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.RegionId)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Department>()
                .Property(e => e.DepartmentName)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.Department)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.LastNAme)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.JobId)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Employee>()
                .Property(e => e.CommissionPct)
                .HasPrecision(2, 2);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Departments)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.ManagerId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Subordinate)
                .WithOptional(e => e.Boss)
                .HasForeignKey(e => e.ManagerId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.JobsHistory)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JobHistory>()
                .Property(e => e.JobId)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.JobId)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.JobTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Job)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.JobsHistory)
                .WithRequired(e => e.Job)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.StreetAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.StateProvince)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Region>()
                .Property(e => e.RegionId)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Region>()
                .Property(e => e.RegionName)
                .IsUnicode(false);
        }
    }
}
