using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Labo_2_BdAvancees;

namespace TestsUnitaires
{
    class DbInitializer : DropCreateDatabaseAlways<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            Customer custom = new Customer()
            {
                Name = "Christophe Schepmans",
                AddressLine1 = "Rue des malles terres, 35A",
                City = "Tihange",
                Country = "Belgique",
                EMail = "christ.schepmans@hotmail.com",
                Id = 9,
                Remark = "Apportez du gateau",
                PostCode = "4500"
            };

            context.Customers.Add(custom);
            context.SaveChanges();

        }
    }
}

