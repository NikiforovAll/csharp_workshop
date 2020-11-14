#nullable enable


public class Person0
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}

public class Person1
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
}

public record Person2
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
}

public record Person3(string FirstName, string LastName);

public record Student(string FirstName, string LastName) : Person3(FirstName, LastName)
{
    public int Score { get; set; }
}
