using MoviedbMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviedbMVC5.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customer { get; set; }
    }
}