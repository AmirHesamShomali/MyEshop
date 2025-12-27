using System.ComponentModel.DataAnnotations;

namespace MyEshop.Models
{
	public class Users
	{
        [Key] 
        public int userid { get; set; }

        [Required]
        [MaxLength(300)]
        public string email { get; set; }


		[Required]
		[MaxLength(50)]
		public string password { get; set; }

		[Required]
		public DateTime Registerdate { get; set; }

        public bool IsAdmin { get; set; }
    }
}
