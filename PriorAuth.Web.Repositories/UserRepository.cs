using System;
using System.Linq;
using System.Collections.Generic;

using Microsoft.Extensions.Caching.Memory;

using PriorAuth.Web.Data;
using PriorAuth.Web.Repositories.Interfaces;
using PriorAuth.Web.Repositories.Extensions;

namespace PriorAuth.Web.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMemoryCache _cache;
        private List<User> _users;

        public UserRepository(IMemoryCache cache)
        {
            _cache = cache;

            if (_cache.TryGetValue("userList", out List<User> users))
                _users = users;
            else
                SeedData();
        }

        #region Public Methods

        public User CreateUser(User user)
        {
            if (user.Id == 0)
                user.Id = user.GenerateNewId();

            _users.Add(user);

            return user;
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public User GetUserById(int id)
        {
            return _users.Where(u => u.Id == id).FirstOrDefault();
        }

        public User UpdateUser(User user)
        {
            if (user.Id == 0)
                throw new ArgumentException("user not found");

            // get existing user
            var existingUser = GetUserById(user.Id);

            if (existingUser == null)
                throw new ArgumentException("user not found");

            // update existing user detail
            existingUser.UpdateUser(user);

            return existingUser;
        }

        #endregion

        #region Private Methods

        private void SeedData()
        {
            _users = new List<User>()
            {
                new User()
                {
                    FirstName = "Jean-Luc",
                    LastName = "Picard",
                    UserName = "JPicard"
                },
                new User()
                {
                    FirstName = "Abraham",
                    LastName = "Lincoln",
                    UserName = "ALincoln"
                },
                new User()
                {
                    FirstName = "Marilyn",
                    LastName = "Monroe",
                    UserName = "MMonroe"
                },
                new User()
                {
                    FirstName = "Mother",
                    LastName = "Teresa",
                    UserName = "MTeresa"
                },
                new User()
                {
                    FirstName = "Oprah",
                    LastName = "Winfrey",
                    UserName = "OWinfrey"
                },
                new User()
                {
                    FirstName = "Angelina",
                    LastName = "Joelie",
                    UserName = "AJoelie"
                }
            };

            _cache.Set("userList", _users);
        }

        #endregion
    }
}
