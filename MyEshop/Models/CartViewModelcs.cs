namespace MyEshop.Models
{
    public class CartViewModelcs
    {
        public CartViewModelcs()
        {
            cartitem = new List<Cartitem>();
        }
        public List<Cartitem> cartitem { get; set; }
        public decimal  ordertotal { get; set; }

    }
}
