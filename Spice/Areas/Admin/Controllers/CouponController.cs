using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;
using Spice.Utility;

namespace Spice.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.ManagerUser)]
    [Area("Admin")]
    public class CouponController : Controller
    {
        //This will retrieve all of the coupons and pass it through the view
        private readonly ApplicationDbContext _db;
        public CouponController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET-INDEX
        public async Task<IActionResult> Index()
        {
            return View(await _db.Coupon.ToListAsync());
        }

        //GET-CREATE
        //We don't have to pass anything to the view
        public IActionResult Create()
        {
            return View();
        }

        //POST-CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Coupon coupons)
        {
            if (ModelState.IsValid)
            {
                //This is used to get the file
                var files = HttpContext.Request.Form.Files;
                if(files.Count > 0)
                {
                    //convert the picture to a stream of bytes 
                    byte[] p1 = null;
                    using (var fs1= files[0].OpenReadStream())
                    {
                        //memorystream
                        using(var ms1 = new MemoryStream())
                        {
                            //coverting the image to a byte-array
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                    }
                    //Add it to the pictures in the database
                    coupons.Picture = p1;
                }
                //saving the rest of the data
                _db.Coupon.Add(coupons);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            //if model state is not valid
            return View(coupons);
        }

        //GET Edit Coupon
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var coupon = await _db.Coupon.SingleOrDefaultAsync(m => m.Id == id);
            if (coupon == null)
            {
                return NotFound();
            }
            return View(coupon);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Coupon coupons)
        {
            if (coupons.Id == 0)
            {
                return NotFound();
            }

            var couponFromDb = await _db.Coupon.Where(c => c.Id == coupons.Id).FirstOrDefaultAsync();

            if (ModelState.IsValid)
            {
                //This is used to get the file
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0)
                {
                    //convert the picture to a stream of bytes 
                    byte[] p1 = null;
                    using (var fs1 = files[0].OpenReadStream())
                    {
                        //memorystream
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                    }
                    //replacing the picture in the database
                    couponFromDb.Picture = p1;
                }
                //replacing the other propperties in the database
                couponFromDb.MinimumAmount = coupons.MinimumAmount;
                couponFromDb.Name = coupons.Name;
                couponFromDb.Discount = coupons.Discount;
                couponFromDb.CouponType = coupons.CouponType;
                couponFromDb.IsActive = coupons.IsActive;

                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coupons);
        }



        //GET-DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var coupon = await _db.Coupon.FindAsync(id);
            if (coupon == null)
            {
                return NotFound();
            }
            //This is returning the category retrieved with the id
            return View(coupon);
        }

        //GET-DELETE
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var coupon = await _db.Coupon.SingleOrDefaultAsync(m => m.Id == id);
            if (coupon == null)
            {
                return NotFound();
            }
            return View(coupon);
        }

        //POST-DELETE
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var coupon = await _db.Coupon.FindAsync(id);
            if (coupon == null)
            {
                return View();
            }
            _db.Coupon.Remove(coupon);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}