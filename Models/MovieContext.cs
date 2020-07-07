using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MoviedbMVC5.Models
{
    public class MovieContext : DbContext
    {

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}