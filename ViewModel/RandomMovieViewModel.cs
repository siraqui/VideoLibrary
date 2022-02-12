using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidlib_v2.Models;
namespace Vidlib_v2.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }
    }
}