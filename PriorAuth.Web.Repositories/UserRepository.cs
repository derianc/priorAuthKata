using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using PriorAuth.Web.Data;
using PriorAuth.Web.Repositories.Interfaces;

namespace PriorAuth.Web.Repositories
{
    public class UserRepository : IUserRepository
    {
        public async Task<User> CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
