using DiginetSite.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiginetSite.Domain.Data
{
    public class LoginDbContext : DbContext
    {
        public LoginDbContext() : base("name=DiginetDB")
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        //protected void override OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}
