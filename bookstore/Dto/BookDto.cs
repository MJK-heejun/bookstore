using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore.Dto
{
    public class BookDto
    {
        public int id { get; set; }
        public string title {get; set;}
        public string description { get; set; }
        public string author { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime published_date { get; set; }
    }
}
