using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using Labo_2_BdAvancees;
using System.Linq;
using System.Data.Entity.Infrastructure;

namespace TestsUnitaires
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void InsertionFonctionnelle()
        {
            Database.SetInitializer(new DbInitializer());
            using (CompanyContext context = GetContext())
            {
                context.Database.Initialize(true);
            }
        }
        [TestMethod]
        public void CanGetCustomers()
        {
            using (var context = GetContext())
            {
                Assert.AreEqual(1, context.Customers.ToList().Count);
            }
        }

        public CompanyContext GetContext()
        {
            return new CompanyContext();
        }
        
        [TestMethod]
        [ExpectedException(typeof(DbUpdateConcurrencyException))]
        public void DetecteLesEditionsConcurrences()
        {
            using(CompanyContext contexteDeJohn = GetContext())
            {
                using(CompanyContext contextDeSarah = GetContext())
                {
                    var clientDeJohn = contexteDeJohn.Customers.First();
                    var clientDeSarah = contextDeSarah.Customers.First();

                    clientDeJohn.AccountBalance += 1000;
                    contexteDeJohn.SaveChanges();

                    clientDeSarah.AccountBalance += 2000;
                    contextDeSarah.SaveChanges();


                }
            }
        }
    }
}
