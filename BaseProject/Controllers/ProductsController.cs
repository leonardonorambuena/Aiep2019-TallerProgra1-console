using Microsoft.AspNetCore.Mvc;
using BaseProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BaseProject.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductsController(ApplicationDbContext db)
        {
           _db = db; 
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = await _db.Products.ToListAsync();

            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
    }
}