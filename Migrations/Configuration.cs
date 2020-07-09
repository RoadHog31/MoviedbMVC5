namespace MoviedbMVC5.Migrations
{
    using MoviedbMVC5.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MoviedbMVC5.DAL.MovieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MoviedbMVC5.DAL.MovieContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.            

            var movies = new List<Movie>
            {
                new Movie
                {
                    Title = "Batman",
                    ReleaseDate = new DateTime(2020, 05, 31),
                    Genre = "Action"
                }
            };

            var customer = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                FirstName = "Stephen",
                Movies = movies
                }
                
            };

            movies.ForEach(b => context.Movies.Add(b));
            customer.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();
        }
    }
}
