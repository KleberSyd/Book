namespace Book.Data;
public class Book
{
    public Book(string title, string publisher, string authors, string type, string isbn, string category, string availableCopies)
    {
        Title = title;
        Publisher = publisher;
        Authors = authors;
        Type = type;
        ISBN = isbn;
        Category = category;
        AvailableCopies = availableCopies;
    }

    public string Title { get; set; }
    public string Publisher { get; set; }
    public string Authors { get; set; }
    public string Type { get; set; }
    public string ISBN { get; set; }
    public string Category { get; set; }
    public string AvailableCopies { get; set; }
}