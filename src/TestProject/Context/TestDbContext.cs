namespace TestProject.Context
{
    using Entities;
    using Microsoft.EntityFrameworkCore;

    public class TestDbContext : DbContext, ITestDbContext
    {
        public DbSet<CustomerBase> Customers { get; set; }
        public DbSet<SmallCustomer> SmallCustomers { get; set; }
        public DbSet<BigCustomer> BigCustomers { get; set; }
        public DbSet<ProjectCustomer> ProjectCustomers { get; set; }

        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BigCustomer>().OwnsOne(c => c.Info);
            modelBuilder.Entity<SmallCustomer>().OwnsOne(c => c.Info);
            modelBuilder.Entity<ProjectCustomer>().OwnsOne(c => c.Info);

            modelBuilder.Entity<ContactInfo>()
                .Property<byte[]>("RowVersion").IsRowVersion().HasColumnName("RowVersion");

            base.OnModelCreating(modelBuilder);
        }
    }
}