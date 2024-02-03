namespace Book.ValueObject;

public class Author(string firstName, string lastName)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}