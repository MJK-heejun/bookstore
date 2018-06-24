using bookstore.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace bookstore.Dto
{
    public class BookDto
    {
        [Required]
        public int id { get; set; }
        [Required, StringLength(450, ErrorMessage = "Title cannot be longer than 450 characters.")]
        public string title {get; set;}
        [StringLength(8000, ErrorMessage = "description cannot be longer than 8000 characters.")]
        public string description { get; set; }
        [StringLength(150, ErrorMessage = "Author cannot be longer than 150 characters.")]
        public string author { get; set; }
        public GenreEnum genre { get; set; }
        [DataType(DataType.Date)]
        public DateTime published_date { get; set; }
    }
}
