using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyEshop.Data;
using MyEshop.Models;

namespace MyEshop.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private MyEshopContext _context;

        public IndexModel(MyEshopContext context)
        {
            _context = context;
        }
        public IEnumerable<Productcs> productcs;

        public void OnGet()
        {
            productcs = _context.productcs.Include(p => p.item);

        }
        public IActionResult OnGetDelete(int id)
        {   
            var product=_context.productcs.FirstOrDefault(p=>p.Id == id);
            if (product!= null)
            {
                _context.productcs.Remove(product);
                _context.SaveChanges(); 
            }
            var items=_context.items.FirstOrDefault(p=>p.Id == id);
            if (items != null)
            {
                _context.items.Remove(items);
                _context.SaveChanges();
            }
            return RedirectToPage("Index");
        }

        public void OnPost()
        {
        }
    }
}
