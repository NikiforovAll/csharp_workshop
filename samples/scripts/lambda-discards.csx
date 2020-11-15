#nullable enable

var (first, second) = ((1, 2, 3), (4, 5, 6));
Expression<Func<(int x, int y, int z), (int a, int b, int c), int>> a =
    (first, second) => first.x + first.y + first.z + second.a + second.b + second.c;

WriteLine($"{a}");
WriteLine($"{a.Compile()(first, second)}");

a = (_, second) => second.a + second.b + second.c;

WriteLine($"{a}");
WriteLine($"{a.Compile()(first, second)}");

a = (_, _) => 0;

WriteLine($"{a}");
WriteLine($"{a.Compile()(first, second)}");

a = (first, _) => Unwrap(first);

static int Unwrap((int, int, int) first)
{
    var (res, _, _) = first;
    return res;
}

WriteLine($"{a}");
WriteLine($"{a.Compile()(first, second)}");
