namespace EnterpriseMVVM.Data.Tests.FunctionalTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    class DatabaseSenarioTests
    {
        [TestMethod]
        public void CanCreateDatabase()
        {
            using (var db = new DomainContext())
            {
                db.Database.Create();
            }
        }
    }
}
