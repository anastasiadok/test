using System.Collections.Generic;

namespace WebApplication3.Models.Interfaces
{
    public interface IUserService
    {
        /*IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        IEnumerable<User> GetUsersByRole(string role);*/
        User GetUserByEmail(string email);
    }
}
