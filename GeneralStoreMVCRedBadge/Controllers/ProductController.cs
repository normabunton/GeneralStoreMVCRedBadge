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

        private ApplicationDbContext _db = new ApplicationDbContext

        // GET: Product
        public ActionResult Index()
        {
            //(modifying the ApplicaitonDbContext class)
            return View(_db.Products.ToList();
        }
    }
}