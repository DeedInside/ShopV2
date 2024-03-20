using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopV2.BaseContext;
using ShopV2.Model;

namespace ShopV2.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext _context;
        public HomeController(ApplicationContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Print()
        {
            List<Product> products = await _context.Products.ToListAsync();

            return View("PrintProduct",products);
        }
        [HttpPost]  
        public IActionResult RemoveItem(Product qwe)
        {
            int id = 0;
            var product = _context.Products.Find(id);
            if(product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            List<Product> products = _context.Products.ToList();
            return View("PrintProduct", products);
        }

        [HttpGet]
        public IActionResult AddProduct(string Name, string Description, string Price)
        {

            if(Name != null && Price != null)
            {
                _context.Products.Add(new Product(Name,Description,Convert.ToDouble(Price),"None"));
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("is null data");
            }
            return RedirectToAction("Print");
        }
        [Route("/print/{id}")]
        
        public IActionResult ViewProduct(int id)
        {
            Product value = _context.Products.Find(id);
            if(value != null)
            {
                return View(value);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
