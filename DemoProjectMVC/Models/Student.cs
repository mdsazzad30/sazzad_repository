using System.ComponentModel.DataAnnotations;

namespace DemoProjectMVC.Models
{
    public class Student : Base
    {

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Contact { get; set; } = string.Empty;
    }
}
