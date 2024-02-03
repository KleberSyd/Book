namespace Book.Entities;

public class Book
{
    public Book()
    {
        
    }
    public Book(string title, string firstName, string lastName, string type, string isbn, string category)
    {
        Title = title;
        FirstName = firstName;
        LastName = lastName;
        Type = type;
        Isbn = isbn;
        Category = category;
    }
    public int BookId { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int TotalCopies { get; set; } = 0;
    public int CopiesInUse { get; set; } = 0;
    public string Type { get; set; }
    public string Isbn { get; set; }
    public string Category { get; set; }
}