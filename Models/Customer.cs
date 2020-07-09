using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviedbMVC5.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        private string _fullName;

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }


        public virtual List<Movie> Movies { get; set; }
    }
}