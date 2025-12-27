namespace MyEshop.Models
{
    public class Productcs
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int itemid { get; set; }

        public int numbers { get; set; }

        //List<Categorie> categories;

        public ICollection<Categoritoproduct> categotitoProducts { get; set; }
        public item item { get; set; }



    }
}
