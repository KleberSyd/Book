using Book.Data;
using Book.Extension;
using Microsoft.EntityFrameworkCore;

namespace Book.Services;

public class BookServices(LibraryContext context)
{
    public async Task<List<Models.Book>> SearchBooksAsync(string searchValue)
    {
        var query = from b in context.Books
            select new Models.Book(b.Title, b.Publisher.Name, b.Authors.ToString(), b.Type, b.Isbn, b.Category, b.AvailableCopies() );


        if (!string.IsNullOrEmpty(searchValue))
        {
            query = query.Where(b =>
                b.Title.Contains(searchValue) ||
                b.Authors.Contains(searchValue) ||
                b.Publisher.Contains(searchValue) ||
                b.ISBN.Contains(searchValue) ||
                b.Category.Contains(searchValue));
        }

        return await query.ToListAsync();
    }
}