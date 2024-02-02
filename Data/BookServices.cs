namespace Book.Data;

public class BookServices
{
    private readonly List<Book> _allBooks = new()
    {
        new Book(title: "The Power of Moments", publisher: "New York Times", authors: "Dan Heath, Chip Heath",
            type: "Hardcover", isbn: "123456", category: "Fiction", availableCopies: "2/5"),
        new Book(title: "A Million Little Pieces", publisher: "Simon & Schuster Inc", authors: "James Frey",
            type: "PaperBack", isbn: "23456", category: "Fiction", availableCopies: "3/5"),
        new Book(title: "The Dreamer", publisher: "Scholastic Inc.", authors: "Pam Muñoz Ryan", type: "Paperback",
            isbn: "8976", category: "Fiction", availableCopies: "2/6"),
    };

    public Task<List<Book>> SearchBooksAsync(string searchBy, string searchValue)
    {
        var query = _allBooks.AsQueryable();

        if (string.IsNullOrEmpty(searchBy) || string.IsNullOrEmpty(searchValue)) return Task.FromResult(query.ToList());
        query = searchBy.ToLower() switch
        {
            "title" => query.Where(b => b.Title.Contains(searchValue, StringComparison.OrdinalIgnoreCase)),
            "author" => query.Where(b => b.Authors.Contains(searchValue, StringComparison.OrdinalIgnoreCase)),
            "publisher" => query.Where(b => b.Publisher.Contains(searchValue, StringComparison.OrdinalIgnoreCase)),
            _ => query
        };

        return Task.FromResult(query.ToList());
    }
}