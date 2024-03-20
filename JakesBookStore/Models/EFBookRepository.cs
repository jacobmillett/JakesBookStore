
using SQLitePCL;

namespace JakesBookStore.Models
{
    public class EFBookRepository : IBookRepository
    {
        private JakesBooksContext _context;
        public EFBookRepository(JakesBooksContext temp)
        {
            _context = temp;
        }
        public IQueryable<Books> Books => _context.Books;
    }
}
