using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly_mvc.Models;

namespace vidly_mvc.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}