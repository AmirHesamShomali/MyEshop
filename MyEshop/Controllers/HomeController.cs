using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyEshop.Data;
using MyEshop.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace MyEshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       private MyEshopContext _context;
        public HomeController(ILogger<HomeController> logger, MyEshopContext context)
        {
            _logger = logger;
            _context = context; 
        }

        private static Cart _cart=new Cart();

        public IActionResult Index()
        {
            var products = _context.productcs.ToList();
            return View(products);
        }

        [Route("shop")]
        public IActionResult Shop()
        {
            var products = _context.productcs
                .Include(p=>p.item)
                .ToList();
            return View(products);
        }

        [Route("aboutus")]
        public IActionResult aboutus()
        {
            return View();
        }

        [Route("Ditails")]

        public IActionResult Ditails(int id)
        {
            var products= _context.productcs
				  .Include(p => p.item)
				.SingleOrDefault(p=>p.Id==id);
            if(products == null)
            {
                return NotFound();
            }
            else
            {
              
             

            return View(products);
            }
        }

		public IActionResult Addproducts(int Id)
		{
			var product = _context.productcs.Include(p => p.item).SingleOrDefault(p => p.Id == Id);
         
                product.numbers += 1;
                _context.SaveChanges();
			return RedirectToAction("Ditails", new { id = Id });


		}

		public IActionResult Minezproducts(int Id)
		{
			var product = _context.productcs.Include(p => p.item).SingleOrDefault(p => p.Id == Id);

			if(product.numbers==0)
            {
                product.numbers = 0;
            }
            else
            {
                product.numbers -=1;
            }
			_context.SaveChanges();
			return RedirectToAction("Ditails", new { id = Id });


		}

        [Authorize]
		public IActionResult AddCart(int id)
        { 
            var products=_context.productcs.Include(p=>p.item).SingleOrDefault(p=>p.Id== id);  
            if(products!=null)
            {
                var cartitem = new Cartitem();
                cartitem.item = products.item;
                cartitem.quntity =products.numbers ;

                _cart.Add(cartitem);
            }
            return RedirectToAction("Cart");
        }

        public IActionResult removecart(int itemid)
        {

            _cart.remove(itemid);

            return RedirectToAction("Cart");
        }

        [Authorize]
        public IActionResult Cart()
        {
            var cartvm = new CartViewModelcs();
            cartvm.cartitem = _cart.cartitems;
            cartvm.ordertotal = _cart.cartitems.Sum(c => c.gettotalprice());
            return View(cartvm);  
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
