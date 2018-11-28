using PriorAuth.Web.Data;

namespace PriorAuth.Web.Repositories.Extensions
{
    public static class UserRepositoryExtensions
    {
        public static int GenerateNewId(this User user)
        {
            return new System.Random().Next(1, 100);        
        }

        public static void UpdateUser(this User existingUser, User updatedUser)
        {
            existingUser.FirstName = updatedUser.FirstName;
            existingUser.LastName = updatedUser.LastName;
            existingUser.UserName = updatedUser.UserName;
        }
    }
}
