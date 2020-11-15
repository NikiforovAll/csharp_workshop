#nullable enable

var p = new Person("John", "Doe", default);
WriteLine(p.FullName);

// * special attributes to decorate methods (hit F12 to inspect)
if(!string.IsNullOrEmpty(p.MiddleName))
{
    WriteLine($"The middle name is: {p.MiddleName}");
}
else
{
    // ! NRE
    // WriteLine(p.MiddleName.Length);
}

// * same with pattern matching
if (p.MiddleName is { Length: > 0 } name)
{
    WriteLine($"The middle name is: {name}");
}

public class Person
{
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName, string? middleName) =>
            (FirstName, MiddleName, LastName) = (firstName, middleName, lastName);

    // TODO: fix this
    public string FullName => $"{FirstName} {MiddleName[0]} {LastName}";
}

