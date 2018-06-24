using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore.Dto
{
    public class BookDtoContext : DbContext
    {
        public BookDtoContext(DbContextOptions<BookDtoContext> options) : base(options) { }
        public DbSet<BookDto> Books { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=bookstore;Trusted_Connection=True;");
        //}
    }

}
