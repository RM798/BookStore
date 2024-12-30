using BookStoreRazor_Temp.Data1;
using BookStoreRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStoreRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null && id != 0)
            {
                Category = _db.CategoryRecordRazor.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            Category? obj = _db.CategoryRecordRazor.Find(Category.Id);
            if (obj==null)
            {
               return NotFound();
            }
            _db.CategoryRecordRazor.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category Deleted Successfully";
            return RedirectToPage("Index");
        }
    }
}
