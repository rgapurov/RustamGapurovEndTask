using Microsoft.AspNetCore.Mvc;
using RustamGapurovEndTask.BusinessLayer.Concrete;
using RustamGapurovEndTask.EntityLayer.Concrete.Entities;
using RustamGapurovEndTask.Presentation.Models;
using System.Diagnostics;



namespace RustamGapurovEndTask.Presentation.Controllers
{
    public class HomeController : Controller
    {
        ProductManager _product = new ProductManager();
        CategoryManager _category = new CategoryManager();  
        Product _singleProduct;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = _product.List(x => x.Quantity > 1);
            return View(products);
        }
        
        public IActionResult CategoryBar()
        {
            return RedirectToAction("Index"); 
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}