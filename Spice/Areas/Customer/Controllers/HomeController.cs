using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;
using Spice.Models.ViewModels;

namespace Spice.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        //dependency injection
        //creating a local object
        private readonly ApplicationDbContext _db;

        //This is the object retrieved from the container through dependency injection
        public HomeController(ApplicationDbContext db)
        {
            _db= db;
        }
        public async  Task<IActionResult> Index()
        {
            //create an object of the IndexViewModel
            IndexViewModel IndexVM = new IndexViewModel()
            {
                //assign propperties
                //retrieving the list of menu items in the database with the category and subcategory
                MenuItem = await _db.MenuItem.Include(m => m.Category).Include(m => m.SubCategory).ToListAsync(),
                Category = await _db.Category.ToListAsync(),
                Coupon = await _db.Coupon.Where(c => c.IsActive == true).ToListAsync()
            };

            //we pass the index View model to the view
            return View(IndexVM);
        }
               

        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
