#nullable enable

//it works not only with records, but still it is a good example
List<PersonGroup<Person>> groups = new()
{
    new()
    {
        Name = "FirstGroup",
        PersonToScore = new()
        {
            [new("John", "Doe")] = new() { 100, 99 },
            [new("James", "Smith")] = new() { 90, 89 },
        }
    },
    new()
    {
        Name = "SecondGroup",
        PersonToScore = new()
        {
            [new("Scott", "Hunter")] = new() { 80, 79 },
            [new("Scott", "Hanselman")] = new() { 70, 69 },
        }
    },
};

DisplayGroups();


void DisplayGroups()
{
    foreach (var group in groups)
    {
        WriteLine($"group:{group.Name}\tscore:{group.PersonToScore.SelectMany(kvp => kvp.Value).Sum()}");
        WriteLine($"{string.Join(',', group.PersonToScore.Keys)}{Environment.NewLine}");
    }
}

class PersonGroup<T> where T : Person
{
    public Dictionary<T, List<int>> PersonToScore { get; init; } = new();
    public string Name { get; init; } = string.Empty;
}

record Person(string FirstName, string LastName);
