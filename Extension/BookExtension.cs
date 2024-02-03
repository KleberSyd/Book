namespace Book.Extension;

public static class BookExtension
{
    public static string AvailableCopies(this Entities.Book book)
    {
        return $"{book.TotalCopies - book.CopiesInUse}/{book.TotalCopies}";
    }
}