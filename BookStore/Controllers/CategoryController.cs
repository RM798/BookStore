using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objcategories = _db.CategoryRecord.ToList();
            if (objcategories == null)
            {
                return NotFound();
            }
            return View(objcategories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            //if(obj.Name == obj.DisplayOrder.ToString())
            //{
            //    ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            //}
            //if (obj.Name!=null && obj.Name.ToLower() == "test")
            //{
            //    ModelState.AddModelError("", "Test is an invalid value");
            //}
            if (ModelState.IsValid)
            {
                _db.CategoryRecord.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }         
            return View();

        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public Category Save(Category details)
        {
            Category newdata = new Category();
            newdata.Name = details.Name;
            newdata.DisplayOrder = details.DisplayOrder;
            if (ModelState.IsValid)
            {
                _db.CategoryRecord.Add(newdata); // Add to context
                _db.SaveChanges();          // Save changes to database
                //return RedirectToAction("Index"); // Redirect to a confirmation page or list
            }

            return newdata; // Return to the form if validation fails
        }
    }
}
