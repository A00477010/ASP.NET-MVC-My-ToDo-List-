using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        public ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db= db;
        }
        public IActionResult CategoryViewTable()
        {
            IEnumerable<Category> categoryList = _db.Categories;
            return View(categoryList);
        }
        
        //GET
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj) {
           
            

            if (obj.name == obj.displayOrder.ToString())
            {
                ModelState.AddModelError("name","The Name and display order cannot be same");
            }
            if(ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("CategoryViewTable");

            }
            return View();
            

        }
        public IActionResult Edit(int id)
        {


            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("CategoryViewTable");
            }

            return View();

        }
        public IActionResult Delete(int id)
        {
            var obj=_db.Categories.Find(id);
            _db.Categories.Remove(obj);
            _db.SaveChanges(true);
           
            return RedirectToAction("CategoryViewTable");
        }

    }
}
