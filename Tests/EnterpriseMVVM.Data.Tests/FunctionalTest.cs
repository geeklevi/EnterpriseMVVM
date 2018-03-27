//// -----------------------------------------------------------------------------
////  <copyright file="FunctionalTest.cs" company="DCOM Engineering, LLC">
////      Copyright (c) DCOM Engineering, LLC.  All rights reserved.
////  </copyright>
//// -----------------------------------------------------------------------------
namespace EnterpriseMVVM.Data.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FunctionalTest
    {
        [TestInitialize]
        public virtual void TestInitialize()
        {
            //throw new InvalidOperationException("Configure your connection strings in the various App.config files and then remove this exception from FunctionalTest.cs > TestInitialize");

            using (var db = new DataContext())
            {
                if (db.Database.Exists())
                    db.Database.Delete();

                db.Database.Create();
            }

        }

        [TestCleanup]
        public virtual void TestCleanup()
        {
            using (var db = new DataContext())
                if (db.Database.Exists())
                    db.Database.Delete();
        }
    }
}
