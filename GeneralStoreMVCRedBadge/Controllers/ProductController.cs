using GeneralStoreMVCRedBadge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeneralStoreMVCRedBadge.Controllers
{
    public class ProductController : Controller
    {

        //Add the application DB Context (link to tge database)

        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Product
        public ActionResult Index()
        {
            //(modifying the ApplicaitonDbContext class)
            return View(_db.Products.ToList());
        }


        //GET: Restaurant/Create
        
        public ActionResult Create()
        {
            return View();
        }

        //POST: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Add(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        //GET:DELETE
        //Product/Delete/{id}
        public ActionResult Delete(int? id)
        {
            if(id== null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Product product = _db.Products.Find(id);
            if(product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
    }
}