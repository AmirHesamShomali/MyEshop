using System.ComponentModel.DataAnnotations;

namespace MyEshop.Models
{
	public class RegisterViewModel
	{

		[Required(ErrorMessage ="لطفا ایمیل را به درستی وارد کنید!")]
		[MaxLength(300)]
		[EmailAddress]
		
		
		public string email { get; set; }


        [Required(ErrorMessage = "رمز عبور را  وارد کنید!")]
        [MaxLength(50)]
		[DataType(DataType.Password)]
		public string password { get; set; }

		[Required(ErrorMessage ="رمز عبور را به درستی وارد کنید!")]
		[MaxLength(50)]
		[DataType(DataType.Password)]
		[Compare("password")]
		public string Repassword { get; set; }

	}
}
