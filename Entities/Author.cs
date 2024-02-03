namespace Book.Entities;

public class Author(string firstName, string lastName)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public object? AuthorId { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}