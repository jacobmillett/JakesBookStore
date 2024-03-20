namespace JakesBookStore.Models.ViewModels
{
    public class BooksListViewModel
    {
        public IQueryable<Books> Books { get; set; }

        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
