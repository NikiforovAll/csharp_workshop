using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Preview
{
    class Program
    {
        public static int counter = 0;
            
        [ModuleInitializer]
        public static void Main()
        {
            Console.WriteLine($"Hello world {++counter}");
        }
    }
}
