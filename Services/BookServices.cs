namespace Book.Services;

public class BookServices
{
    private readonly List<Models.Book> _allBooks = new()
    {
        new Models.Book(title: "The Power of Moments", publisher: "New York Times", authors: "Dan Heath, Chip Heath",
            type: "Hardcover", isbn: "123456", category: "Fiction", availableCopies: "2/5"),
        new Models.Book(title: "A Million Little Pieces", publisher: "Simon & Schuster Inc", authors: "James Frey",
            type: "PaperBack", isbn: "23456", category: "Fiction", availableCopies: "3/5"),
        new Models.Book(title: "The Dreamer", publisher: "Scholastic Inc.", authors: "Pam Muñoz Ryan", type: "Paperback",
            isbn: "8976", category: "Fiction", availableCopies: "2/6"),
    };

    public Task<List<Models.Book>> SearchBooksAsync(string searchValue)
    {
        var query = _allBooks.AsQueryable();

        if (!string.IsNullOrEmpty(searchValue))
        {
            query = query.Where(b =>
                b.Title.Contains(searchValue, StringComparison.OrdinalIgnoreCase) ||
                b.Authors.Contains(searchValue, StringComparison.OrdinalIgnoreCase) ||
                b.Publisher.Contains(searchValue, StringComparison.OrdinalIgnoreCase) ||
                b.ISBN.Contains(searchValue) ||
                b.Category.Contains(searchValue, StringComparison.OrdinalIgnoreCase));
        }

        return Task.FromResult(query.ToList());
    }
}