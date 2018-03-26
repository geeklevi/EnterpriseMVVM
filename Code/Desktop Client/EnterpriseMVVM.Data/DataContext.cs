// -----------------------------------------------------------------------------
//  <copyright file="DataContext.cs" company="DCOM Engineering, LLC">
//      Copyright (c) DCOM Engineering, LLC.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------------
namespace EnterpriseMVVM.Data
{
    using System.Data.Entity;

    /// <summary>
    /// Encapsulates database access.
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataContext"/> class that will use a default named connection string of 'Default' from the application's configuration file.
        /// </summary>
        public DataContext() : base("Default")
        {
        }

        /// <summary>
        /// Gets a collection of customer entities.
        /// </summary>
        public DbSet<Customer> Customers { get; set; }
    }
}