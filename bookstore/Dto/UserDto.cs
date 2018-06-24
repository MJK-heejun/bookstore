using System.ComponentModel.DataAnnotations;

namespace bookstore.Dto
{
    public class UserDto
    {
        public int id { get; set; }
        [Required, StringLength(45, ErrorMessage = "username cannot be longer than 45 characters.")]
        public string username {get; set;}
        [Required, StringLength(45, ErrorMessage = "password cannot be longer than 45 characters.")]
        public string password { get; set; }
        [StringLength(100, ErrorMessage = "Author cannot be longer than 150 characters.")]
        public string token { get; set; }
    }
}
