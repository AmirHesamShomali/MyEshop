using System.ComponentModel.DataAnnotations;

namespace MyEshop.Models
{
    public class categorycs
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Categoritoproduct> categoritoproducts { get; set; }
    }
}
