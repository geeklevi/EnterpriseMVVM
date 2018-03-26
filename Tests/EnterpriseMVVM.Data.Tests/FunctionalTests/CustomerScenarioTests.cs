// -----------------------------------------------------------------------------
//  <copyright file="CustomerScenarioTests.cs" company="DCOM Engineering, LLC">
//      Copyright (c) DCOM Engineering, LLC.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------------
namespace EnterpriseMVVM.Data.Tests.FunctionalTests
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CustomerScenarioTests
    {
        [TestMethod]
        public void AddNewCustomerIsPersisted()
        {
            using (var bc = new BusinessContext())
            {
                Customer entity = bc.AddNewCustomer("customer@northwind.com", "David", "Anderson");

                bool exists = bc.DataContext.Customers.Any(c => c.Id == entity.Id);

                Assert.IsTrue(exists);
            }
        }


        [ClassCleanup]
        public static void ClassCleanup()
        {
            using (var db = new DataContext())
                if (db.Database.Exists())
                    db.Database.Delete();
        }

    }
}