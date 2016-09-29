using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_2_BdAvancees
{
    public class CompanyContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public CompanyContext()
            :base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ConcurrencyDemo;")
        {

        }
    }
}
