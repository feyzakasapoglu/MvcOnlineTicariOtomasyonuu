using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicariOtomasyon.DAL.EF.Contexts;
using TicariOtomasyon.Entites.Model;

namespace TicariOtomasyon.WebMVC.Controllers
{
    public class CategoryController : Controller
    {
        //GET:Category
        TicariDbContext c = new TicariDbContext();
        public IActionResult Index()
        {

            var degerler = c.Categories.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CategoryAdd(Category cg)
        {
            c.Categories.Add(cg);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult CategoryDelete(int id)
        {
            var cate = c.Categories.Find(id);
            c.Categories.Remove(cate);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CategoryGive(int id)
        {
            var category = c.Categories.Find(id);
            return View("CategoryGive", category);
        }
        public ActionResult CategoryUpdate(Category cg)
        {
            var ctg = c.Categories.Find(cg.CategoryID);
            ctg.CategoryName = cg.CategoryName;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
