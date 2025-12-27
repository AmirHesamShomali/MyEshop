namespace MyEshop.Models
{
    public class item
    {
        public int Id { get; set; }

        public decimal price { get; set; }

        public int Quentitystock { get; set; }

        public Productcs productcs { get; set; }
    }
}
