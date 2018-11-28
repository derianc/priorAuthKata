using System;

namespace PriorAuth.Web.Data
{
    public class User : BaseDto
    {
        public User()
        {
            Id = new Random().Next(1, 100);
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
    }
}
