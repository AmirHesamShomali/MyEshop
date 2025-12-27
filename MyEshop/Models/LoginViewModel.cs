using System.ComponentModel.DataAnnotations;

namespace MyEshop.Models
{
    public class LoginViewModel
    {
        [Required]
        [MaxLength(300)]
        public string email { get; set; }


        [Required]  
        [MaxLength(50)]
        public string password { get; set; }

        [Display(Name ="مرابخاطر بسپار")]
        public bool Rememberme { get; set; }
    }
}
