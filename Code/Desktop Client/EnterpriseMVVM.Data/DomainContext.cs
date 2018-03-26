namespace EnterpriseMVVM.Data
{
    using System.Data.Entity;

    public class DomainContext : DbContext
    {
        public DomainContext() : base("Default")
        {
        }
        public DbSet<Customer> Customers { get; set; }
    }

}

