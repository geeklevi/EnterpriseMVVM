// -----------------------------------------------------------------------------
//  <copyright file="BusinessContextTests.cs" company="DCOM Engineering, LLC">
//      Copyright (c) DCOM Engineering, LLC.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------------
namespace EnterpriseMVVM.Data.Tests.UnitTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BusinessContextTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNewCustomer_ThrowsException_WhenEmailIsNull()
        {
            using (var bc = new BusinessContext())
            {
                bc.AddNewCustomer(null, "David", "Anderson");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddNewCustomer_ThrowsException_WhenEmailNameIsEmpty()
        {
            using (var bc = new BusinessContext())
            {
                bc.AddNewCustomer("", "David", "Anderson");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNewCustomer_ThrowsException_WhenFirstNameIsNull()
        {
            using (var bc = new BusinessContext())
            {
                bc.AddNewCustomer("customer@northwind.com", null, "Anderson");
            }
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void AddNewCustomer_ThrowsException_WhenFirstNameIsEmpty()
        {
            using (var bc = new BusinessContext())
            {
                bc.AddNewCustomer("customer@northwind.com", "", "Anderson");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNewCustomer_ThrowsException_WhenLastNameIsNull()
        {
            using (var bc = new BusinessContext())
            {
                bc.AddNewCustomer("customer@northwind.com", "David", null);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddNewCustomer_ThrowsException_WhenLastNameIsEmpty()
        {
            using (var bc = new BusinessContext())
            {
                bc.AddNewCustomer("customer@northwind.com", "David", "");
            }
        }
    }
}