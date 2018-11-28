using System.ComponentModel.DataAnnotations;

namespace PriorAuth.Web.Data
{
    public class BaseDto
    {
        [Key]
        public int Id { get; set; }
    }
}
