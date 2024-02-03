using Book.Entities;

namespace Book.Extension
{
    public static class AuthorExtension
    {
        public static string Author(this Entities.Book book)
        {
            return $"{book.FirstName} {book.LastName}";
        }
        public static string ToString(this ICollection<Author> authors)
        {
            return string.Join(", ", authors);
        }

    }
}