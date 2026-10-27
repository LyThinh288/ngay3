using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ngay3.Models;
//dung using ngay3.Models; //khai bao namespace de dung class Category
//bo duoc Model.Category vi minh da khai bao namespace ngay3.Models
//o tren roi nen khong can dung nua
namespace ngay3.Controllers
{
    public class CategoryController : Controller
    {
        //gia lap csdl
        public static List<Models.Category> categories = new List<Models.Category>()
        {
            new Models.Category(){Id=1, Name="Laptop"},
            new Models.Category(){Id=2, Name="Phone"},
            new Models.Category(){Id=3, Name="Tablet"},
        };
        // GET: CategoryController
        public ActionResult Index()
        {
            return View(categories);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            categories.Add(category);
            return RedirectToAction(nameof(Index));
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var EditCategory = categories.FirstOrDefault(c => c.Id == id);
            if (EditCategory == null)
            {
                return NotFound();
            }
            return View(EditCategory);

        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            var existingCategory = categories.FirstOrDefault(c => c.Id == category.Id);
            if (existingCategory == null)
            {
                return NotFound();
            }
            existingCategory.Name = category.Name;
            return RedirectToAction(nameof(Index));
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);

        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            categories.Remove(category);
            return RedirectToAction(nameof(Index));

        }
    }
}
