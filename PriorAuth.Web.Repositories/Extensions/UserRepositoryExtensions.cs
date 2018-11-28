using PriorAuth.Web.Data;

namespace PriorAuth.Web.Repositories.Extensions
{
    public static class UserRepositoryExtensions
    {
        public static void UpdateUser(this User existingUser, User updatedUser)
        {
            existingUser.FirstName = updatedUser.FirstName;
            existingUser.LastName = updatedUser.LastName;
            existingUser.UserName = updatedUser.UserName;
        }
    }
}
