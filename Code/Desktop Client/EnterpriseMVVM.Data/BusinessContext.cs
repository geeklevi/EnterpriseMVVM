// -----------------------------------------------------------------------------
//  <copyright file="BusinessContext.cs" company="DCOM Engineering, LLC">
//      Copyright (c) DCOM Engineering, LLC.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------------
namespace EnterpriseMVVM.Data
{
    using System;

    /// <summary>
    /// Encapsulates business rules when accessing the data layer.
    /// </summary>
    /// to wrap our domain context
    public sealed class BusinessContext : IDisposable
    {
        private readonly DataContext context;
        private bool disposed;

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessContext"/> class.
        /// </summary>
        public BusinessContext()
        {
            context = new DataContext();
        }

        /// <summary>
        /// Gets the underlying <see cref="DataContext"/>.
        /// </summary>
        public DataContext DataContext
        {
            get { return context; }
        }

        /// <summary>
        /// Adds a new customer using the specified first and last name.
        /// </summary>
        /// <param name="email">The customer's email address.</param>
        /// <param name="firstName">The customer's first name.</param>
        /// <param name="lastName">The customer's last name.</param>
        /// <returns>Returns the new <see cref="Customer"/> instance.</returns>
        public Customer AddNewCustomer(string email, string firstName, string lastName)
        {
            if (email == null)
                throw new ArgumentNullException("email", "email must be non-null.");

            if (String.IsNullOrEmpty(email))
                throw new ArgumentException("email must not be an empty string.", "email");

            if (firstName == null)
                throw new ArgumentNullException("firstName", "firstName must be non-null.");

            if (String.IsNullOrEmpty(firstName))
                throw new ArgumentException("firstName must not be an empty string.", "firstName");

            if (lastName == null)
                throw new ArgumentNullException("lastName", "lastName must be non-null.");

            if (String.IsNullOrEmpty(lastName))
                throw new ArgumentException("lastName must not be an empty string.", "lastName");

            var customer = new Customer
                           {
                               FirstName = firstName,
                               LastName = lastName
                           };

            context.Customers.Add(customer);
            context.SaveChanges();

            return customer;
        }

        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposed || !disposing)
                return;

            if (context != null) 
                context.Dispose();

            disposed = true;
        }

        #endregion
    }
}