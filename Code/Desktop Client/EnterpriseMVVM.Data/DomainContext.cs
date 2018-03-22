using System.Security.AccessControl;

namespace EnterpriseMVVM.Data
{
    using System.Data.Entity;

    public class DomainContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
