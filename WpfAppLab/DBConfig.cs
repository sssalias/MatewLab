using WpfAppLab.Models;
using Microsoft.EntityFrameworkCore;

namespace WpfAppLab
{
    internal class DBConfig: DbContext
    {
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Storage> Storage { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<JobTitle>()
                .HasMany(e => e.Employees)
                .WithOne(e => e.JobTitle)
                .HasForeignKey(e => e.JobTitleId)
                .IsRequired(false);

            modelBuilder.Entity<ProductType>()
                .HasMany(e => e.Products)
                .WithOne(e => e.ProductType)
                .HasForeignKey(e => e.ProductTypeId)
                .IsRequired(false);
        }
    }
}
