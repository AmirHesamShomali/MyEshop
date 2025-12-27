using MyEshop.Controllers;
using MyEshop.Data;
using MyEshop.Models;

namespace MyEshop.Data.IRepository
{
    public class Userrepositorycs : IUserrepositorycs
    {
        private readonly ILogger<Userrepositorycs> _logger;

        private MyEshopContext _context;
        public Userrepositorycs(ILogger<Userrepositorycs> logger, MyEshopContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void Adduser(Users user)
        {
            _context.users.Add(user);
            _context.SaveChanges();
        }

        public Users Getuserlogin(string email, string password)
        {
            return _context.users.SingleOrDefault(u => u.email == email && u.password == password);
        }

        public bool IsexistbyEmail(string email)
        {
            return _context.users.Any(p => p.email == email);

        }
    }
}
