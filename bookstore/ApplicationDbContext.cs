using Microsoft.EntityFrameworkCore;

namespace bookstore.Dto
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<BookDto> Books { get; set; }
        public DbSet<UserDto> Users { get; set; }
    }
}
