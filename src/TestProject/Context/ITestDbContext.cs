namespace TestProject.Context
{
    using System.Threading;
    using System.Threading.Tasks;
    using Entities;
    using Microsoft.EntityFrameworkCore;

    public interface ITestDbContext
    {
        DbSet<CustomerBase> Customers { get; set; }
        DbSet<SmallCustomer> SmallCustomers { get; set; }
        DbSet<BigCustomer> BigCustomers { get; set; }
        DbSet<ProjectCustomer> ProjectCustomers { get; set; }

        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}