#nullable enable

// null coalescing assignment C# 8
// throw expressions C# 7


// TODO: simplify
int?[] scores = { 1, default(int?), 10, 20 }; // C#7 default literal

WriteLine($"scores[1] is null: {scores[1] is null}");
Assign();
WriteLine($"scores[1]: {scores[1]}");

void Assign()
{
    ref var score = ref scores[1];
    score ??= 5; // same as: score = score ?? 5;
    _ = score ?? throw new InvalidOperationException(nameof(Assign)); // C# 7 - throw expressions
    score ??= 7;
}
