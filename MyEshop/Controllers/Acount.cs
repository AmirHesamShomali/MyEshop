using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using MyEshop.Data;
using MyEshop.Data.IRepository;
using MyEshop.Models;
using System.Security.Claims;
namespace MyEshop.Controllers
{
    public class Acount : Controller
	{
        private IUserrepositorycs _userrepositorycs;

        public Acount(IUserrepositorycs userrepositorycs)
        {
            _userrepositorycs = userrepositorycs;
        }   

        public IActionResult Register()
		{
			return View();
		}
		[HttpPost]
        public IActionResult Register(RegisterViewModel register)
        {
            if(!ModelState.IsValid)
			{
				return View(register);	
			}
            if(_userrepositorycs.IsexistbyEmail(register.email))
            {
                ModelState.AddModelError("email", "ایمیل وارد شده قبلا ثبت نام کرده است");
                return View(register);
            }

            Users users = new Users();  
            users.email = register.email.ToLower();
            users.password= register.password.ToLower();
            users.Registerdate = DateTime.Now;

            _userrepositorycs.Adduser(users);


			return View("Success");	
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if(!ModelState.IsValid) {
            return View(loginViewModel);
            }

            var user=_userrepositorycs.Getuserlogin(loginViewModel.email,loginViewModel.password);
            if(user==null) {
                ModelState.AddModelError("email", " ایمیل وارد شده اشتباه است");
                return View(loginViewModel);    
            }
            var claims = new List<Claim>
 {
            new Claim(ClaimTypes.NameIdentifier, user.userid.ToString()),
              new Claim(ClaimTypes.Name, user.email),
              new Claim("IsAdmin", user.IsAdmin.ToString()),

              // new Claim("CodeMeli", user.Email),

 };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);

            var properties = new AuthenticationProperties
            {
                IsPersistent = loginViewModel.Rememberme
            };

            HttpContext.SignInAsync(principal, properties);

            return Redirect("/");
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("login");
        }
    }
}
