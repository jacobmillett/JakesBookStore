using Microsoft.EntityFrameworkCore;

namespace JakesBookStore.Models
{
    public class JakesBooksContext : DbContext
    {
        public JakesBooksContext (DbContextOptions<JakesBooksContext> options) : base(options) { }

        public DbSet<Books> Books { get; set; }
    }
}
