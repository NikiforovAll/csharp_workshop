#nullable enable

Contact? c = new Contact("Alexey");
WriteLine($"Hello {c.Name}");
public record Contact(string Name);
