using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVCDemo.DAL
{
    public class AccountContext:DbContext
    {
        public AccountContext():base("AccountContext") { }
        public DbSet<MVCDemo.Models.Account> Accounts { get; set; }
        public DbSet<MVCDemo.Models.Article> Articles { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}