namespace Book.Models;
public class Book(
    string title,
    string publisher,
    string authors,
    string type,
    string isbn,
    string category,
    string availableCopies)
{
    public string Title { get; set; } = title;
    public string Publisher { get; set; } = publisher;
    public string Authors { get; set; } = authors;
    public string Type { get; set; } = type;
    public string ISBN { get; set; } = isbn;
    public string Category { get; set; } = category;
    public string AvailableCopies { get; set; } = availableCopies;
}