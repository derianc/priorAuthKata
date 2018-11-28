using System.Threading.Tasks;
using System.Collections.Generic;

using PriorAuth.Web.Data;
using PriorAuth.Web.Services.Interfaces;
using PriorAuth.Web.Repositories.Interfaces;

namespace PriorAuth.Web.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<User> CreateUser(User user)
        {
            return _userRepository.CreateUser(user);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<User>> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<User> GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<User> UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }
    }
}
