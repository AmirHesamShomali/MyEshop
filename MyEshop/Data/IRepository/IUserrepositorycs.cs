using MyEshop.Models;

namespace MyEshop.Data.IRepository
{
    public interface IUserrepositorycs
    {
        void Adduser(Users user);

        bool IsexistbyEmail(string email);

        Users Getuserlogin(string email,string password);
    }
}
