using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Models.ViewModels
{
    //  View models is a model which contains more than one model data for a particular view
    public class SubCategoryAndCategoryViewModel
    {
        //This is for the Category list that will be displayed that in the dropdown list
        public IEnumerable<Category> CategoryList { get; set; }

        //This is the property for the new Subcategory that will be created 
        public SubCategory SubCategory { get; set; }

        //This is the list of the subcategory that will be displayed on the other side of the page
        public List<string> SubCategoryList { get; set; }

        //This for the error message.
        public string StatusMessage { get; set; }
    }
}
