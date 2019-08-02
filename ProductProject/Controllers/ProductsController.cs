using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProductProject.Models;
using ProductProject.ViewModels;

namespace ProductProject.Controllers
{
  public class ProductsController : Controller
  {
    private readonly ApplicationDbContext _db;

    public ProductsController(ApplicationDbContext db)
    {
       _db = db; 
    }
    public IActionResult Index()
    {
      var products = _db.Products.OrderBy(x => x.Name).ToList();
      return View(products);
    }

    public IActionResult Create(Product model)
    {
      _db.Products.Add(model);
      _db.SaveChanges();

      return RedirectToAction("Index");
    }

    public IActionResult bienvenido(PruebaViewModel model)
    {
      return View(model);
    }

    [HttpGet]
    public IActionResult prueba(PruebaViewModel model)
    {
      if (ModelState.IsValid)
      {
        return RedirectToAction("bienvenido", model);
      }
      return RedirectToAction("Index");
    }
  }
}