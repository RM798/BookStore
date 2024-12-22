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
        public IActionResult Details()
        {
            List<Category> objcategories = _db.CategoryRecord.ToList();
            if (objcategories == null)
            {
                return NotFound();
            }
            return View(objcategories);
        }
    }
}
