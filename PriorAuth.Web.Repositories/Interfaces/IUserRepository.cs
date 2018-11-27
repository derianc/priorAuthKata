using System.Collections.Generic;
using System.Threading.Tasks;
using PriorAuth.Web.Data;

namespace PriorAuth.Web.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> CreateUser(User user);
        Task<User> UpdateUser(User user);
        Task<List<User>> GetAllUsers();
        Task<User> GetUserById(int id);
    }
}
