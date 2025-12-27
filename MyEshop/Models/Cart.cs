namespace MyEshop.Models
{
    public class Cart
    {
        public Cart()
        {
            cartitems = new List<Cartitem>();

        }
        public int overid { get; set; }

        public List<Cartitem> cartitems { get; set; }

        public void Add(Cartitem item)
        {
            if(cartitems.Exists(i=>i.item.Id==item.item.Id))
            {
                cartitems.Find(i => i.item.Id == item.item.Id).quntity += 1;

            }
            else
            {
                cartitems.Add(item);    
            }

        }

        public void remove(int itemid)
        {
            var item=cartitems.SingleOrDefault(i=>i.item.Id==itemid);
            if(item?.quntity<=1)
            {
                
                cartitems.Remove(item);
            }
            else if(item!=null)
            {
                item.quntity -= 1;
            }

        }
    }
}
