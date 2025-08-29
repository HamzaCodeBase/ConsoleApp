using Microsoft.EntityFrameworkCore;

namespace WebApplicationEmpty
{
    public class ClassContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database =EmptyDB ; Integrated Security = true; Trust Server Certificate = True;");
            base.OnConfiguring(optionsBuilder);
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Employee>()
        //        .HasOne(e => e.Office)
        //        .WithOne(e => e.Employee)
        //        .HasForeignKey<Employee>(e=>e.OfficeId);
        //}
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Office> Offices { get; set; }
        // Here we are only using DbSet with Employee but Department table will be created because
        // Employee table contains Department Type property 

        //public DbSet<Department> Department { get; set; }
        //      above statement does not make any difference in this case
        //      weather you specify Department table or not, it will be created.
    }
}
