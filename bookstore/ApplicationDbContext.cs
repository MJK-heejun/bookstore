using Microsoft.EntityFrameworkCore;

namespace bookstore.Dto
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<BookDto> Books { get; set; }
    }
}
