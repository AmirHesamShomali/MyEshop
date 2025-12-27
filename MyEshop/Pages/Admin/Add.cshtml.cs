using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyEshop.Data;
using MyEshop.Models;

namespace MyEshop.Pages.Admin
{
    public class AddModel : PageModel
    {
        private MyEshopContext _context;
        public AddModel(MyEshopContext context)
        {
            _context = context; 
        }
        [BindProperty]
        public AddEditproductViewModel product  { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();


            var item = new item()
            {
        
                price = product.Price,
                Quentitystock = product.QuintityStock
            };
            _context.Add(item);
            _context.SaveChanges();

            var pro = new Productcs()
            {
                
                Name = product.Name,
                item = item,
                Description = product.Discribtion,
               

            };
            pro.itemid= product.Id;
            _context.Add(pro);
            _context.SaveChanges();
            //pro.Id = pro.itemid;
            //_context.SaveChanges();

            if (product.Picture?.Length > 0)
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "pics",
                    "product-"+
                    pro.Id + Path.GetExtension(product.Picture.FileName));
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    product.Picture.CopyTo(stream);
                }
            }


            return RedirectToPage("Index");
        }


    }
}
