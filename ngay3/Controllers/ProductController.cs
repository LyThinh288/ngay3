using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ngay3.Models;
using ngay3.Data;
namespace ngay3.Controllers
{
    public class ProductController : Controller
    {
        //gia lap csdl
        public static List<Models.Product> products = new List<Models.Product>()
        {
            new Models.Product(){Id=1, Name="Laptop Dell", Price=1000, CategoryId=1},
            new Models.Product(){Id=2, Name="Laptop HP", Price=1200, CategoryId=1},
            new Models.Product(){Id=3, Name="Phone Samsung", Price=800, CategoryId=2},
            new Models.Product(){Id=4, Name="Phone Iphone", Price=1500, CategoryId=2},
            new Models.Product(){Id=5, Name="Tablet Samsung", Price=600, CategoryId=3},
            new Models.Product(){Id=6, Name="Tablet Apple", Price=900, CategoryId=3},
        };
        // GET: ProductController
        public ActionResult Index()
        {
            return View(products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(products);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            products.Add(product);
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var EditProduct = products.FirstOrDefault(p => p.Id == id);
            if (EditProduct == null)
            { return NotFound(); }
            return View(EditProduct);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            var existingProduct = products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.CategoryId = product.CategoryId;
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var Product = products.FirstOrDefault(p => p.Id == id);
            if (Product == null) {
                return NotFound();
            }
            return View(products);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            products.Remove(product);
            return RedirectToAction(nameof(Index));
        }
    }
}
