namespace MyEshop.Models
{
    public class AddEditproductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Discribtion { get; set; }

        public Decimal Price { get; set; }

        public int QuintityStock { get; set; }

        public IFormFile Picture { get; set; }
    }
}
