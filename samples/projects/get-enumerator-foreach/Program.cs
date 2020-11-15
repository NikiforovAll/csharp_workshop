using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        // TODO: add await
        foreach (var item in (1, 2, 3))
        {
            Console.WriteLine(item);
        }
    }
}
