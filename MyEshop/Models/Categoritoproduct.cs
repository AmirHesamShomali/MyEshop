using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEshop.Models
{
    public class Categoritoproduct
    {
       
        public int categoriid { get; set; }

        public int productid { get; set;}

        public categorycs categorycs { get; set; }

        public Productcs productcs { get; set; }
    }
}
