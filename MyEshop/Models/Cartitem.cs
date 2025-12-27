namespace MyEshop.Models
{
    public class Cartitem
    {
        public int Id { get; set; }

        public item item { get; set; }

        public int quntity { get; set; }

        public decimal gettotalprice()
        {
            return quntity*item.price;
        }
    }
}
