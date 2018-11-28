using System.Collections.Generic;
using System.Threading.Tasks;
using PriorAuth.Web.Data;

namespace PriorAuth.Web.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User CreateUser(User user);
        User UpdateUser(User user);
        List<User> GetAllUsers();
        User GetUserById(int id);
    }
}
