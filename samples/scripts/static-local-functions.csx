using System.Runtime.CompilerServices;
#nullable enable

// static local function C# 8
// local function attributes C# 9
// ref-return C# 8
// target typed expressions C# 9
// simplified default literal C# 7.1

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

