using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyEshop.Data;
using MyEshop.Models;

namespace MyEshop.Pages.Admin
{
    public class EditModel : PageModel
    {
        private MyEshopContext _context;
        public EditModel(MyEshopContext context)
        {
            _context = context;
        }
        [BindProperty]
        public AddEditproductViewModel product { get; set; }
        public void OnGet(int id)
        {
            
            var Product = _context.productcs.Include(p => p.item)
                .Where(p => p.Id == id)
                .Select(s => new AddEditproductViewModel()
                {
                    
                    Id=s.Id,
                    Name = s.Name,
                    Discribtion = s.Description,
                    QuintityStock = s.item.Quentitystock,
                    Price = s.item.price,
                  
                }).FirstOrDefault();

            product = Product;
  
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || product == null)

                return Page();

            //var pro = _context.productcs.Include(p => p.item).SingleOrDefault(p => p.item.price == product.Price);
            var pro = _context.productcs.Find(product.Id);
            var item = _context.items.First(p => p.Id == pro.itemid);
            pro.Name = product.Name;
            pro.Description = product.Discribtion;
            item.price = product.Price;
            item.Quentitystock = product.QuintityStock;
            _context.SaveChanges();
            if (product.Picture?.Length > 0)
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "pics",
                    "product-" +
                    pro.Id + Path.GetExtension(product.Picture.FileName));
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    product.Picture.CopyTo(stream);
                }
            }

            _context.SaveChanges();
            return RedirectToPage("Index");
        }



    }
}
