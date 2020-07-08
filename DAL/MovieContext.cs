using MoviedbMVC5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MoviedbMVC5.DAL
{
    public class MovieContext : DbContext
    {

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Customer> Customers { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder) { modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); base.OnModelCreating(modelBuilder); }


    }
}