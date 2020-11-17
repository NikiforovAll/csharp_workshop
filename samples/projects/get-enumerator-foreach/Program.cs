using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        // GetEnumerator as extension method to be used in foreach
        foreach (var item in (1, 2, 3))
        {
            Console.WriteLine(item);
        }

        // TODO: add await
    }
}
