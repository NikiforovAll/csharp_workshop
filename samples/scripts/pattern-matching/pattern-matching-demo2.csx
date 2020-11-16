int limit = 100;

SolveFizzBuzz(Sequence);


public void SolveFizzBuzz(Func<IEnumerable<int>> sequence) =>
    sequence()
        .Select(i => (i % 3 == 0, i % 5 == 0, i) switch
            {
                (true, false, _) => "Fizz",
                (false, true, _) => "Buzz",
                (true, true, _) => "FizzBuzz",
                _ => $"i"
            })
            .ToList()
            .ForEach(WriteLine);

IEnumerable<int> Sequence() => Enumerable.Range(1, limit);
