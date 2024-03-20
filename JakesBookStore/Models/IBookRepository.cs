namespace JakesBookStore.Models
{
    public interface IBookRepository
    {
        public IQueryable<Books> Books { get; }
    }
}
