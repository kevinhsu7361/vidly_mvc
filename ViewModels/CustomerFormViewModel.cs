using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly_mvc.Models;

namespace vidly_mvc.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}