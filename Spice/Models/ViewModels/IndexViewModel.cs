using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Models.ViewModels
{
    public class IndexViewModel
    {
        //This will be used to display all the details on the landing page
        public IEnumerable<MenuItem> MenuItem { get; set; }

        public IEnumerable<Category> Category { get; set; }

        public IEnumerable<Coupon> Coupon { get; set; }
    }
}
