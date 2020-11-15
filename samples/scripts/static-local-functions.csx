using System.Runtime.CompilerServices;
#nullable enable

// static local function
// local function attributes
// ref-return
// target typed expressions
// simplified default literal

// TODO: target type expressions
// TODO: simplify default literal
Person?[] people = new Person?[]{
    new Person("John", "Doe"),
    default(Person?),
    new Person("Foo", "Bar"),
};


Assign();
WriteLine($"people[1]: {people[1]}");

void Assign()
{
    ref var p = ref FindFreePlace();
    p = people[0];
    ref Person FindFreePlace(
        [CallerFilePath] string? sourceFilePath = default)
    {
        WriteLine($"Called from: {sourceFilePath}");
        return ref Find(people)!;

        static ref T Find<T>(T[] source)
        {
            for (var i = 0; i < source.Length; i++)
            {
                if (source[i] is null)
                    return ref source[i];
            }
            throw new InvalidOperationException(nameof(Find));
        }
    }
}


public record Person(string FirstName, string LastName);

// REFERENCE
// https://devblogs.microsoft.com/premier-developer/dissecting-the-local-functions-in-c-7/
