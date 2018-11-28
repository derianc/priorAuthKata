using System.Threading.Tasks;
using System.Collections.Generic;

using PriorAuth.Web.Data;

namespace PriorAuth.Web.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> CreateUser(User user);
        Task<User> UpdateUser(User user);
        Task<List<User>> GetAllUsers();
        Task<User> GetUserById(int id);
    }
}
