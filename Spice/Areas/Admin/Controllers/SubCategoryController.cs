using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;
using Spice.Models.ViewModels;

namespace Spice.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubCategoryController : Controller
    {
        //creating a local object
        private readonly ApplicationDbContext _db;

        //TempData is used her to display the error (StatusMessage) on the Create SubCategories Page
        [TempData]
        public string StatusMessage { get; set; }


        //This is the object retrieved from the container through dependency injection
        public SubCategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET-INDEX
        public async Task<IActionResult> Index()
        {
            //This is telling the query to load category and subcategories from the database at the same time
            var subcategories = await _db.SubCategory.Include(s => s.Category).ToListAsync();
            return View(subcategories);
        }

        //GET-CREATE
        public async Task<IActionResult> Create()
        {
            SubCategoryAndCategoryViewModel model = new SubCategoryAndCategoryViewModel()
            {
                //We need to create an extension method to covert the Category object to a select list. This is done in the extensions folder.
                CategoryList = await _db.Category.ToListAsync(),
                SubCategory = new Models.SubCategory(),
                SubCategoryList = await _db.SubCategory.OrderBy(p => p.Name).Select(p => p.Name).Distinct().ToListAsync()
            };

            return View(model);
        }

        //POST-CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SubCategoryAndCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                //This is used to check if the subcategory created already exists
                var doesSubCategoryExists = _db.SubCategory.Include(s => s.Category).Where(s => s.Name == model.SubCategory.Name && s.Category.Id == model.SubCategory.CategoryId);


                if (doesSubCategoryExists.Count() > 0)
                {
                    //Error
                    StatusMessage = "Error: Sub-Categories exists under " + doesSubCategoryExists.First().Category.Name + " Please use another Name";
                }
                else
                {
                    _db.SubCategory.Add(model.SubCategory);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));

                }
            }

            //if the model state is not valid you need to return the page back to its original state 
            SubCategoryAndCategoryViewModel modelVM = new SubCategoryAndCategoryViewModel()
            {
                //We need to create an extension method to covert the Category object to a select list. This is done in the extensions folder.
                CategoryList = await _db.Category.ToListAsync(),
                SubCategory = new Models.SubCategory(),
                SubCategoryList = await _db.SubCategory.OrderBy(p => p.Name).Select(p => p.Name).Distinct().ToListAsync(),
                StatusMessage = StatusMessage
            };
            return View(modelVM);
        }

        [ActionName("GetSubCategory")]
        public async Task<IActionResult> GetSubCategory(int id)
        {
            List<SubCategory> subCategories = new List<SubCategory>();
            subCategories = await (from subCategory in _db.SubCategory where subCategory.CategoryId == id select subCategory).
                ToListAsync();
            return Json(new SelectList(subCategories, "Id", "Name"));

        }

        //GET-EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            //if the id is null
            if (id == null)
            {
                return NotFound();
            }

            //retrieving the data from the database
            var subCategory = await _db.SubCategory.SingleOrDefaultAsync(m => m.Id == id);

            //if the variable is null
            if (subCategory == null)
            {
                return NotFound();
            }

            //returning the model to the view

            SubCategoryAndCategoryViewModel model = new SubCategoryAndCategoryViewModel()
            {
                //We need to create an extension method to covert the Category object to a select list. This is done in the extensions folder.
                CategoryList = await _db.Category.ToListAsync(),
                SubCategory = subCategory,
                SubCategoryList = await _db.SubCategory.OrderBy(p => p.Name).Select(p => p.Name).Distinct().ToListAsync()
            };

            return View(model);
        }

        //POST-EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SubCategoryAndCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                //This is used to check if the subcategory created already exists
                var doesSubCategoryExists = _db.SubCategory.Include(s => s.Category).Where(s => s.Name == model.SubCategory.Name && s.Category.Id == model.SubCategory.CategoryId);


                if (doesSubCategoryExists.Count() > 0)
                {
                    //Error
                    StatusMessage = "Error: Sub-Categories exists under " + doesSubCategoryExists.First().Category.Name + " Please use another Name";
                }
                else
                {
                    var subCatFromDb = await _db.SubCategory.FindAsync(model.SubCategory.Id);

                    //this is another way to update a record.
                    subCatFromDb.Name = model.SubCategory.Name;

                    
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));

                }
            }

            //if the model state is not valid you need to return the page back to its original state 
            SubCategoryAndCategoryViewModel modelVM = new SubCategoryAndCategoryViewModel()
            {
                //We need to create an extension method to covert the Category object to a select list. This is done in the extensions folder.
                CategoryList = await _db.Category.ToListAsync(),
                SubCategory = model.SubCategory,
                SubCategoryList = await _db.SubCategory.OrderBy(p => p.Name).Select(p => p.Name).Distinct().ToListAsync(),
                StatusMessage = StatusMessage
            };
            return View(modelVM);

        }

        //GET-DETAILS
        //This is a method to get the details of the subcategory
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subCategory = await _db.SubCategory.Include(s => s.Category).SingleOrDefaultAsync(m => m.Id == id);

            if (subCategory == null)
            {
                return NotFound();
            }

            //This is returning the subcategory retrieved with the id
            return View(subCategory);
           
        }

        //GET-DELETE
        //This is a method to get the details of the subcategory
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subCategory = await _db.SubCategory.Include(s => s.Category).SingleOrDefaultAsync(m => m.Id == id);

            if (subCategory == null)
            {
                return NotFound();
            }

            //This is returning the subcategory retrieved with the  to the model
            return View(subCategory);

        }

        //POST-DELETE
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {

            var subCategory = await _db.SubCategory.FindAsync(id);
            if (subCategory == null)
            {
                return View();
            }
            _db.SubCategory.Remove(subCategory);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}