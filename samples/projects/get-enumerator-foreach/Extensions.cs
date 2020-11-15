using System;
using System.Collections.Generic;
using System.Threading.Tasks;
static class Extensions
{
    public static IAsyncEnumerator<int> GetAsyncEnumerator(
        this ValueTuple<int, int, int> tuple) => GetAsyncEnumeratorInternal(tuple);

    public static IEnumerator<int> GetEnumerator(
        this ValueTuple<int, int, int> tuple) => GetEnumeratorInternal(tuple);

    static async IAsyncEnumerator<int> GetAsyncEnumeratorInternal (
        ValueTuple<int, int, int> tuple)
    {
        foreach (var item in tuple)
        {
            await Task.Delay(100);
            Console.WriteLine($"\tDelay...");
            yield return item;
        }
    }
    public static IEnumerator<int> GetEnumeratorInternal(
        ValueTuple<int, int, int> tuple)
    {
        yield return tuple.Item1!;
        yield return tuple.Item2!;
        yield return tuple.Item3!;
    }
}
